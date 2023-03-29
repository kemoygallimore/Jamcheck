using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Jamcheck
{
    
    public partial class FrmAddVehicle : Form
    {
        private void cleartextboxes()
        {
            txtbxChassisNo.Clear();
            txtbxImportFrom.Clear();
            txtbxModel.Clear();
            txtbxVIN.Clear();
            numMileage.Value = 0;
            numSeating.Value = 0;
            numYear.Value = 0;
            pictureBox1.Image = null;
            RadioButton radioButton = new RadioButton();
            radioButton.Checked = false;
        }
        jampracticeEntities jamdb;
        public FrmAddVehicle()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
        }
        private void FrmAddVehicle_Load(object sender, EventArgs e)
        {

            var make = jamdb.Makes.ToList();
            cobxMake.DisplayMember = "Name";
            cobxMake.ValueMember = "id";
            cobxMake.DataSource = make;

            var type = jamdb.VehicleTypes.ToList();
            cobxVehicleType.DisplayMember = "name";
            cobxVehicleType.ValueMember = "id";
            cobxVehicleType.DataSource = type;

            var import = jamdb.ImportFroms.ToList();
            cobxImporter.DisplayMember = "name";
            cobxImporter.ValueMember = "id";
            cobxImporter.DataSource = import;
        }

        private void txtbxChassisNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cobxImporter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxImportFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void numMileage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cobxMake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numSeating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtnAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnManual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCVT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtbxVIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap( openFile.FileName);
                
                //pictureBox1.ImageLocation = openFile.FileName.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            var make = Convert.ToInt32( cobxMake.SelectedValue);
            var model = txtbxModel.Text;
            var year = Convert.ToInt32(numYear.Value);
            var Fuel = (rtbnPetrol.Checked) ? "Petrol" : (rbtnDiesel.Checked) ? "Diesel" : (rbtnElectric.Checked) ? "Electric" : "Hybrid";
            var FuelID = (rtbnPetrol.Checked) ? 2 : (rbtnDiesel.Checked) ? 3 : (rbtnElectric.Checked) ? 4 : 5;
            var Chassis = txtbxChassisNo.Text;
            var VIN = txtbxVIN.Text;
            var mileage = Convert.ToInt32( numMileage.Value);
            var Seating = Convert.ToInt32(numSeating.Value);
            var Steering = (rbtnLHand.Checked) ? "Left Hand" : "Right Hand";
            var Steeringid = (rbtnLHand.Checked) ? 1 : 2;
            var bodytype = Convert.ToInt32( cobxVehicleType.SelectedValue);
            var trans = (rbtnAuto.Checked) ? 2 : (rbtnManual.Checked) ? 3 : 4;
            var Source = Convert.ToInt32(cobxImporter.SelectedValue);
            var importer = txtbxImportFrom.Text;
            var importdate = dateTimePicker1.Value;
            //var pic = Convert.ToByte( pictureBox1.Image);
            
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                vehicle.Picture = ms.ToArray();
            }

            //var imageData = ImageToByteArray(pictureBox1.Image);
            vehicle.makeid = make;
            vehicle.Model = model;
            vehicle.year = year;
            vehicle.fuelid = FuelID;
            vehicle.ChassisNo = Chassis;
            vehicle.VinNum = VIN;
            vehicle.Mileage = mileage;
            vehicle.Seating = Seating;
            vehicle.steeringid = Steeringid;
            vehicle.bodytypeid = bodytype;
            vehicle.transmissionid = trans;
            vehicle.ImportfromID = Source;
            vehicle.Importer = importer;
            vehicle.ImportDate = importdate;
            

            jamdb.Vehicles.Add(vehicle);
            jamdb.SaveChanges();
            MessageBox.Show("Entry has been added");
            cleartextboxes();
            txtbxModel.Focus();


        }
    }
}
