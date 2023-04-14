using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public VehicleDetailsForm(ViewVehicle vehicle)
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
            var pic = vehicle.Picture;
            MemoryStream ms = new MemoryStream(pic);
            DisplayPicture.Image = Image.FromStream(ms);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
