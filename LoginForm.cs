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
    public partial class CustomsLoginFrm : Form
    {
        
        public CustomsLoginFrm()
        {
            InitializeComponent();
           
        }

        private void FrmJamcheckLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parentform parentform = new Parentform();
            parentform.Show();
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

            try
            {
                if (username == "Admin" && password == "Password1")
                {
                    MessageBox.Show("You have been logged in successfully");
                    Parentform parentform = new Parentform();
                    this.Hide();
                    parentform.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your email address or password is incorrect");
                    txtbxPassword.Clear();
                    txtbxUsername.Clear();
                    txtbxUsername.Focus();
                }
            }
            catch (Exception login)
            {

                 MessageBox.Show(login.Message + login.Source);
            }


            /*var user = jamCheckDB.CustomStaffs.FirstOrDefault(a => a.name == username && a.password == password);
            FrmAddVehicle addVehicle = new FrmAddVehicle();
            addVehicle.MdiParent = this.MdiParent;
            addVehicle.Dock = DockStyle.Fill;
            addVehicle.Show();
            this.Hide();*/

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
            this.Close();
        }

        private void seepassword_Click(object sender, EventArgs e)
        {
            if (seepassword.BackColor == Color.DimGray)
            {
                txtbxPassword.UseSystemPasswordChar = false;
                seepassword.BackColor = Color.AliceBlue;
            }
            else
            {
                txtbxPassword.UseSystemPasswordChar = true;
                seepassword.BackColor = Color.DimGray;

            }
        }

        private void CustomsLoginFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
