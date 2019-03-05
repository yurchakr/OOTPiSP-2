using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace OOTPiSP__2
{
    public partial class frmMain : Form
    {
        OrderContext db;
        User authUsr;
        public frmMain()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Users.Load();
            db.UserProfiles.Load();
            db.Helicopters.Load();
            db.Airplanes.Load();
            db.Planes.Load();
            db.Gliders.Load();
            db.Orders.Load();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            authUsr = Authentification();

            if (authUsr.UserName == "Admin")
            {
                frmAdmin admFrm = new frmAdmin();
                FillTheCB(admFrm.cbType);
                admFrm.ShowDialog();
                Close();
            }
            else
            {
                FillTheCB(cbType);
            }
        }

        private User Authentification()
        {
            frmLogin logFrm = new frmLogin();
            DialogResult dlgres = logFrm.ShowDialog(this);

            if (dlgres == DialogResult.Cancel)
                Close();

            if (dlgres == DialogResult.OK)
            {
                User usr = new User();
                usr.UserName = logFrm.tbUserName.Text;
                usr.Password = logFrm.tbPass.Text;

                UserProfile usrPrfl = new UserProfile();
                usrPrfl.Mail = logFrm.tbMail.Text;
                usrPrfl.Name = logFrm.tbName.Text;
                usrPrfl.PhoneNum = "";
                db.UserProfiles.Add(usrPrfl);

                usr.Profile = usrPrfl;
                db.Users.Add(usr);
                db.SaveChanges();
                return usr;
            }

            User usrFind = db.Users
                    .Where(user => user.UserName == logFrm.tbUserName.Text)
                    .FirstOrDefault();

            if ((usrFind == null) || (usrFind.Password != logFrm.tbPass.Text))
            {
                logFrm.tbUserName.Text = "Input your username";
                logFrm.tbPass.Text = "Input your password";
                logFrm.tbName.Text = "Input your name";
                logFrm.tbMail.Text = "Input your mail";

                Authentification();
            }

            return usrFind;

        }

        private void LoadHelicopters(DataGridView dgv)
        {
            dgv.Columns.Clear();

            dgv.Columns.Add("Number", "№");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("TailNumber", "Бортовой номер");
            dgv.Columns.Add("MaxSpeed", "Максимальная скорость, км/ч");
            dgv.Columns.Add("MaxFlightDistance", "Максимальная дистанция полета, км");
            dgv.Columns.Add("RotorDiameter", "Диаметр винта, м");
            dgv.Columns.Add("EnginePower", "Мощность двигателя, л.с.");

            List<Helicopter> Helicopters = db.Helicopters.Local.ToList();
            foreach (Helicopter helic in Helicopters)
            {
                dgv.Rows.Add();
                int row = dgv.RowCount - 1;
                dgv[0, row].Value = row + 1;
                dgv[1, row].Value = helic.Name;
                dgv[2, row].Value = helic.TailNumber;
                dgv[3, row].Value = helic.MaxSpeed;
                dgv[4, row].Value = helic.MaxFlightDistance;
                dgv[5, row].Value = helic.RotorDiameter;
                dgv[6, row].Value = helic.EnginePower;
            }
        }

        private void LoadAirplanes(DataGridView dgv)
        {
            dgv.Columns.Clear();

            dgv.Columns.Add("Number", "№");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("TailNumber", "Бортовой номер");
            dgv.Columns.Add("MaxSpeed", "Максимальная скорость, км/ч");
            dgv.Columns.Add("MaxFlightDistance", "Максимальная дистанция полета, км");
            dgv.Columns.Add("Wingspan", "Размах крыльев, м");

            List<Airplane> Airplanes = db.Airplanes.Local.ToList();
            foreach (Airplane airPln in Airplanes)
            {
                dgv.Rows.Add();
                int row = dgv.RowCount - 1;
                dgv[0, row].Value = row + 1;
                dgv[1, row].Value = airPln.Name;
                dgv[2, row].Value = airPln.TailNumber;
                dgv[3, row].Value = airPln.MaxSpeed;
                dgv[4, row].Value = airPln.MaxFlightDistance;
                dgv[5, row].Value = airPln.Wingspan;
            }
        }

        private void LoadPlanes(DataGridView dgv)
        {
            dgv.Columns.Clear();

            dgv.Columns.Add("Number", "№");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("TailNumber", "Бортовой номер");
            dgv.Columns.Add("MaxSpeed", "Максимальная скорость, км/ч");
            dgv.Columns.Add("MaxFlightDistance", "Максимальная дистанция полета, км");
            dgv.Columns.Add("Wingspan", "Размах крыльев, м");
            dgv.Columns.Add("EnginePower", "Мощность двигателя, л.с.");

            List<Plane> Planes = db.Planes.Local.ToList();
            foreach (Plane pln in Planes)
            {
                dgv.Rows.Add();
                int row = dgv.RowCount - 1;
                dgv[0, row].Value = row + 1;
                dgv[1, row].Value = pln.Name;
                dgv[2, row].Value = pln.TailNumber;
                dgv[3, row].Value = pln.MaxSpeed;
                dgv[4, row].Value = pln.MaxFlightDistance;
                dgv[5, row].Value = pln.Wingspan;
                dgv[6, row].Value = pln.EnginePower;
            }
        }

        private void LoadGliders(DataGridView dgv)
        {
            dgv.Columns.Clear();

            dgv.Columns.Add("Number", "№");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("TailNumber", "Бортовой номер");
            dgv.Columns.Add("MaxSpeed", "Максимальная скорость, км/ч");
            dgv.Columns.Add("MaxFlightDistance", "Максимальная дистанция полета, км");
            dgv.Columns.Add("Wingspan", "Размах крыльев, м");
            dgv.Columns.Add("LoadCapacity", "Грузоподъемность, кг");

            List<Glider> Gliders = db.Gliders.Local.ToList();
            foreach (Glider gldr in Gliders)
            {
                dgv.Rows.Add();
                int row = dgv.RowCount - 1;
                dgv[0, row].Value = row + 1;
                dgv[1, row].Value = gldr.Name;
                dgv[2, row].Value = gldr.TailNumber;
                dgv[3, row].Value = gldr.MaxSpeed;
                dgv[4, row].Value = gldr.MaxFlightDistance;
                dgv[5, row].Value = gldr.Wingspan;
                dgv[6, row].Value = gldr.LoadCapacity;
            }
        }

        private void FillTheCB(ComboBox cb)
        {
            cb.Items.Add("Вертолет");
            cb.Items.Add("Аэроплан");
            cb.Items.Add("Самолет");
            cb.Items.Add("Планер");
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == -1)
            {
                dgvMain.Columns.Clear();
            }
            if (cbType.SelectedIndex == 0)
            {
                LoadHelicopters(dgvMain);
            }
            if (cbType.SelectedIndex == 1)
            {
                LoadAirplanes(dgvMain);
            }
            if (cbType.SelectedIndex == 2)
            {
                LoadPlanes(dgvMain);
            }
            if (cbType.SelectedIndex == 3)
            {
                LoadGliders(dgvMain);
            }
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 1)
            {
                frmOrder ordrFrm = new frmOrder();

                int index = dgvMain.SelectedRows[0].Index;
                string Name = dgvMain[1, index].Value.ToString();
                Aircraft aircrft = new Aircraft();


                if (cbType.SelectedIndex == 0)
                {
                    Helicopter helic = db.Helicopters
                    .Where(helicop => helicop.Name == Name)
                    .FirstOrDefault();

                    aircrft = helic;
                }
                if (cbType.SelectedIndex == 1)
                {
                    Airplane airPln = db.Airplanes
                    .Where(airPlne => airPlne.Name == Name)
                    .FirstOrDefault();

                    aircrft = airPln;
                }
                if (cbType.SelectedIndex == 2)
                {
                    Plane pln = db.Planes
                    .Where(plne => plne.Name == Name)
                    .FirstOrDefault();

                    aircrft = pln;
                }
                if (cbType.SelectedIndex == 3)
                {
                    Glider gldr = db.Gliders
                    .Where(glder => glder.Name == Name)
                    .FirstOrDefault();

                    aircrft = gldr;
                }

                ordrFrm.tbName.Text = authUsr.Profile.Name;
                ordrFrm.tbMail.Text = authUsr.Profile.Mail;

                ordrFrm.tbAcName.Text = aircrft.Name;
                ordrFrm.tbMaxSp.Text = Convert.ToString(aircrft.MaxSpeed);
                ordrFrm.tbTailNum.Text = Convert.ToString(aircrft.TailNumber);
                ordrFrm.tbMaxDist.Text = Convert.ToString(aircrft.MaxFlightDistance);

                DialogResult dlgRes = ordrFrm.ShowDialog(this);
                if (dlgRes == DialogResult.Cancel)
                    return;

                Order ordr = new Order();
                ordr.User = authUsr;
                ordr.Aircraft = aircrft;
                ordr.DurationOfFlight = Convert.ToInt32(ordrFrm.tbFlDur.Text);
                ordr.OnWhen = ordrFrm.dtpWhen.Value;
                if (ordrFrm.cbPilot.Checked)
                {
                    ordr.NeedPilot = true;
                }
                else
                {
                    ordr.NeedPilot = false;
                }
                db.Orders.Add(ordr);
                db.SaveChanges();

                MessageBox.Show(
                    "ВАШ ЗАКАЗ ПРИНЯТ! В БЛИЖАЙШЕЕ ВРЕМЯ МЫ С ВАМИ СВЯЖЕМСЯ.",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
