namespace Jamcheck
{
    partial class VehicleDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DisplayPicture = new System.Windows.Forms.PictureBox();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.tblLayPanCarDetails = new System.Windows.Forms.TableLayoutPanel();
            this.Mileagetxtbx = new System.Windows.Forms.TextBox();
            this.transtxtbx = new System.Windows.Forms.TextBox();
            this.steeringtxtbx = new System.Windows.Forms.TextBox();
            this.fueltypetxtbx = new System.Windows.Forms.TextBox();
            this.Bodytypetxtbx = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblBodyType = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.maketxtbx = new System.Windows.Forms.TextBox();
            this.modeltxtbx = new System.Windows.Forms.TextBox();
            this.yeartxtbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).BeginInit();
            this.tblLayPanCarDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(9, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 493);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DisplayPicture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAddReport);
            this.splitContainer1.Panel2.Controls.Add(this.tblLayPanCarDetails);
            this.splitContainer1.Size = new System.Drawing.Size(1070, 493);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // DisplayPicture
            // 
            this.DisplayPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPicture.Location = new System.Drawing.Point(0, 0);
            this.DisplayPicture.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayPicture.Name = "DisplayPicture";
            this.DisplayPicture.Size = new System.Drawing.Size(445, 493);
            this.DisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayPicture.TabIndex = 0;
            this.DisplayPicture.TabStop = false;
            this.DisplayPicture.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // btnAddReport
            // 
            this.btnAddReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReport.Location = new System.Drawing.Point(503, 439);
            this.btnAddReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(99, 40);
            this.btnAddReport.TabIndex = 1;
            this.btnAddReport.Text = "Add Report";
            this.btnAddReport.UseVisualStyleBackColor = true;
            // 
            // tblLayPanCarDetails
            // 
            this.tblLayPanCarDetails.ColumnCount = 4;
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.Controls.Add(this.Mileagetxtbx, 3, 3);
            this.tblLayPanCarDetails.Controls.Add(this.transtxtbx, 1, 3);
            this.tblLayPanCarDetails.Controls.Add(this.steeringtxtbx, 3, 2);
            this.tblLayPanCarDetails.Controls.Add(this.fueltypetxtbx, 3, 1);
            this.tblLayPanCarDetails.Controls.Add(this.Bodytypetxtbx, 3, 0);
            this.tblLayPanCarDetails.Controls.Add(this.lblMake, 0, 0);
            this.tblLayPanCarDetails.Controls.Add(this.lblModel, 0, 1);
            this.tblLayPanCarDetails.Controls.Add(this.lblYear, 0, 2);
            this.tblLayPanCarDetails.Controls.Add(this.lblTransmission, 0, 3);
            this.tblLayPanCarDetails.Controls.Add(this.lblBodyType, 2, 0);
            this.tblLayPanCarDetails.Controls.Add(this.lblFuelType, 2, 1);
            this.tblLayPanCarDetails.Controls.Add(this.lblColour, 2, 2);
            this.tblLayPanCarDetails.Controls.Add(this.lblEngine, 2, 3);
            this.tblLayPanCarDetails.Controls.Add(this.maketxtbx, 1, 0);
            this.tblLayPanCarDetails.Controls.Add(this.modeltxtbx, 1, 1);
            this.tblLayPanCarDetails.Controls.Add(this.yeartxtbx, 1, 2);
            this.tblLayPanCarDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayPanCarDetails.Location = new System.Drawing.Point(0, 0);
            this.tblLayPanCarDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayPanCarDetails.Name = "tblLayPanCarDetails";
            this.tblLayPanCarDetails.RowCount = 4;
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.87685F));
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.36946F));
            this.tblLayPanCarDetails.Size = new System.Drawing.Size(622, 406);
            this.tblLayPanCarDetails.TabIndex = 0;
            // 
            // Mileagetxtbx
            // 
            this.Mileagetxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mileagetxtbx.Location = new System.Drawing.Point(468, 305);
            this.Mileagetxtbx.Multiline = true;
            this.Mileagetxtbx.Name = "Mileagetxtbx";
            this.Mileagetxtbx.Size = new System.Drawing.Size(151, 98);
            this.Mileagetxtbx.TabIndex = 13;
            this.Mileagetxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transtxtbx
            // 
            this.transtxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transtxtbx.Location = new System.Drawing.Point(158, 305);
            this.transtxtbx.Multiline = true;
            this.transtxtbx.Name = "transtxtbx";
            this.transtxtbx.Size = new System.Drawing.Size(149, 98);
            this.transtxtbx.TabIndex = 12;
            this.transtxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // steeringtxtbx
            // 
            this.steeringtxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steeringtxtbx.Location = new System.Drawing.Point(468, 205);
            this.steeringtxtbx.Multiline = true;
            this.steeringtxtbx.Name = "steeringtxtbx";
            this.steeringtxtbx.Size = new System.Drawing.Size(151, 94);
            this.steeringtxtbx.TabIndex = 11;
            this.steeringtxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fueltypetxtbx
            // 
            this.fueltypetxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fueltypetxtbx.Location = new System.Drawing.Point(468, 104);
            this.fueltypetxtbx.Multiline = true;
            this.fueltypetxtbx.Name = "fueltypetxtbx";
            this.fueltypetxtbx.Size = new System.Drawing.Size(151, 95);
            this.fueltypetxtbx.TabIndex = 10;
            this.fueltypetxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bodytypetxtbx
            // 
            this.Bodytypetxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bodytypetxtbx.Location = new System.Drawing.Point(468, 3);
            this.Bodytypetxtbx.Multiline = true;
            this.Bodytypetxtbx.Name = "Bodytypetxtbx";
            this.Bodytypetxtbx.Size = new System.Drawing.Size(151, 95);
            this.Bodytypetxtbx.TabIndex = 9;
            this.Bodytypetxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(2, 0);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(151, 101);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            this.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(2, 101);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(151, 101);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(2, 202);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(151, 100);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(2, 302);
            this.lblTransmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(151, 104);
            this.lblTransmission.TabIndex = 3;
            this.lblTransmission.Text = "Transmission";
            this.lblTransmission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBodyType
            // 
            this.lblBodyType.AutoSize = true;
            this.lblBodyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBodyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyType.Location = new System.Drawing.Point(312, 0);
            this.lblBodyType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBodyType.Name = "lblBodyType";
            this.lblBodyType.Size = new System.Drawing.Size(151, 101);
            this.lblBodyType.TabIndex = 4;
            this.lblBodyType.Text = "Body Type";
            this.lblBodyType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(312, 101);
            this.lblFuelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(151, 101);
            this.lblFuelType.TabIndex = 5;
            this.lblFuelType.Text = "Fuel Type";
            this.lblFuelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(312, 202);
            this.lblColour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(151, 100);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Steering";
            this.lblColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(312, 302);
            this.lblEngine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(151, 104);
            this.lblEngine.TabIndex = 7;
            this.lblEngine.Text = "Mileage";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maketxtbx
            // 
            this.maketxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maketxtbx.Location = new System.Drawing.Point(158, 3);
            this.maketxtbx.Multiline = true;
            this.maketxtbx.Name = "maketxtbx";
            this.maketxtbx.Size = new System.Drawing.Size(149, 95);
            this.maketxtbx.TabIndex = 8;
            this.maketxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maketxtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // modeltxtbx
            // 
            this.modeltxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeltxtbx.Location = new System.Drawing.Point(158, 104);
            this.modeltxtbx.Multiline = true;
            this.modeltxtbx.Name = "modeltxtbx";
            this.modeltxtbx.Size = new System.Drawing.Size(149, 95);
            this.modeltxtbx.TabIndex = 8;
            this.modeltxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yeartxtbx
            // 
            this.yeartxtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yeartxtbx.Location = new System.Drawing.Point(158, 205);
            this.yeartxtbx.Multiline = true;
            this.yeartxtbx.Name = "yeartxtbx";
            this.yeartxtbx.Size = new System.Drawing.Size(149, 94);
            this.yeartxtbx.TabIndex = 8;
            this.yeartxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 88);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.51052F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.48948F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 88);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VehicleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VehicleDetailsForm";
            this.Text = "VehicleDetailsForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).EndInit();
            this.tblLayPanCarDetails.ResumeLayout(false);
            this.tblLayPanCarDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tblLayPanCarDetails;
        private System.Windows.Forms.PictureBox DisplayPicture;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.Label lblBodyType;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox Mileagetxtbx;
        private System.Windows.Forms.TextBox transtxtbx;
        private System.Windows.Forms.TextBox steeringtxtbx;
        private System.Windows.Forms.TextBox fueltypetxtbx;
        private System.Windows.Forms.TextBox Bodytypetxtbx;
        private System.Windows.Forms.TextBox maketxtbx;
        private System.Windows.Forms.TextBox modeltxtbx;
        private System.Windows.Forms.TextBox yeartxtbx;
    }
}