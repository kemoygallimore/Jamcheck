using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamcheck
{
    public partial class BodyTypeAndMfr : Form
    {
        public BodyTypeAndMfr()
        {
            InitializeComponent();
        }

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
