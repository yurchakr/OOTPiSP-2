using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Data.Entity;
using System.Reflection;
using System.IO;
using SerializerInterface;
using SerializerLibrary;
using OOTPiSP__2.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace OOTPiSP__2
{
    public partial class frmAdmin : Form
    {
        OrderContext db;
        private AircraftType aircraft;
        private Aircraft[] aircraftsType;

        public frmAdmin()
        {
            InitializeComponent();
            db = new OrderContext();
            db.Helicopters.Load();
            db.Airplanes.Load();
            db.Planes.Load();
            db.Gliders.Load();
            db.Orders.Load();
            db.UserProfiles.Load();
            db.Users.Load();
        } 

        private SaveFileDialog InitializeSaveFile(string filter)
        {
            var file = new SaveFileDialog();
            file.Filter = $"{filter} |*.{filter}";
            file.AddExtension = true;
            file.Title = "Save file";
            return file;
        }
        private OpenFileDialog InitializeOpenFile(string filter)
        {
            var file = new OpenFileDialog();
            file.Filter = $"{filter} |*.{filter}";
            file.AddExtension = true;
            file.Title = "Open file";
            return file;
        }

        private AircraftFactory createAircraftByType(string type)
        {
            if (type == "Вертолет")
                return new HelicopterFactory();
            if (type == "Самолет")
                return new PlaneFactory();
            if (type == "Планер")
                return new GliderFactory();
            if (type == "Аэроплан")
                return new AirplaneFactory();
            return null;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            frmAircraft Addfrm = new frmAircraft();
            if (cbType.SelectedIndex != -1)
                Addfrm.tbType.Text = cbType.SelectedItem.ToString();

            AircraftFactory aircraftFactory = createAircraftByType(cbType.SelectedItem.ToString());
            Aircraft aircraft = aircraftFactory.createAircraft();
            bool[] visibleTBs = { false, false, false, false };

            if (cbType.SelectedItem.ToString() == "Вертолет")
            {
                Addfrm.tbEngPwr.Visible = true;
                Addfrm.tbRotDiam.Visible = true;
                visibleTBs[2] = true;
                visibleTBs[3] = true;
            }
            if (cbType.SelectedItem.ToString() == "Аэроплан")
            {
                Addfrm.tbWingspan.Top = Addfrm.tbWingspan.Top - 37;
                Addfrm.tbWingspan.Visible = true;
                visibleTBs[1] = true;
            }
            if (cbType.SelectedItem.ToString() == "Самолет")
            {
                Addfrm.tbEngPwr.Visible = true;
                Addfrm.tbWingspan.Top = Addfrm.tbWingspan.Top - 37;
                Addfrm.tbWingspan.Visible = true;
                visibleTBs[1] = true;
                visibleTBs[2] = true;
            }
            if (cbType.SelectedItem.ToString() == "Планер")
            {
                Addfrm.tbLoadCap.Visible = true;
                Addfrm.tbWingspan.Visible = true;
                visibleTBs[0] = true;
                visibleTBs[1] = true;
            }

            DialogResult dlgRes = Addfrm.ShowDialog(this);
            if (dlgRes == DialogResult.Cancel)
            {
                return;
            }

            List<string> aircraftData = new List<string>();
            aircraftData.Add(Addfrm.tbName.Text);
            aircraftData.Add(Addfrm.tbTailNum.Text);
            aircraftData.Add(Addfrm.tbMaxSp.Text);
            aircraftData.Add(Addfrm.tbFlDist.Text);
            if (visibleTBs[0])
                aircraftData.Add(Addfrm.tbLoadCap.Text);
            if (visibleTBs[1])
                aircraftData.Add(Addfrm.tbWingspan.Text);
            if (visibleTBs[2])
                aircraftData.Add(Addfrm.tbEngPwr.Text);
            if (visibleTBs[3])
                aircraftData.Add(Addfrm.tbRotDiam.Text);

            aircraft.SetValues(aircraftData);
            db.Aircrafts.Add(aircraft);
            db.SaveChanges();
            cbType.SelectedIndex = -1;
            
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                int index = dgvAdmin.SelectedRows[0].Index;
                string Name = dgvAdmin[1, index].Value.ToString();

                Aircraft aircraft = db.Aircrafts
                    .Where(aircr => aircr.Name == Name)
                    .FirstOrDefault();

                db.Aircrafts.Remove(aircraft);
                db.SaveChanges();
                cbType.SelectedIndex = -1;
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

                bool[] visibleTBs = { false, false, false, false };
                if (cbType.SelectedItem.ToString() == "Вертолет")
                {
                    Editfrm.tbEngPwr.Visible = true;
                    Editfrm.tbRotDiam.Visible = true;
                    visibleTBs[2] = true;
                    visibleTBs[3] = true;
                }
                if (cbType.SelectedItem.ToString() == "Аэроплан")
                {
                    Editfrm.tbWingspan.Top = Editfrm.tbWingspan.Top - 37;
                    Editfrm.tbWingspan.Visible = true;
                    visibleTBs[1] = true;
                }
                if (cbType.SelectedItem.ToString() == "Самолет")
                {
                    Editfrm.tbEngPwr.Visible = true;
                    Editfrm.tbWingspan.Top = Editfrm.tbWingspan.Top - 37;
                    Editfrm.tbWingspan.Visible = true;
                    visibleTBs[1] = true;
                    visibleTBs[2] = true;
                }
                if (cbType.SelectedItem.ToString() == "Планер")
                {
                    Editfrm.tbLoadCap.Visible = true;
                    Editfrm.tbWingspan.Visible = true;
                    visibleTBs[0] = true;
                    visibleTBs[1] = true;
                }

                Aircraft aircraft = db.Aircrafts
                    .Where(aircr => aircr.Name == Name)
                    .FirstOrDefault();

                List<string> aircraftData = new List<string>();
                aircraftData = aircraft.GetValues();

                Editfrm.tbName.Text = aircraftData[0];
                Editfrm.tbTailNum.Text = aircraftData[1];
                Editfrm.tbMaxSp.Text = aircraftData[2];
                Editfrm.tbFlDist.Text = aircraftData[3];
                Editfrm.tbWingspan.Text = aircraftData[4];
                Editfrm.tbEngPwr.Text = aircraftData[5];
                Editfrm.tbRotDiam.Text = aircraftData[6];
                Editfrm.tbLoadCap.Text = aircraftData[7];

                DialogResult dlgRes = Editfrm.ShowDialog(this);
                if (dlgRes == DialogResult.Cancel)
                {
                    return;
                }

                aircraftData.Clear();
                aircraftData.Add(Editfrm.tbName.Text);
                aircraftData.Add(Editfrm.tbTailNum.Text);
                aircraftData.Add(Editfrm.tbMaxSp.Text);
                aircraftData.Add(Editfrm.tbFlDist.Text);
                if (visibleTBs[0])
                    aircraftData.Add(Editfrm.tbLoadCap.Text);
                if (visibleTBs[1])
                    aircraftData.Add(Editfrm.tbWingspan.Text);
                if (visibleTBs[2])
                    aircraftData.Add(Editfrm.tbEngPwr.Text);
                if (visibleTBs[3])
                    aircraftData.Add(Editfrm.tbRotDiam.Text);

                aircraft.SetValues(aircraftData);
                db.SaveChanges();
                cbType.SelectedIndex = -1;
            }
        }
        
        private void LoadHelicopters(DataGridView dgv)
        {
            Helicopter helicopter = new Helicopter();

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
            List<Airplane> Airplanes = db.Airplanes.ToList();
            List<Glider> Gliders = db.Gliders.ToList();
            List<Plane> Planes = db.Planes.ToList();

            foreach (Airplane airPln in Airplanes)
            {
                foreach (Glider gldr in Gliders)
                {
                    if (gldr.Name != airPln.Name)
                    {
                        foreach (Plane pln in Planes)
                        {
                            if (pln.Name != airPln.Name)
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
                    }
                }
                    
            }
        }

        private void LoadPlanes(DataGridView dgv)
        {
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

        private void LoadHeaders(DataGridView dgv, string aircraftType)
        {
            dgv.Columns.Add("Number", "№");
            dgv.Columns.Add("Name", "Название");
            dgv.Columns.Add("TailNumber", "Бортовой номер");
            dgv.Columns.Add("MaxSpeed", "Максимальная скорость, км/ч");
            dgv.Columns.Add("MaxFlightDistance", "Максимальная дистанция полета, км");
            if (aircraftType == "Вертолет")
            {
                dgv.Columns.Add("RotorDiameter", "Диаметр винта, м");
                dgv.Columns.Add("EnginePower", "Мощность двигателя, л.с.");
                LoadHelicopters(dgv);
                return;
            }
            if (aircraftType == "Аэроплан")
            {
                dgv.Columns.Add("RotorDiameter", "Диаметр винта, м");
                LoadAirplanes(dgv);
                return;
            }
            if (aircraftType == "Самолет")
            {
                dgv.Columns.Add("Wingspan", "Размах крыльев, м");
                dgv.Columns.Add("EnginePower", "Мощность двигателя, л.с.");
                LoadPlanes(dgv);
                return;
            }
            if (aircraftType == "Планер")
            {
                dgv.Columns.Add("Wingspan", "Размах крыльев, м");
                dgv.Columns.Add("LoadCapacity", "Грузоподъемность, кг");
                LoadGliders(dgv);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAdmin.Columns.Clear();
            if (cbType.SelectedIndex != -1)
                LoadHeaders(dgvAdmin, cbType.SelectedItem.ToString());
        }

        private void FillOrders(DataGridView dgv)
        {
            dgv.Columns.Add("Number", "№");
            dgv.Columns.Add("OnWhen", "Когда");
            dgv.Columns.Add("DurationOfFlight", "Длительность полёта");
            dgv.Columns.Add("NeedPilot", "Требуется пилот");
            dgv.Columns.Add("UserName", "Имя заказчика");
            dgv.Columns.Add("UserMail", "Почта заказчика");
            dgv.Columns.Add("AircraftName", "Название летательного аппарата");
            dgv.Columns.Add("AircraftTailNumber", "Бортовой номер летательного аппарата");
            dgv.Columns.Add("AircraftMaxSpeed", "Максимальная скорость летательного аппарата, км/ч");
            dgv.Columns.Add("AircraftMaxFlightDistance", "Максимальная дистанция полета летательного аппарата, км");

            List<Order> orders = db.Orders.Local.ToList();
            foreach (Order ord in orders)
            {
                dgv.Rows.Add();
                int row = dgv.RowCount - 1;
                dgv[0, row].Value = row + 1;
                dgv[1, row].Value = ord.OnWhen;
                dgv[2, row].Value = ord.DurationOfFlight;
                if (ord.NeedPilot)
                    dgv[3, row].Value = "Да";
                else
                    dgv[3, row].Value = "Нет";

                dgv[4, row].Value = ord.User.UserName;
                dgv[5, row].Value = ord.User.Profile.Mail;
                dgv[6, row].Value = ord.Aircraft.Name;
                dgv[7, row].Value = ord.Aircraft.TailNumber;
                dgv[8, row].Value = ord.Aircraft.MaxSpeed;
                dgv[9, row].Value = ord.Aircraft.MaxFlightDistance;
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            FillOrders(dgvOrders);
            
        }

        private void mSaveAs_Click(object sender, EventArgs e)
        {
            aircraft = new AircraftType { Aircrafts = db.Aircrafts.Local.ToList() };
            frmProcessFile serializeFrm = new frmProcessFile();
            if (serializeFrm.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog saveFile = InitializeSaveFile(serializeFrm.TypeSerialization.ToLower());
                if (saveFile.ShowDialog(this) == DialogResult.OK)
                {
                    if (serializeFrm.TypeSerialization.ToLower() == "txt")
                    {
                        SaveTXT(saveFile, aircraft);
                    }
                    else if (serializeFrm.TypeSerialization.ToLower() == "soap")
                    {
                        SaveSOAP(saveFile, aircraft.Aircrafts.ToArray());
                    }
                    else
                        SaveOpenFile<ISerilizable>(serializeFrm.TypeSerialization, true, saveFile, null, aircraft);
                }
            }

        }

        private AircraftType SaveOpenFile<T>(string someType, bool choice, SaveFileDialog saveFile, OpenFileDialog openFile, AircraftType aircraftType) where T : ISerilizable
        {

            string serializerLibName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                "SerializerLibrary.dll");
            if (!File.Exists(serializerLibName)) { MessageBox.Show("Файл библиотеки не найден."); return null; }

            try
            {
                Assembly serializerAssembly = Assembly.LoadFrom(serializerLibName);
                foreach (Type type in serializerAssembly.GetExportedTypes())
                {
                    if (type.IsClass && typeof(T).IsAssignableFrom(type) && (string.Equals(type.Name, someType, StringComparison.OrdinalIgnoreCase)))
                    {
                        var serializer = (T)Activator.CreateInstance(type);
                        if (choice)
                            serializer.Serialize(saveFile, aircraftType);
                        else
                            return serializer.Deserialize<AircraftType>(openFile, someType);
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("В процессе сериализации возникла ошибка.");
            }


            MessageBox.Show("Файл не содержит необходимой информации");
            return null;
        }

        private void mOpenFrom_Click(object sender, EventArgs e)
        {
            frmProcessFile serializeFrm = new frmProcessFile();
            if (serializeFrm.ShowDialog() == DialogResult.OK)
            {
                cbType.SelectedIndex = -1;
                OpenFileDialog openFile = InitializeOpenFile("zip");
                if (openFile.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        if (serializeFrm.TypeSerialization.ToLower() == "txt")
                        {
                            OpenTXT(openFile);
                        }
                        else if (serializeFrm.TypeSerialization.ToLower() == "soap")
                        {
                            aircraft.Aircrafts = OpenSOAP(openFile).ToList();
                        }
                        else
                        {
                            aircraft = SaveOpenFile<ISerilizable>(serializeFrm.TypeSerialization, false, null, openFile, null);          
                        }
                        db.Aircrafts.RemoveRange(db.Aircrafts);
                        db.Aircrafts.AddRange(aircraft.Aircrafts);
                        db.SaveChanges();

                    }
                    catch (Exception)
                    {
                        aircraft = new AircraftType() { Aircrafts = new List<Aircraft>() };
                    }
                }
            }
        }

        private void SaveSOAP(SaveFileDialog saveFile, Aircraft[] aircrafts)
        {
            using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Create))
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(fs, aircrafts);
            }

            string encrFile = Path.GetFileNameWithoutExtension(saveFile.FileName);
            encrFile = Regex.Replace(saveFile.FileName, encrFile, encrFile + "_encr");

            Encrypt.EncryptFile(saveFile.FileName, encrFile);

            Archive.SaveArchive(encrFile, encrFile, "soap");
        }

        private Aircraft[] OpenSOAP(OpenFileDialog archive)
        {
            Archive.Unarchive(archive, "soap");

            string encrFile = Regex.Replace(archive.FileName, "zip", "soap");
            string decrFile = Regex.Replace(encrFile, "_encr", "_decr");
            Encrypt.DecryptFile(encrFile, decrFile);

            OpenFileDialog openFile = InitializeOpenFile("soap");

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openFile.FileName, FileMode.Open))
                {
                    SoapFormatter formatter = new SoapFormatter();
                    try
                    {
                        return (Aircraft[])formatter.Deserialize(fs); ;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        private void SaveTXT(SaveFileDialog saveFile, AircraftType aircraftType)
        {
            using (var sw = new StreamWriter(saveFile.FileName, false, Encoding.Default))
            {
                if (aircraftType?.Aircrafts != null)
                    foreach (var aircraft in aircraftType.Aircrafts)
                    {
                        sw.WriteLine($"{aircraft.GetType().Name} {aircraft.Name} {aircraft.TailNumber}" +
                                     $" {aircraft.MaxSpeed} {aircraft.MaxFlightDistance}");
                    }
            }  
        }

        private AircraftType OpenTXT(OpenFileDialog openFile)
        {
            var aircrafts = new AircraftType() { Aircrafts = new List<Aircraft>() };
            
 
                if (openFile.ShowDialog(this) == DialogResult.OK)
                {

                    using (var fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (var sr = new StreamReader(fs, Encoding.Default))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                aircrafts.Aircrafts.Add(ParserTXT(line));
                            }
                        }
                    }

                }
            

            return aircrafts;
        }

        private Aircraft[] InitializeArrayFigure() => new Aircraft[] { new Helicopter(), new Airplane(), new Plane(), new Glider() };
        private Aircraft ParserTXT(string line)
        {
            string[] data = line.Split(new char[] { ' ' });
            aircraftsType = InitializeArrayFigure();
            byte tag = FindTypeAircraft(data[0]);
            var aircrft = aircraftsType[tag];
            aircrft.Name = data[1];
            aircrft.TailNumber = data[2];
            aircrft.MaxSpeed = int.Parse(data[3]);
            aircrft.MaxFlightDistance = int.Parse(data[4]);
            
            
            return aircrft;
        }
        private byte FindTypeAircraft(string type)
        {
            byte i = 0;
            for (; i < aircraftsType.Length; i++)
                if (aircraftsType[i].GetType().Name == type)
                    break;
            return i;
        }
    }
}
