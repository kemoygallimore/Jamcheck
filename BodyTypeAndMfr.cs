using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Jamcheck
{
    

    public partial class BodyTypeAndMfr : Form
    {
        protected readonly jampracticeEntities jamdb = new jampracticeEntities();

        public BodyTypeAndMfr()
        {
            InitializeComponent();
        }
        private void AddDetails(string str)
        {
            
        }

        TextInfo upper = new CultureInfo("en-US", false).TextInfo;

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(btnSwitch.Text=="Make")
            {
                lblText.Text = "Make";
                lblTitle.Text = "Add Manufacturer";
                btnSwitch.Text = "Body Type";
            }
            else
            //if (btnSwitch.Text == "Body Type")
            {
                lblText.Text = "Vehicle Type";
                lblTitle.Text = "Add Body Type";
                btnSwitch.Text = "Make";
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var details = (txtbxEntry.Text.Trim().ToLower() == "bmw") ? "BMW" : (txtbxEntry.Text.Trim().ToLower() == "suv")?"SUV": upper.ToTitleCase(txtbxEntry.Text);
            bool allletters = details.All(char.IsLetter);
            bool anyletters = details.Any(char.IsLetter);
            bool dashincluded = details.Contains('-');
            bool valid = false;
            string Error = "Please remove any numbers or special characters used except a dash(-)";


            if (!details.Any(char.IsDigit))
            {
                if (details.Any(char.IsLetter) && dashincluded)
                {
                    valid = true;
                }
                else //(details.Any(char.IsLetter) && !dashincluded)
                {
                    if (allletters)
                        valid = true;
                    
                    else
                        MessageBox.Show(Error);
                }
            }
            else
                MessageBox.Show(Error);
            

            if(valid)
            {
                if (lblTitle.Text == "Add Body Type")
                {
                    VehicleType vehicleType = new VehicleType();
                    vehicleType.Name = details;
                    jamdb.VehicleTypes.Add(vehicleType);
                    jamdb.SaveChanges();
                }
                else
                {
                    Make make = new Make();
                    make.Name = details;
                    jamdb.Makes.Add(make);
                    jamdb.SaveChanges();
                }
                MessageBox.Show($"{details} was added successfully");
                txtbxEntry.Clear();
                txtbxEntry.Focus();
            }

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtbxEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
