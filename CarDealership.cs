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
        private void ClearFields()
        {
            tbxName.Clear();
            tbxTelephone.Clear();
            txbAddress.Clear();
            combxParish.Text = "Select Parish";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
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
            ClearFields();

            MessageBox.Show(name + " has been added");

            dataGridView1.DataSource = jamdb.ViewDealerships.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* dataGridView1.DataSource = jamdb.ViewDealerships.ToList();
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Telephone";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "Parish";*/
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txbAddress.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbxTelephone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            combxParish.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            btnadd.Text = "Update";
        }
    }
}
