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
        private readonly JamCheckDB jamCheckDB;
        public FrmJamcheckLogin()
        {
            InitializeComponent();
            jamCheckDB = new JamCheckDB();
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
            var username = txtbxUsername.Text;
            var password = txtbxPassword.Text;


            var user = jamCheckDB.CustomStaffs.FirstOrDefault(a => a.name == username && a.password == password);
            FrmAddVehicle addVehicle = new FrmAddVehicle();
            addVehicle.MdiParent = this.MdiParent;
            addVehicle.Dock = DockStyle.Fill;
            addVehicle.Show();
            this.Hide();

            /*if(user!=null)
            {
                FrmAddVehicle addVehicle = new FrmAddVehicle();
                addVehicle.MdiParent = this.MdiParent;
                addVehicle.Dock = DockStyle.Fill;
                addVehicle.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You have entered an incorrect username/password");
                txtbxUsername.Clear();
                txtbxPassword.Clear();
            }*/


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmJamcheckLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmJamcheckLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parentform parentform = new Parentform();
            parentform.Show();
        }
    }
}
