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
    public partial class Parentform : Form
    {
        public Parentform()
        {
            InitializeComponent();
        }

        private void JamcheckMenu_Click(object sender, EventArgs e)
        {
            CustomsLoginFrm customslogin = new CustomsLoginFrm();
            customslogin.MdiParent = this;
            customslogin.Dock = DockStyle.Fill;
            customslogin.Show();
            ParentDisplayWindow.Hide();

            
        }

        private void CustomsMenu_Click(object sender, EventArgs e)
        {
            FrmTest frmTest = new FrmTest();
            frmTest.MdiParent = this;
            frmTest.Show();
            ParentDisplayWindow.Hide();
        }
    }
}
