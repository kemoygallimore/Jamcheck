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
    public partial class LoginForm : Form
    {
        private readonly jampracticeEntities jamCheckDB = new jampracticeEntities();

        
        public LoginForm()
        {
            InitializeComponent();           
        }
        private void ClearStatus()
        {

            LoginSSlbl.Text = "";
            LoginSSlbl.BackColor = Color.White;
            LoginStatusStrip.BackColor = Color.White;
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
            bool containsIntegers = false;
            foreach (char c in txtbxUsername.Text)
            {
                if (Char.IsDigit(c))
                {
                    containsIntegers = true;
                    break;
                }
            }
            if (containsIntegers)
            {
                usernamevallbl.Visible = true;
            }
            else
            {
                usernamevallbl.Visible = false;
            }
        }     

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var username = txtbxUsername.Text;
            var password = txtbxPassword.Text;

            var user = jamCheckDB.UserInfoes.FirstOrDefault(a => a.Username == username && a.Password == password);
            
            if (user != null)
            {
                MessageBox.Show("You have been logged in successfully");
                LoginUserRole userRole = new LoginUserRole();
                userRole.roletype = user.Role;
                Parentform parentform = new Parentform(userRole);
                
                this.Hide();
                parentform.ShowDialog();
                this.Close();
                

                //var id = jamCheckDB.users.FirstOrDefault(a=>a.id)
            }
            else
            {
                MessageBox.Show("You have entered an incorrect username/password");
                txtbxUsername.Clear();
                txtbxPassword.Clear();
            }
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
                seepassword.BackColor = Color.Green;
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

        private void txtbxUsername_MouseHover(object sender, EventArgs e)
        {
            LoginSSlbl.Text = "ENTER YOUR USERNAME GIVEN BY ADMIN";
            LoginSSlbl.BackColor = Color.LimeGreen;
            LoginStatusStrip.BackColor = Color.LimeGreen;

        }

        private void txtbxUsername_MouseLeave(object sender, EventArgs e)
        {
            ClearStatus();
        }

        private void txtbxPassword_MouseHover(object sender, EventArgs e)
        {
            LoginSSlbl.Text = "ENTER YOUR PASSWORD!!";
            LoginSSlbl.BackColor = Color.LimeGreen;
            LoginStatusStrip.BackColor = Color.LimeGreen;

        }

        private void txtbxPassword_MouseLeave(object sender, EventArgs e)
        {
            ClearStatus();
        }
    }
}
