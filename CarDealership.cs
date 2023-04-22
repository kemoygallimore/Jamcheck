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
            //initial the dasebase for this form
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
        //clear all the fields of this form
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CarDealership_Load(object sender, EventArgs e)
        {
            //the form loads up with the dealership information from the database
            CarDealership carDealership = new CarDealership();
            dataGridView1.DataSource = carDealership;
            dataGridView1.DataSource = jamdb.ViewDealerships.ToList();

            combxParish.DataSource = jamdb.parishes.ToList();
            combxParish.DisplayMember = "Name";
            combxParish.ValueMember = "id";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = e.RowIndex;
                
                tbxName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txbAddress.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbxTelephone.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                combxParish.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                btnAdd.Text = "Update";
            }
            catch (Exception dealer)
            {
                MessageBox.Show("Unable to populate fields from the database\n"+dealer.Message + "\n\n" + dealer.Source);
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //searches the dealership table for an entry that has the samee name that is in the tbxname and store the entire entry as an object 
                var DeleteItem = jamdb.Dealerships.FirstOrDefault(dealer => dealer.name == tbxName.Text);
                //removes that object from the database
                jamdb.Dealerships.Remove(DeleteItem);
                jamdb.SaveChanges();
                ClearFields();
                dataGridView1.DataSource = jamdb.ViewDealerships.ToList();
            }
            catch (Exception DealerRemove)
            {
                MessageBox.Show($"Unable to locate {tbxName} in the database. It may have already been removed\n\n{DealerRemove.Message} \n\n{DealerRemove.Source}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
    }
}
