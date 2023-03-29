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

        //This method is used to between The form titles
        private void SwitchFormConditions()
        {
            if (btnSwitch.Text == "Make")
            {
                lblText.Text = "Make";
                lblTitle.Text = "Add Manufacturer";
                btnSwitch.Text = "Body Type";
            }
            else
            {
                lblText.Text = "Vehicle Type";
                lblTitle.Text = "Add Body Type";
                btnSwitch.Text = "Make";
            }
        }

        //
        public string Details()
        {
            //BMW and SUV are names that should be All Caps as they are acronyms but if the vehicle type of manufactured eneter is neither then 
            //then each word in the name will be capitalized
            var details = (txtbxEntry.Text.Trim().ToLower() == "bmw") ? "BMW" : (txtbxEntry.Text.Trim().ToLower() == "suv") ? "SUV" : upper.ToTitleCase(txtbxEntry.Text);

            return details;
        }
        //this functions checks if the text entry is valid
        private bool validentry()
        {
            
            //declaring and initializing boolean variables that will be used later on
            bool allletters = Details().All(char.IsLetter);
            bool anyletters = Details().Any(char.IsLetter);
            bool dashincluded = Details().Contains('-');
            bool valid = false;
            string Error = "Please remove any numbers or special characters used except a dash(-)";

            //This conditional statement will check if details has any digit in the string
            if (!Details().Any(char.IsDigit))
            {
                // if true this condition will check if details has any letters AND a hyhen
                if (Details().Any(char.IsLetter) && dashincluded)
                {
                    valid = true;
                }
                else //(details.Any(char.IsLetter) && !dashincluded)
                {
                    //This condition will check if details has ONLY letters
                    if (allletters)
                        valid = true;

                    else
                        MessageBox.Show(Error);
                }
            }
            else
                MessageBox.Show(Error);

            return valid;
        }

        //this method will add the entry to the database based on condition
        private void add(bool valid)
        {
            if (valid)
            {
                if (lblTitle.Text == "Add Body Type")
                {
                    VehicleType vehicleType = new VehicleType();
                    vehicleType.Name = Details();
                    jamdb.VehicleTypes.Add(vehicleType);
                    jamdb.SaveChanges();
                }
                else
                {
                    Make make = new Make();
                    make.Name = Details();
                    jamdb.Makes.Add(make);
                    jamdb.SaveChanges();
                }
                MessageBox.Show($"{Details()} was added successfully");
                txtbxEntry.Clear();
                txtbxEntry.Focus();
            }
        }
       
        TextInfo upper = new CultureInfo("en-US", false).TextInfo;

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            SwitchFormConditions();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validentry();

            add(validentry());
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
