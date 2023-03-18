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
    public partial class ManageUsers : Form
    {
        private readonly jampracticeEntities jamdb;
        public ManageUsers()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            //call a list of items from the the Roles Table to a variable
            var roles= jamdb.Roles.ToList();
            //the column roletype will display the names
            combxRole.DisplayMember = "roletype";
            //this column is for the primary key
            combxRole.ValueMember = "id";
            //This is the source that was queryed from above
            combxRole.DataSource = roles;

            //query the database for a list of items from the orgs table
            var com = jamdb.Orgs.ToList();
            //assign the items to the display of the combobox
            combxOrg.DisplayMember = "company";
            //assign the items to the respeective id
            combxOrg.ValueMember = "id";
            //call the source of the list which was referenced above
            combxOrg.DataSource = com;

            //dataGridView1 = jamdb.
                       
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var fname = txtbxFname.Text;
            var lname = txtbxLname.Text;
            var email = txtbxEmail.Text;
            var username = txtbxUsername.Text;
            var password = txtbxPassword.Text;
            var org = combxOrg.Text;
            var role = combxRole.Text;
            var error = false;
            var ErrorMessage = "Error: ";

            /*if(Convert.ToString(role)=="Choose a role")
            {
                MessageBox.Show("Please choose a role");
            }*/
            /*if (!email.Contains('@'))
            {
                MessageBox.Show("invalid email address");
            }*/
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    break; 
                }
                else { error = true; ErrorMessage = "password should contain special characters"; }
                
            }


            try
            {
                if(Convert.ToString(role)=="Choose a role")
                {
                    error = true;
                    ErrorMessage+="Please choose a role\n\r";
                }
                if (!email.Contains('@'))
                {
                    error = true;
                    ErrorMessage += "invalid email address\n\r";
                }

                if (!error)
                {
                    MessageBox.Show($"Name: {fname} {lname}" +
                    $"\nEmail: {email}" +
                    $"\nUsername: {username}" +
                    $"\nCompany: {org} " +
                    $"\nRole: {role}\n");

                    /*user users = new user();
                    users.fname = fname;
                    users.lname = lname;
                    users.email = email;
                    users.username = username;
                    users.companyid = Convert.ToInt32(combxOrg.SelectedValue);
                    users.roletypeid = Convert.ToInt32(combxRole.SelectedValue);

                    jamdb.users.Add(users);
                    jamdb.SaveChanges();*/
                }
                else { MessageBox.Show(ErrorMessage); }
            }
            catch (Exception displayerror)
            {
                MessageBox.Show(displayerror.Message);
               //throw;
            }
        
        }

        private void combxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combxOrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void seepassword_Click(object sender, EventArgs e)
        {
            if(seepassword.BackColor==Color.LightGray)
            {
                seepassword.BackColor = Color.White;
                txtbxPassword.PasswordChar = 'v';
            }
            else
            {
                seepassword.BackColor = Color.LightGray;
                txtbxPassword.PasswordChar = '*';
            }

        }
    }
}
