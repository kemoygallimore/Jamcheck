﻿using System;
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
        jampracticeEntities jamdb;
        public FrmAddVehicle()
        {
            InitializeComponent();
            jamdb = new jampracticeEntities();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtnAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnManual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCVT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFile.FileName.ToString();
            }
        }
    }
}
