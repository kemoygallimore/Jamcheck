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
    public partial class CarDealership : Form
    {
        private readonly jampracticeEntities jamdb;
        public CarDealership()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void combxParish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var name = tbxName.Text;
            var tel = tbxTelephone.Text;
            var address = txbAddress.Text;
            var parish = combxParish.SelectedItem;

            Dealerships dealer = new Dealerships();

            dealer.name = name;
            dealer.tel = tel;
            dealer.address = address;
            dealer.parishid = Convert.ToInt32(combxParish.SelectedValue);


            jamdb.Dealerships.Add(dealer);
            jamdb.SaveChanges();
            tbxName.Clear();
            tbxTelephone.Clear();
            txbAddress.Clear();

            MessageBox.Show(name + " has been added");

            dataGridView1.DataSource = jamdb.ViewDealerships.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarDealership_Load(object sender, EventArgs e)
        {
            CarDealership carDealership = new CarDealership();
            dataGridView1.DataSource = carDealership;

            combxParish.DataSource = jamdb.parishes.ToList();

            combxParish.DisplayMember = "Name";
            combxParish.ValueMember = "id";

            dataGridView1.DataSource = jamdb.ViewDealerships.ToList();
        }
    }
}
