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

        private void CheckMDIChild()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }



        public Parentform()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = Properties.Resources.Jamcheck_logo_transparent;
        }
        public Parentform(LoginUserRole useraccess)
        {
            jampracticeEntities jamdb = new jampracticeEntities();
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = Properties.Resources.Jamcheck_logo_transparent;
            useridlbl.Visible = false;

            useridlbl.Text = useraccess.roletype;
            var role = useridlbl.Text;
            var userauth = jamdb.UserInfoes.FirstOrDefault(a=>a.Role == role);

            if (role == "Admin")
            {
                addVehiclesToolStripMenuItem.Visible = false;                
            }
            else
            {
                recentToolStripMenuItem.Visible = false;
                dealerToolStripMenuItem.Visible = false;
                manufacturerAndBodytypeToolStripMenuItem.Visible = false;
                CustomerProfileStripMenuItem.Visible = false;
                manageUsersToolStripMenuItem.Visible = false;
            }

        }

        private void addVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMDIChild();
            FrmAddVehicle addVehicle = new FrmAddVehicle();
            addVehicle.MdiParent = this;            
            addVehicle.Dock = DockStyle.Fill;
            addVehicle.Show();
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMDIChild();
            LoginUserRole userRole = new LoginUserRole();
            userRole.roletype=useridlbl.Text;
            ListingsMain recentlistings = new ListingsMain(userRole);
            recentlistings.MdiParent = this;
            recentlistings.Dock = DockStyle.Fill;
            recentlistings.Show();
        }

        private void allVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMDIChild();
            ListingsMainAll listingsAll = new ListingsMainAll();
            listingsAll.MdiParent = this;
            listingsAll.Dock = DockStyle.Fill;
            listingsAll.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMDIChild();
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.MdiParent = this;
            manageUsers.Dock = DockStyle.Fill;
            manageUsers.Show();
        }

        private void manufacturerAndBodytypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMDIChild();
            BodyTypeAndMfr bodyTypeAndMfr = new BodyTypeAndMfr();
            bodyTypeAndMfr.MdiParent = this;
            bodyTypeAndMfr.Dock = DockStyle.Fill;
            bodyTypeAndMfr.Show();
        }

        private void dealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMDIChild();
            CarDealership carDealership = new CarDealership();
            carDealership.MdiParent = this;
            carDealership.Dock = DockStyle.Fill;
            carDealership.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerProfileStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMDIChild();
            requestsubmissions submissions = new requestsubmissions();
            submissions.MdiParent = this;
            submissions.Dock = DockStyle.Fill;
            submissions.Show();
        }
    }
}
