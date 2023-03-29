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
    public partial class ListingsMain : Form
    {
        private readonly jampracticeEntities jamdb;

        public ListingsMain()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();

        }

        private void ListingsMain_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;

            var vehicles = jamdb.ViewVehicles.ToList();
            dataGridView1.DataSource = vehicles;

            dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.LimeGreen;
            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 60;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //dataGridView1.Columns[1].CellTemplate.im
            /*            dataGridView1.Columns[2].Width = 250;
                        dataGridView1.Columns[2].Width = 250;
                        dataGridView1.Columns[6].Width = 250;
                        dataGridView1.Columns[7].Width = 250;*/
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            
            ListingsMainAll listingsAll = new ListingsMainAll();
            listingsAll.MdiParent = this.MdiParent;
            listingsAll.Dock = DockStyle.Fill;
            listingsAll.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
