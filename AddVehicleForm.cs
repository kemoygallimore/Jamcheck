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

namespace Jamcheck
{
    public partial class FrmAddVehicle : Form
    {
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
                pictureBox1.ImageLocation = openFile.FileName.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            var make = cobxMake.SelectedValue;
            var model = txtbxModel.Text;
            var year = numYear.Value;
            var Fuel = (rtbnPetrol.Checked) ? "Petrol" : (rbtnDiesel.Checked) ? "Diesel" : (rbtnElectric.Checked) ? "Electric" : "Hybrid";
            var Chassis = txtbxChassisNo.Text;
            var VIN = txtbxVIN.Text;
            var mileage = numMileage;
            var Seating = numSeating;
            var Steering = (rbtnLHand.Checked) ? "Left Hand" : "Right Hand";
            var bodytype = cobxVehicleType.SelectedValue;
            var trans = (rbtnAuto.Checked) ? 1 : (rbtnManual.Checked) ? 2 : 3;
            var Source = cobxImporter.SelectedValue;
            var importer = txtbxImportFrom.Text;
            var pic = pictureBox1.ImageLocation;




        }
    }
}
