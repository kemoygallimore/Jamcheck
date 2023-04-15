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
            CatalogueGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
            var testing = jamdb.ViewVehicles.Select(v => new
            {
                Image = v.Picture,
                Make = v.Make,
                Model = v.Model,
                year = v.year,
                VIN = v.VIN,
                BodyType = v.BodyType,
                v.id


            }).ToList();
            CatalogueGridView.DataSource = testing;

            CatalogueGridView.Columns[5].HeaderText = "Body Type";
            CatalogueGridView.Columns[6].Visible = false;

            CatalogueGridView.Columns[0].HeaderCell.Style.ForeColor = Color.LimeGreen;
            
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)CatalogueGridView.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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
        private void CatalogueGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var num = (int)CatalogueGridView.SelectedRows[0].Cells["id"].Value;

            var car = jamdb.ViewVehicles.FirstOrDefault(a => a.id == num);

            VehicleDetailsForm detailsForm = new VehicleDetailsForm(car);
            detailsForm.MdiParent = this.MdiParent;
            detailsForm.Dock = DockStyle.Fill;
            this.Hide();
            detailsForm.ShowDialog();
            this.Close();


        }
    }
}
