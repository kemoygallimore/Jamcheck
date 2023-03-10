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
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = Properties.Resources.Jamcheck_logo_transparent;
        }

        private void JamcheckMenu_Click(object sender, EventArgs e)
        {
            CustomsLoginFrm customslogin = new CustomsLoginFrm();
            customslogin.MdiParent = this;
            customslogin.Dock = DockStyle.Fill;
            customslogin.Show();                      
        }

        private void CustomsMenu_Click(object sender, EventArgs e)
        {
            FrmTest frmTest = new FrmTest();
            frmTest.MdiParent = this;
            frmTest.Show();
        }

        private void addVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddVehicle addVehicle = new FrmAddVehicle();
            addVehicle.MdiParent = this;            
            addVehicle.Dock = DockStyle.Fill;
            addVehicle.Show();
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingsMain recentlistings = new ListingsMain();
            recentlistings.MdiParent = this;
            recentlistings.Dock = DockStyle.Fill;
            recentlistings.Show();
        }

        private void allVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListingsMainAll listingsAll = new ListingsMainAll();
            listingsAll.MdiParent = this;
            listingsAll.Dock = DockStyle.Fill;
            listingsAll.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarDealership carDealership = new CarDealership();
            carDealership.MdiParent = this;
            carDealership.Dock = DockStyle.Fill;
            carDealership.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
