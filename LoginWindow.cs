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
        
        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
            bool containsIntegers = false;
            //This will loop through the textbox to check each character
            foreach (char c in txtbxUsername.Text)
            {
                //checks if the char value stored in 'c' is a digit
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
            try
            {
                var username = txtbxUsername.Text;
                var password = txtbxPassword.Text;
                //Checks userinfoes table for the username and password and check if it is equal to the variables above and store that entry into a variable
                var user = jamCheckDB.UserInfoes.FirstOrDefault(a => a.Username == username && a.Password == password);

                //checks the condition on if there any value that was store in the variable declared above
                if (user != null)
                {
                    MessageBox.Show("You have been logged in successfully");
                    LoginUserRole userRole = new LoginUserRole();
                    //stores the role(admin, manager, staff) of the logged in user to a property from the LoginUserClass
                    userRole.roletype = user.Role;
                    //passes the role information as a parameter that will be referenced in the new form
                    Parentform parentform = new Parentform(userRole);
                    //
                    this.Hide();
                    parentform.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You have entered an incorrect username/password");
                    txtbxUsername.Clear();
                    txtbxPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.Source);   
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //this method allows the user to see or hide their password entry in the textbox
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

        //this method manipulates the statusstrip component
        private void ClearStatus()
        {
            LoginSSlbl.Text = "";
            LoginSSlbl.BackColor = Color.White;
            LoginStatusStrip.BackColor = Color.White;
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
