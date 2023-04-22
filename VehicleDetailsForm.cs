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

        public VehicleDetailsForm(ViewVehicles vehicle, LoginUserRole userRole)
        {
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
            var pic = vehicle.Picture;
            MemoryStream ms = new MemoryStream(pic);
            DisplayPicture.Image = Image.FromStream(ms);

            if (userRole.roletype != "Admin")
            {
                filenametxtbx.Visible = false;
                Downloadbtn.Visible = false;
                Uploadbtn.Visible = false;
            }
            if (vehicle.Report == null)
                Downloadbtn.Visible = false;
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            //Converts the id value to an int and store into a variable
            var id = VINtxtbx.Text;
            //query the database for the first id that matches the id variable declared above
            var editcar = jamdb.Vehicles.FirstOrDefault(a=>a.VinNum == id);

            //accepts the new details into the database cells that matches the query above
            editcar.Model= modeltxtbx.Text;

            //This checks if the admin had uploaded a report file and the name is in the textbox control
            if(filenametxtbx.Text.Trim()!="")
            {
                //converts the file into a byte array
                using (Stream files = File.OpenRead(filenametxtbx.Text))
                {
                    byte[] data = new byte[files.Length];
                    files.Read(data, 0, data.Length);
                    string extn = Path.GetExtension(filenametxtbx.Text).ToLower();
                    string filename = Path.GetFileName(filenametxtbx.Text);
                    editcar.Report = data;
                    editcar.Report_Name = filename;
                    editcar.Report_Ext = extn;
                }
            }
            jamdb.SaveChanges();
            MessageBox.Show("Records have been updated");
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
            try
            {

                var id = (VINtxtbx.Text);
                var vehicle = jamdb.Vehicles.FirstOrDefault(a => a.VinNum == id);
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

                        //this allows the user to be able to download the report that was attached to this entry
                        Downloadnotifyicon.Text = $"Report for {maketxtbx.Text} {modeltxtbx.Text} been downloaded onto your computer";
                        Downloadnotifyicon.BalloonTipText = "Your download has been completed";
                        Downloadnotifyicon.BalloonTipTitle = "Download Complete";
                        Downloadnotifyicon.Icon = SystemIcons.Application;
                        Downloadnotifyicon.ShowBalloonTip(1000);
                        Downloadnotifyicon.BalloonTipIcon = ToolTipIcon.None;
                    }
                }
                else
                    MessageBox.Show("There is no file linked to this vehicle.\nClose this popup and click the upload button to add a car report");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.Source);                
            }
        }

        private bool ShowDownloadButton()
        {
            var id = Convert.ToInt32(IDlbl.Text);
            var v = jamdb.Vehicles.FirstOrDefault(a => a.id == id);
            return v.Report == null;
        }

        private void VehicleDetailsForm_Load(object sender, EventArgs e)
        {            
            if (!ShowDownloadButton())
                Downloadbtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Downloadnotifyicon.Text = $"Report for {maketxtbx.Text} {modeltxtbx.Text} been downloaded onto your computer";
            Downloadnotifyicon.BalloonTipText = "Your download has been completed";
            Downloadnotifyicon.BalloonTipTitle = "Download Complete";
            Downloadnotifyicon.Icon = SystemIcons.Application;
            Downloadnotifyicon.ShowBalloonTip(1000);
            Downloadnotifyicon.BalloonTipIcon = ToolTipIcon.None;
        }
    }
}
