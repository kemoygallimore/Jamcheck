using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Jamcheck
{
    public partial class ManageUsers : Form
    {
        private readonly jampracticeEntities jamdb;
        private readonly SqlConnection conn = new SqlConnection("server=.\\sqlexpress; Initial Catalog=jampractice; Integrated Security=True");
        public ManageUsers()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
        }
        private void PopulateFields(int id)
        {
            txtbxFname.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            txtbxLname.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            txtbxUsername.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            txtbxEmail.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            combxRole.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
        }
        private bool CheckIfUserExists()
        {
            var checkuser = jamdb.users.FirstOrDefault(a => a.username == txtbxUsername.Text);
            var checkemail = jamdb.users.FirstOrDefault(a => a.email == txtbxEmail.Text);
            return checkuser != null || checkemail != null;
        }

        private void AddEdit()
        {
            
        }
        private void Showusers()
        {
            conn.Open();
            SqlCommand display = new SqlCommand("select fname [First Name], lname [Last Name],Username,Email,Password,R.roletype [Role],o.company [Company]from users u left join Roles r on u.roletypeid = r.id left join Org o on u.companyid = o.id",conn);
            SqlDataAdapter da = new SqlDataAdapter(display);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            conn.Close();
        }

        private void ClearFields()
        {
            txtbxEmail.Clear();
            txtbxFname.Clear();
            txtbxLname.Clear();
            txtbxPassword.Clear();
            txtbxUsername.Clear();
            combxRole = null;
            combxOrg = null;
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
            var com = jamdb.Org.ToList();
            //assign the items to the display of the combobox
            combxOrg.DisplayMember = "company";
            //assign the items to the respeective id
            combxOrg.ValueMember = "id";
            //call the source of the list which was referenced above
            combxOrg.DataSource = com;
            Showusers();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var fname = txtbxFname.Text;
            var lname = txtbxLname.Text;
            var email = txtbxEmail.Text;
            var username = txtbxUsername.Text;
            var org = combxOrg.Text;
            var role = combxRole.Text;
            var password = txtbxPassword.Text;

            if(BtnAdd.Text=="Add User")
            {

                if (CheckIfUserExists())
                {
                    MessageBox.Show("Username or Email already exists");
                }

                else
                {
                    if (Convert.ToString(role) == "Choose a role")
                    {
                        MessageBox.Show("Please choose a role");
                    }
                    else
                    {
                        users AddUser = new users();

                        AddUser.fname = fname;
                        AddUser.lname = lname;
                        AddUser.email = email;
                        AddUser.username = username;
                        AddUser.password = password;
                        AddUser.companyid = Convert.ToInt32(combxOrg.SelectedValue);
                        AddUser.roletypeid = Convert.ToInt32(combxRole.SelectedValue);

                        jamdb.users.Add(AddUser);
                        jamdb.SaveChanges();

                        MessageBox.Show("Records have been added");
                        ClearFields();
                        Showusers();
                    }
                }
                
            }
            if (BtnAdd.Text=="Update User")
            {
                var LocateUsername = jamdb.users.FirstOrDefault(u => u.username == username);
                LocateUsername.fname = fname;
                LocateUsername.lname = lname;
                LocateUsername.email = email;
                LocateUsername.username = username;
                LocateUsername.roletypeid = Convert.ToInt32(combxRole.SelectedValue);
                jamdb.SaveChanges();
                BtnAdd.Text = "Add User";
                Showusers();
            }
        }
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {            
            var id = dataGridView1.SelectedRows[0].Index;
            var user = jamdb.users.FirstOrDefault(a => a.id == id);
            PopulateFields(id);
            BtnAdd.Text = "Update User";
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

 
    }
}
