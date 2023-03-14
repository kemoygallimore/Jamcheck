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
        Parentform Parent;
        SqlConnection sql = new SqlConnection(@"data source=.\sqlexpress; initial catalog=JamCheckDB; integrated security = true");
        SqlCommand add;
        public FrmAddVehicle()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            /*sql.Open();
            add = new SqlCommand($"insert into UsedCars(year, Makeid, model, bodytypeid, chassisnum, transnum, transtypeid, mileage, dealerid)" +
                $"values({numYear.Value}, {cobxMake.SelectedIndex),");*/
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Make = cobxMake.SelectedItem;
            var Model = txtbxModel.Text;
            var year = numYear.Value;
            var SeatAmt = numSeating.Value;
            var ChassisNum = txtbxChassisNo.Text;
            var ModelNum = txtbxModelNo.Text;
            var Importer = cobxImporter.SelectedItem;
            var VehicleType = cobxVehicleType.SelectedItem;
            var Automatic = rbtnAuto.Checked;
            var Manual = rbtnManual.Checked;
            var CVT = rbtnCVT.Checked;
            var Transmission = ((Automatic) ? "Automatic" : (Manual)?"Manual": "CVT");
            var Drive = (rbtnLHand.Checked) ? "Left Hand" : "Right Hand";
            var Fuel = (rbtnPetrol.Checked?"Petrol":(rbtnDiesel.Checked)?"Diesel":(rbtnElectric.Checked)?"Electric":"Hybrid");
            
            MessageBox.Show($"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Year: {year}\n" +
                $"Vehicle Type: {VehicleType}\n" +
                $"Transmission: {Transmission}\n" +
                $"Fuel: {Fuel}");
            
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

        private void txtbxChassisNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxModelNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cobxImporter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnManual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbxImportFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateImported_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbtnLHand_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnRHand_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numMileage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbtnDiesel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnElectric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCVT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnPetrol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnHybrid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog()==DialogResult.OK)
            {
              pictureBox1.ImageLocation = openFile.FileName.ToString();
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
