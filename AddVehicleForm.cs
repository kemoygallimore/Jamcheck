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
    public partial class FrmAddVehicle : Form
    {
        Parentform Parent;
        SqlConnection sql = new SqlConnection(@"data source=.\sqlexpress; initial catalog=JamCheckDB; integrated security = true");
        SqlCommand add;
        public FrmAddVehicle()
        {
            InitializeComponent();
        }

        private void txtbxChassisNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxModelNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cobxImporter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxImportFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void numMileage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cobxMake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numSeating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            /*sql.Open();
            add = new SqlCommand($"insert into UsedCars(year, Makeid, model, bodytypeid, chassisnum, transnum, transtypeid, mileage, dealerid)" +
                $"values({numYear.Value}, {cobxMake.SelectedIndex),");*/
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
