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
using System.Net.WebSockets;

namespace Jamcheck
{
    
    public partial class FrmAddVehicle : Form
    {
        //Create a function that will clear all the fields when it has been called
        private void cleartextboxes()
        {
            txtbxChassisNo.Clear();
            txtbxImportFrom.Clear();
            txtbxModel.Clear();
            txtbxVIN.Clear();
            numMileage.Value = 0;
            numSeating.Value = 0;
            numYear.Value = 2000;
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
            //It checks the database for the Make table and store the values in a list
            var make = jamdb.Make.ToList();
            //it looks in the Name column and displays the names
            cobxMake.DisplayMember = "Name";
            //Assigns each o the display name to an ID
            cobxMake.ValueMember = "id";
            //This calls the SQL command as the datasource for the dropdown
            cobxMake.DataSource = make;

            var type = jamdb.VehicleType.ToList();
            cobxVehicleType.DisplayMember = "name";
            cobxVehicleType.ValueMember = "id";
            cobxVehicleType.DataSource = type;

            var import = jamdb.ImportFrom.ToList();
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
        private int fueltype()
        {
            int result = (rtbnPetrol.Checked) ? 2 : (rbtnDiesel.Checked) ? 3 : (rbtnElectric.Checked) ? 4 : 5;
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // creates an object for the vehicle table
                Vehicles vehicle = new Vehicles();                
                using (MemoryStream ms = new MemoryStream())
                {
                    //save the image from the picture box to a bmp format through the memory stream object ms
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    vehicle.Picture = ms.ToArray();
                }
                //store the values of the textboxes to columns in the created object
                vehicle.makeid = Convert.ToInt32(cobxMake.SelectedValue); 
                vehicle.Model = txtbxModel.Text;
                vehicle.year = Convert.ToInt32(numYear.Value);
                vehicle.fuelid = fueltype();
                vehicle.ChassisNo = txtbxChassisNo.Text.ToUpper();
                vehicle.VinNum = txtbxVIN.Text.ToUpper();
                vehicle.Mileage = Convert.ToInt32(numMileage.Value);
                vehicle.Seating = Convert.ToInt32(numSeating.Value); ;
                vehicle.steeringid = (rbtnLHand.Checked) ? 1 : 2;
                vehicle.bodytypeid = Convert.ToInt32(cobxVehicleType.SelectedValue); ;
                vehicle.transmissionid = (rbtnAuto.Checked) ? 2 : (rbtnManual.Checked) ? 3 : 4; ;
                vehicle.ImportfromID = Convert.ToInt32(cobxImporter.SelectedValue);
                vehicle.Importer = txtbxImportFrom.Text;
                vehicle.ImportDate = dateTimePicker1.Value;

                //Add the properties of the objects to the Vehicles table of the database
                jamdb.Vehicles.Add(vehicle);
                //save the changes that were made
                jamdb.SaveChanges();
                MessageBox.Show("Entry has been added");
                //calls the fuction that clear all the textboxes
                cleartextboxes();
                txtbxModel.Focus();
            }
            catch (Exception errors){MessageBox.Show(errors.Message+ "/n/n"+ errors.Source);}
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }
    }
}
