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
    public partial class JamCheck : Form
    {
        public JamCheck()
        {
            InitializeComponent();
        }

        private void JamCheck_Load(object sender, EventArgs e)
        {
            FrmJamcheckLogin frmJamcheckLogin = new FrmJamcheckLogin();
            frmJamcheckLogin.MdiParent = this;
            frmJamcheckLogin.Show();

            FrmAddVehicle addVehicle = new FrmAddVehicle();
            addVehicle.MdiParent = this;
        }
    }
}
