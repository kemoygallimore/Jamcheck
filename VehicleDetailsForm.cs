using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamcheck
{
    public partial class VehicleDetailsForm : Form
    {
        private readonly jampracticeEntities jamdb = new jampracticeEntities();

        public VehicleDetailsForm()
        {
            InitializeComponent();
        }
        public VehicleDetailsForm(ViewVehicles vehicle)
        {
            // maketxtbx.Text = listings.

            InitializeComponent();
            maketxtbx.Text = vehicle.Make;
            modeltxtbx.Text = vehicle.Model;
            transtxtbx.Text = vehicle.Transmission;
            Bodytypetxtbx.Text = vehicle.BodyType;
            fueltypetxtbx.Text = vehicle.Fuel;
            Mileagetxtbx.Text = vehicle.Mileage.ToString();
            steeringtxtbx.Text = vehicle.Steering;
            yeartxtbx.Text = vehicle.year.ToString();
            VINtxtbx.Text = vehicle.VIN;
            IDlbl.Text = vehicle.id.ToString();

            

            var pic = vehicle.Picture;
            MemoryStream ms = new MemoryStream(pic);
            DisplayPicture.Image = Image.FromStream(ms);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            var id = int.Parse(IDlbl.Text);
            
            var editcar = jamdb.Vehicles.FirstOrDefault(a=>a.id == id);

            editcar.Model= modeltxtbx.Text;
            using(Stream files = File.OpenRead(filenametxtbx.Text))
            {
                byte[] data = new byte[files.Length];
                files.Read(data,0, data.Length);
                string extn = Path.GetExtension(filenametxtbx.Text).ToLower();
                string filename = Path.GetFileName(filenametxtbx.Text);
                editcar.Report = data;
                editcar.Report_Name = filename;
                editcar.Report_Ext = extn;
            }

            jamdb.SaveChanges();
            MessageBox.Show("Records have been updated");

            //Reopens the listing module
            ListingsMain main = new ListingsMain();
            main.MdiParent = this.MdiParent;
            main.Dock = DockStyle.Fill;
            this.Hide();
            main.ShowDialog();
            this.Close();

        }
        //this methods will upload the document from the computer
        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            filenametxtbx.Text = open.FileName;
        }

        //This functions will open the pdf file attached
        private void Openbtn_Click(object sender, EventArgs e)
        {
            var id = int.Parse(IDlbl.Text);
            var vehicle = jamdb.Vehicles.FirstOrDefault(a => a.id == id);
            if (vehicle != null)
            {
                // Get the file data as a byte array
                byte[] fileData = vehicle.Report;

                // Prompt the user to save the file
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                saveFileDialog1.FileName = vehicle.Report_Name;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Save the file to the user's computer
                    File.WriteAllBytes(saveFileDialog1.FileName, fileData);

                    // Open the file using the default program associated with its file type
                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);
                }
                
            }
            else
                MessageBox.Show("There is no file linked to this vehicle.\nClose this popup and click the upload button to add a car report");

        }
    }
}
