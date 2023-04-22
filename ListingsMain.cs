using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
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
        //references the roletype property in the login user class
        public ListingsMain(LoginUserRole userRole)
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
            lblRole.Text = userRole.roletype;
            lblRole.Visible = false;
        }

        //this functions refreshes the gridview table when it is referenced
        private void UpdateView()
        {
            CatalogueGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
            
            var catalogue = jamdb.ViewVehicles.Select(v => new
            {
                Image = v.Picture,
                Make = v.Make,
                Model = v.Model,
                year = v.year,
                VIN = v.VIN,
                BodyType = v.BodyType,
                
            }).ToList();
            CatalogueGridView.DataSource = catalogue;

            CatalogueGridView.Columns[5].HeaderText = "Body Type";         
            CatalogueGridView.Columns[0].HeaderCell.Style.ForeColor = Color.LimeGreen;

            //formats the image to display in the table
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)CatalogueGridView.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void ListingsMain_Load(object sender, EventArgs e)
        {
            UpdateView();            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
        private void CatalogueGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //stores the value that was in the cell under the VIN column into a variable
            var vinnum = (string)CatalogueGridView.SelectedRows[0].Cells["VIN"].Value;

            //searches the ViewVehicles table for an entry where the VIN matches the variable declared above and store the entire data in a variable called car
            var car = jamdb.ViewVehicles.FirstOrDefault(a => a.VIN == vinnum);

            
            var UserRole = new LoginUserRole();
            //stores the value located in the label to the roletype property
            UserRole.roletype = lblRole.Text;

            //create an object of this class and pass the properties and variables as parameters that will be used in the next form.
            VehicleDetailsForm detailsForm = new VehicleDetailsForm(car, UserRole);

            detailsForm.ShowDialog();
        }
    }
}
