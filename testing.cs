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


namespace Jamcheck
{
    
    public partial class FrmTest : Form
    {
        SqlConnection sql = new SqlConnection(@"data source=.\sqlexpress;initial catalog=JamCheckDB;integrated Security=true");
        SqlCommand add;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void txtbxParishes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            add = new SqlCommand($"insert into parish(name) " +
                $"Values('{txtbxParishes.Text}') ",sql);

            add.ExecuteNonQuery();
            MessageBox.Show("Parish added");
            txtbxParishes.Clear();
            sql.Close();

        }
    }
}
