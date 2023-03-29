namespace Jamcheck
{
    partial class ListingsMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingsMain));
            this.picBxListingMain = new System.Windows.Forms.PictureBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.ListingHeader = new System.Windows.Forms.TableLayoutPanel();
            this.Header = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.Mainlayout = new System.Windows.Forms.TableLayoutPanel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBxListingMain)).BeginInit();
            this.ListingHeader.SuspendLayout();
            this.Header.SuspendLayout();
            this.Mainlayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxListingMain
            // 
            this.picBxListingMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxListingMain.Image = ((System.Drawing.Image)(resources.GetObject("picBxListingMain.Image")));
            this.picBxListingMain.Location = new System.Drawing.Point(20, 0);
            this.picBxListingMain.Margin = new System.Windows.Forms.Padding(0);
            this.picBxListingMain.Name = "picBxListingMain";
            this.picBxListingMain.Size = new System.Drawing.Size(160, 80);
            this.picBxListingMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxListingMain.TabIndex = 1;
            this.picBxListingMain.TabStop = false;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.BackColor = System.Drawing.Color.LimeGreen;
            this.lblVehicleID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVehicleID.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleID.Location = new System.Drawing.Point(2, 0);
            this.lblVehicleID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(210, 40);
            this.lblVehicleID.TabIndex = 2;
            this.lblVehicleID.Text = "Vehicle ID";
            this.lblVehicleID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.LimeGreen;
            this.lblMake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMake.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.ForeColor = System.Drawing.Color.Black;
            this.lblMake.Location = new System.Drawing.Point(216, 0);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(210, 40);
            this.lblMake.TabIndex = 4;
            this.lblMake.Text = "Make";
            this.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.LimeGreen;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(430, 0);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(210, 40);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.BackColor = System.Drawing.Color.LimeGreen;
            this.lblVIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVIN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.ForeColor = System.Drawing.Color.Black;
            this.lblVIN.Location = new System.Drawing.Point(644, 0);
            this.lblVIN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(210, 40);
            this.lblVIN.TabIndex = 6;
            this.lblVIN.Text = "VIN";
            this.lblVIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.LimeGreen;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(858, 0);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(211, 40);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListingHeader
            // 
            this.ListingHeader.ColumnCount = 5;
            this.ListingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ListingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ListingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ListingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ListingHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ListingHeader.Controls.Add(this.lblVehicleID, 0, 0);
            this.ListingHeader.Controls.Add(this.lblYear, 4, 0);
            this.ListingHeader.Controls.Add(this.lblMake, 1, 0);
            this.ListingHeader.Controls.Add(this.lblVIN, 3, 0);
            this.ListingHeader.Controls.Add(this.lblModel, 2, 0);
            this.ListingHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListingHeader.Location = new System.Drawing.Point(0, 80);
            this.ListingHeader.Margin = new System.Windows.Forms.Padding(0);
            this.ListingHeader.Name = "ListingHeader";
            this.ListingHeader.RowCount = 1;
            this.ListingHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.83871F));
            this.ListingHeader.Size = new System.Drawing.Size(1071, 40);
            this.ListingHeader.TabIndex = 8;
            this.ListingHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Header
            // 
            this.Header.ColumnCount = 3;
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.Header.Controls.Add(this.picBxListingMain, 0, 0);
            this.Header.Controls.Add(this.btnViewAll, 2, 0);
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Header.RowCount = 1;
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Header.Size = new System.Drawing.Size(1071, 80);
            this.Header.TabIndex = 0;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewAll.BackColor = System.Drawing.Color.Chartreuse;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(894, 23);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewAll.Size = new System.Drawing.Size(147, 33);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View All Vehicles";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // Mainlayout
            // 
            this.Mainlayout.ColumnCount = 1;
            this.Mainlayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Mainlayout.Controls.Add(this.BtnExit, 0, 3);
            this.Mainlayout.Controls.Add(this.ListingHeader, 0, 1);
            this.Mainlayout.Controls.Add(this.Header, 0, 0);
            this.Mainlayout.Controls.Add(this.dataGridView1, 0, 2);
            this.Mainlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainlayout.Location = new System.Drawing.Point(0, 0);
            this.Mainlayout.Margin = new System.Windows.Forms.Padding(0);
            this.Mainlayout.Name = "Mainlayout";
            this.Mainlayout.RowCount = 4;
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Mainlayout.Size = new System.Drawing.Size(1071, 619);
            this.Mainlayout.TabIndex = 11;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.BorderSize = 2;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(925, 572);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(106, 35);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.Mainlayout.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 449);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListingsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 619);
            this.Controls.Add(this.Mainlayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListingsMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recent Vehicles";
            this.Load += new System.EventHandler(this.ListingsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxListingMain)).EndInit();
            this.ListingHeader.ResumeLayout(false);
            this.ListingHeader.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Mainlayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxListingMain;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TableLayoutPanel ListingHeader;
        private System.Windows.Forms.TableLayoutPanel Header;
        private System.Windows.Forms.TableLayoutPanel Mainlayout;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnExit;
    }
}