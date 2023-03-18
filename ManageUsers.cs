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
            //var roles= jamdb.Roles.ToList();
            //the column roletype will display the names
            combxRole.DisplayMember = "roletype";
            //this column is for the primary key
           // combxRole.ValueMember = "id";
            //This is the source that was queryed from above
            //combxRole.DataSource = roles;

            //query the database for a list of items from the orgs table
            //var com = jamdb.Orgs.ToList();
            //assign the items to the display of the combobox
            //combxOrg.DisplayMember = "company";
            //assign the items to the respeective id
            //combxOrg.ValueMember = "id";
            //call the source of the list which was referenced above
            //combxOrg.DataSource = com;

            //dataGridView1 = jamdb.
                       
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var fname = txtbxFname.Text;
            var lname = txtbxLname.Text;
            var email = txtbxUsername.Text;
            var username = txtbxUsername.Text;
            var org = combxOrg.Text;
            var role = combxRole.Text;

            if(Convert.ToString(role)=="Choose a role")
            {
                MessageBox.Show("Please choose a role");
            }
            else
            {
                MessageBox.Show($"Name: {fname} {lname}" +
                $"\nEmail: {email}" +
                $"\nUsername: {username}" +
                $"\nCompany: {org} " +
                $"\nRole: {role}\n");

                user users = new user();
                users.fname = fname;
                users.lname = lname;
                users.email = email;
                users.username = username;
                users.companyid = Convert.ToInt32(combxOrg.SelectedValue);
                users.roletypeid = Convert.ToInt32(combxRole.SelectedValue);

                jamdb.users.Add(users);
                jamdb.SaveChanges();
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
