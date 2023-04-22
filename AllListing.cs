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
        private readonly jampracticeEntities jamdb = new jampracticeEntities();
        public ListingsMainAll()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
        }

        private void ListingsMainAll_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
            var testing = jamdb.ViewVehicles.Select(v => new
            {
                Image = v.Picture,
                Make = v.Make,
                Model = v.Model,
                year = v.year,
                VIN = v.VIN,
                BodyType = v.BodyType,
            }).ToList();

            dataGridView1.DataSource = testing;

            dataGridView1.Columns[5].HeaderText = "Body Type";
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.LimeGreen;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            var make = jamdb.Make.ToList();
            cobxmake.DisplayMember = "name";
            cobxmake.ValueMember = "id";
            cobxmake.DataSource = make;

            var fuel = jamdb.Fuel.ToList();
            cobxFuelType.DisplayMember = "name";
            cobxFuelType.ValueMember = "id";
            cobxFuelType.DataSource = fuel;

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*var num = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
            
            var car = jamdb.ViewVehicles.FirstOrDefault(a => a.id == num);
            var UserRole = new LoginUserRole();


            VehicleDetailsForm detailsForm = new VehicleDetailsForm(car, UserRole);

            detailsForm.ShowDialog();*/
            
        }
    }
}
