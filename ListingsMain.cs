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
        public ListingsMain()
        {
            InitializeComponent();
        }

        private void ListingsMain_Load(object sender, EventArgs e)
        {

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

    }
}
