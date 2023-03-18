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

        private void txtBxStfUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxStfPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStfLogin_Click(object sender, EventArgs e)
        {
            var username = txtBxStfUserName.Text;
            var password = txtBxStfPassword.Text;

            try
            {
                if (username == "admin" && password == "Password1")
                {
                    MessageBox.Show("You have been logged in successfully");
                    Parentform parentform = new Parentform();
                    parentform.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your email address or password is incorrect");
                    txtBxStfPassword.Clear();
                    txtBxStfUserName.Clear();
                    txtBxStfUserName.Focus();
                }
            }
            catch (Exception login)
            {

                MessageBox.Show("Access denied");
            }
        }

        private void btnStaffExit_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString();
            LblDate.Text = DateTime.Now.ToString();
        }

        private void seepassword_Click(object sender, EventArgs e)
        {
            if(seepassword.BackColor == Color.DimGray)
            {
                txtBxStfPassword.PasswordChar = 'v';
                seepassword.BackColor = Color.AliceBlue;
            }
            else
            {
                txtBxStfPassword.PasswordChar = '*';
            }
        }
    }
}
