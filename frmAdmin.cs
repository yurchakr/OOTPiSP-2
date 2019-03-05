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
    public partial class frmAdmin : Form
    {
        OrderContext db;
        public frmAdmin()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Helicopters.Load();
            db.Airplanes.Load();
            db.Planes.Load();
            db.Gliders.Load();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            frmAircraft Addfrm = new frmAircraft();
            if (cbType.SelectedIndex != -1)
                Addfrm.tbType.Text = cbType.SelectedItem.ToString();

            if (cbType.SelectedIndex == 0)
            {
                Addfrm.tbEngPwr.Visible = true;
                Addfrm.tbRotDiam.Visible = true;
                DialogResult dlgRes = Addfrm.ShowDialog(this);
                if (dlgRes == DialogResult.Cancel)
                {
                    return;
                }

                Helicopter helic = new Helicopter();
                helic.Name = Addfrm.tbName.Text;
                helic.TailNumber = Addfrm.tbTailNum.Text;
                helic.MaxSpeed = Convert.ToInt32(Addfrm.tbMaxSp.Text);
                helic.MaxFlightDistance = Convert.ToInt32(Addfrm.tbFlDist.Text);
                helic.RotorDiameter = Convert.ToInt32(Addfrm.tbRotDiam.Text);
                helic.EnginePower = Convert.ToInt32(Addfrm.tbEngPwr.Text);

                db.Helicopters.Add(helic);
                db.SaveChanges();
                cbType.SelectedIndex = -1;
                cbType.SelectedIndex = 0;
            }
            if (cbType.SelectedIndex == 1)
            {
                Addfrm.tbWingspan.Top = Addfrm.tbWingspan.Top - 37;
                Addfrm.tbWingspan.Visible = true;
                DialogResult dlgRes = Addfrm.ShowDialog(this);
                if (dlgRes == DialogResult.Cancel)
                {
                    return;
                }

                Airplane airPln = new Airplane();
                airPln.Name = Addfrm.tbName.Text;
                airPln.TailNumber = Addfrm.tbTailNum.Text;
                airPln.MaxSpeed = Convert.ToInt32(Addfrm.tbMaxSp.Text);
                airPln.MaxFlightDistance = Convert.ToInt32(Addfrm.tbFlDist.Text);
                airPln.Wingspan = Convert.ToInt32(Addfrm.tbWingspan.Text);

                db.Airplanes.Add(airPln);
                db.SaveChanges();
                cbType.SelectedIndex = -1;
                cbType.SelectedIndex = 1;
            }
            if (cbType.SelectedIndex == 2)
            {
                Addfrm.tbEngPwr.Visible = true;
                Addfrm.tbWingspan.Top = Addfrm.tbWingspan.Top - 37;
                Addfrm.tbWingspan.Visible = true;
                DialogResult dlgRes = Addfrm.ShowDialog(this);
                if (dlgRes == DialogResult.Cancel)
                {
                    return;
                }

                Plane pln = new Plane();
                pln.Name = Addfrm.tbName.Text;
                pln.TailNumber = Addfrm.tbTailNum.Text;
                pln.MaxSpeed = Convert.ToInt32(Addfrm.tbMaxSp.Text);
                pln.MaxFlightDistance = Convert.ToInt32(Addfrm.tbFlDist.Text);
                pln.Wingspan = Convert.ToInt32(Addfrm.tbWingspan.Text);
                pln.EnginePower = Convert.ToInt32(Addfrm.tbEngPwr.Text);

                db.Planes.Add(pln);
                db.SaveChanges();
                cbType.SelectedIndex = -1;
                cbType.SelectedIndex = 2;
            }
            if (cbType.SelectedIndex == 3)
            {
                Addfrm.tbLoadCap.Visible = true;
                Addfrm.tbWingspan.Visible = true;
                DialogResult dlgRes = Addfrm.ShowDialog(this);
                if (dlgRes == DialogResult.Cancel)
                {
                    return;
                }

                Glider gldr = new Glider();
                gldr.Name = Addfrm.tbName.Text;
                gldr.TailNumber = Addfrm.tbTailNum.Text;
                gldr.MaxSpeed = Convert.ToInt32(Addfrm.tbMaxSp.Text);
                gldr.MaxFlightDistance = Convert.ToInt32(Addfrm.tbFlDist.Text);
                gldr.Wingspan = Convert.ToInt32(Addfrm.tbWingspan.Text);
                gldr.LoadCapacity = Convert.ToInt32(Addfrm.tbLoadCap.Text);

                db.Gliders.Add(gldr);
                db.SaveChanges();
                cbType.SelectedIndex = -1;
                cbType.SelectedIndex = 3;
            }
            
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                int index = dgvAdmin.SelectedRows[0].Index;
                string Name = dgvAdmin[1, index].Value.ToString();

                if (cbType.SelectedIndex == 0)
                {
                    Helicopter helic = db.Helicopters
                    .Where(helicop => helicop.Name == Name)
                    .FirstOrDefault();

                    db.Helicopters.Remove(helic);
                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 1;
                }
                if (cbType.SelectedIndex == 1)
                {
                    Airplane airPln = db.Airplanes
                    .Where(airPlne => airPlne.Name == Name)
                    .FirstOrDefault();

                    db.Airplanes.Remove(airPln);
                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 2;
                }
                if (cbType.SelectedIndex == 2)
                {
                    Plane pln = db.Planes
                    .Where(plne => plne.Name == Name)
                    .FirstOrDefault();

                    db.Planes.Remove(pln);
                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 3;
                }
                if (cbType.SelectedIndex == 3)
                {
                    Glider gldr = db.Gliders
                    .Where(glder => glder.Name == Name)
                    .FirstOrDefault();

                    db.Gliders.Remove(gldr);
                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 4;
                }
                
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                frmAircraft Editfrm = new frmAircraft();
                if (cbType.SelectedIndex != -1)
                    Editfrm.tbType.Text = cbType.SelectedItem.ToString();
                int index = dgvAdmin.SelectedRows[0].Index;
                string Name = dgvAdmin[1, index].Value.ToString();

                if (cbType.SelectedIndex == 0)
                {
                    Editfrm.tbEngPwr.Visible = true;
                    Editfrm.tbRotDiam.Visible = true;

                    Helicopter helic = db.Helicopters
                    .Where(helicop => helicop.Name == Name)
                    .FirstOrDefault();

                    Editfrm.tbName.Text = helic.Name;
                    Editfrm.tbTailNum.Text = helic.TailNumber;
                    Editfrm.tbMaxSp.Text = Convert.ToString(helic.MaxSpeed);
                    Editfrm.tbFlDist.Text = Convert.ToString(helic.MaxFlightDistance);
                    Editfrm.tbRotDiam.Text = Convert.ToString(helic.RotorDiameter);
                    Editfrm.tbEngPwr.Text = Convert.ToString(helic.EnginePower);

                    DialogResult dlgRes = Editfrm.ShowDialog(this);
                    if (dlgRes == DialogResult.Cancel)
                    {
                        return;
                    }


                    helic.Name = Editfrm.tbName.Text;
                    helic.TailNumber = Editfrm.tbTailNum.Text;
                    helic.MaxSpeed = Convert.ToInt32(Editfrm.tbMaxSp.Text);
                    helic.MaxFlightDistance = Convert.ToInt32(Editfrm.tbFlDist.Text);
                    helic.RotorDiameter = Convert.ToInt32(Editfrm.tbRotDiam.Text);
                    helic.EnginePower = Convert.ToInt32(Editfrm.tbEngPwr.Text);

                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 1;
                }
                if (cbType.SelectedIndex == 1)
                {
                    Editfrm.tbWingspan.Top = Editfrm.tbWingspan.Top - 37;
                    Editfrm.tbWingspan.Visible = true;

                    Airplane airPln = db.Airplanes
                    .Where(airPlne => airPlne.Name == Name)
                    .FirstOrDefault();

                    Editfrm.tbName.Text = airPln.Name;
                    Editfrm.tbTailNum.Text = airPln.TailNumber;
                    Editfrm.tbMaxSp.Text = Convert.ToString(airPln.MaxSpeed);
                    Editfrm.tbFlDist.Text = Convert.ToString(airPln.MaxFlightDistance);
                    Editfrm.tbWingspan.Text = Convert.ToString(airPln.Wingspan);

                    DialogResult dlgRes = Editfrm.ShowDialog(this);
                    if (dlgRes == DialogResult.Cancel)
                    {
                        return;
                    }

                    airPln.Name = Editfrm.tbName.Text;
                    airPln.TailNumber = Editfrm.tbTailNum.Text;
                    airPln.MaxSpeed = Convert.ToInt32(Editfrm.tbMaxSp.Text);
                    airPln.MaxFlightDistance = Convert.ToInt32(Editfrm.tbFlDist.Text);
                    airPln.Wingspan = Convert.ToInt32(Editfrm.tbWingspan.Text);

                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 2;
                }
                if (cbType.SelectedIndex == 2)
                {
                    Editfrm.tbEngPwr.Visible = true;
                    Editfrm.tbWingspan.Top = Editfrm.tbWingspan.Top - 37;
                    Editfrm.tbWingspan.Visible = true;

                    Plane pln = db.Planes
                    .Where(plne => plne.Name == Name)
                    .FirstOrDefault();

                    Editfrm.tbName.Text = pln.Name;
                    Editfrm.tbTailNum.Text = pln.TailNumber;
                    Editfrm.tbMaxSp.Text = Convert.ToString(pln.MaxSpeed);
                    Editfrm.tbFlDist.Text = Convert.ToString(pln.MaxFlightDistance);
                    Editfrm.tbWingspan.Text = Convert.ToString(pln.Wingspan);
                    Editfrm.tbEngPwr.Text = Convert.ToString(pln.EnginePower);

                    DialogResult dlgRes = Editfrm.ShowDialog(this);
                    if (dlgRes == DialogResult.Cancel)
                    {
                        return;
                    }

                    pln.Name = Editfrm.tbName.Text;
                    pln.TailNumber = Editfrm.tbTailNum.Text;
                    pln.MaxSpeed = Convert.ToInt32(Editfrm.tbMaxSp.Text);
                    pln.MaxFlightDistance = Convert.ToInt32(Editfrm.tbFlDist.Text);
                    pln.Wingspan = Convert.ToInt32(Editfrm.tbWingspan.Text);
                    pln.EnginePower = Convert.ToInt32(Editfrm.tbEngPwr.Text);

                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 3;
                }
                if (cbType.SelectedIndex == 3)
                {
                    Editfrm.tbLoadCap.Visible = true;
                    Editfrm.tbWingspan.Visible = true;

                    Glider gldr = db.Gliders
                    .Where(glder => glder.Name == Name)
                    .FirstOrDefault();

                    Editfrm.tbName.Text = gldr.Name;
                    Editfrm.tbTailNum.Text = gldr.TailNumber;
                    Editfrm.tbMaxSp.Text = Convert.ToString(gldr.MaxSpeed);
                    Editfrm.tbFlDist.Text = Convert.ToString(gldr.MaxFlightDistance);
                    Editfrm.tbWingspan.Text = Convert.ToString(gldr.Wingspan);
                    Editfrm.tbLoadCap.Text = Convert.ToString(gldr.LoadCapacity);

                     DialogResult dlgRes = Editfrm.ShowDialog(this);
                    if (dlgRes == DialogResult.Cancel)
                    {
                        return;
                    }

                    gldr.Name = Editfrm.tbName.Text;
                    gldr.TailNumber = Editfrm.tbTailNum.Text;
                    gldr.MaxSpeed = Convert.ToInt32(Editfrm.tbMaxSp.Text);
                    gldr.MaxFlightDistance = Convert.ToInt32(Editfrm.tbFlDist.Text);
                    gldr.Wingspan = Convert.ToInt32(Editfrm.tbWingspan.Text);
                    gldr.LoadCapacity = Convert.ToInt32(Editfrm.tbLoadCap.Text);

                    db.SaveChanges();
                    cbType.SelectedIndex = 0;
                    cbType.SelectedIndex = 4;
                }
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == -1)
            {
                dgvAdmin.Columns.Clear();
            }
            if (cbType.SelectedIndex == 0)
            {
                LoadHelicopters(dgvAdmin);
            }
            if (cbType.SelectedIndex == 1)
            {
                LoadAirplanes(dgvAdmin);
            }
            if (cbType.SelectedIndex == 2)
            {
                LoadPlanes(dgvAdmin);
            }
            if (cbType.SelectedIndex == 3)
            {
                LoadGliders(dgvAdmin);
            }
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

    }
}
