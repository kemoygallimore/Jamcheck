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
    public partial class FrmJamcheckLogin : Form
    {
        public FrmJamcheckLogin()
        {
            InitializeComponent();
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //JamCheck main = new JamCheck();

            
            FrmAddVehicle addVehicle = new FrmAddVehicle();
            addVehicle.MdiParent = this.MdiParent;

            addVehicle.Show();
            this.Hide();
            

            // just trying to commit


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
