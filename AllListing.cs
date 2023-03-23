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
    public partial class ListingsMainAll : Form
    {
        private readonly jampracticeEntities jamdb;
        public ListingsMainAll()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
        }

        private void ListingsMainAll_Load(object sender, EventArgs e)
        {
            var vehicles = jamdb.ViewVehicles.ToList();
            dataGridView1.DataSource = vehicles;


            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
        }

        private void panel1All_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cobxmake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobxYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobxBodyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
