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
    public partial class StaffLoginFrm : Form
    {
        public StaffLoginFrm()
        {
            InitializeComponent();
        }

        private void txtBxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxStfPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStfLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffExit_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString();
            LblDate.Text = DateTime.Now.ToString();
        }

        
    }
}
