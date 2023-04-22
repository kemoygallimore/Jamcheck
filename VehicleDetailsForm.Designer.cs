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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetailsForm));
            this.DisplayPicture = new System.Windows.Forms.PictureBox();
            this.Downloadbtn = new System.Windows.Forms.Button();
            this.filenametxtbx = new System.Windows.Forms.TextBox();
            this.Uploadbtn = new System.Windows.Forms.Button();
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
            this.modeltxtbx = new System.Windows.Forms.TextBox();
            this.yeartxtbx = new System.Windows.Forms.TextBox();
            this.maketxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VINtxtbx = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Downloadnotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).BeginInit();
            this.tblLayPanCarDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayPicture
            // 
            this.DisplayPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPicture.Location = new System.Drawing.Point(0, 0);
            this.DisplayPicture.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayPicture.Name = "DisplayPicture";
            this.DisplayPicture.Size = new System.Drawing.Size(428, 417);
            this.DisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DisplayPicture.TabIndex = 0;
            this.DisplayPicture.TabStop = false;
            // 
            // Downloadbtn
            // 
            this.Downloadbtn.AutoSize = true;
            this.Downloadbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Downloadbtn.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Downloadbtn.Location = new System.Drawing.Point(468, 1);
            this.Downloadbtn.Name = "Downloadbtn";
            this.Downloadbtn.Size = new System.Drawing.Size(183, 32);
            this.Downloadbtn.TabIndex = 4;
            this.Downloadbtn.Text = "Download Report";
            this.Downloadbtn.UseVisualStyleBackColor = true;
            this.Downloadbtn.Click += new System.EventHandler(this.Openbtn_Click);
            // 
            // filenametxtbx
            // 
            this.filenametxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenametxtbx.Location = new System.Drawing.Point(23, 10);
            this.filenametxtbx.Name = "filenametxtbx";
            this.filenametxtbx.Size = new System.Drawing.Size(280, 29);
            this.filenametxtbx.TabIndex = 3;
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.AutoSize = true;
            this.Uploadbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Uploadbtn.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uploadbtn.Location = new System.Drawing.Point(23, 48);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(87, 32);
            this.Uploadbtn.TabIndex = 2;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // btnAddReport
            // 
            this.btnAddReport.AutoSize = true;
            this.btnAddReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddReport.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReport.Location = new System.Drawing.Point(468, 48);
            this.btnAddReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(162, 32);
            this.btnAddReport.TabIndex = 1;
            this.btnAddReport.Text = "Update Details";
            this.btnAddReport.UseVisualStyleBackColor = true;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // tblLayPanCarDetails
            // 
            this.tblLayPanCarDetails.ColumnCount = 5;
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.Controls.Add(this.Mileagetxtbx, 4, 3);
            this.tblLayPanCarDetails.Controls.Add(this.transtxtbx, 1, 3);
            this.tblLayPanCarDetails.Controls.Add(this.steeringtxtbx, 4, 2);
            this.tblLayPanCarDetails.Controls.Add(this.fueltypetxtbx, 4, 1);
            this.tblLayPanCarDetails.Controls.Add(this.Bodytypetxtbx, 4, 0);
            this.tblLayPanCarDetails.Controls.Add(this.lblMake, 0, 0);
            this.tblLayPanCarDetails.Controls.Add(this.lblModel, 0, 1);
            this.tblLayPanCarDetails.Controls.Add(this.lblYear, 0, 2);
            this.tblLayPanCarDetails.Controls.Add(this.lblTransmission, 0, 3);
            this.tblLayPanCarDetails.Controls.Add(this.lblBodyType, 3, 0);
            this.tblLayPanCarDetails.Controls.Add(this.lblFuelType, 3, 1);
            this.tblLayPanCarDetails.Controls.Add(this.lblColour, 3, 2);
            this.tblLayPanCarDetails.Controls.Add(this.lblEngine, 3, 3);
            this.tblLayPanCarDetails.Controls.Add(this.modeltxtbx, 1, 1);
            this.tblLayPanCarDetails.Controls.Add(this.yeartxtbx, 1, 2);
            this.tblLayPanCarDetails.Controls.Add(this.maketxtbx, 1, 0);
            this.tblLayPanCarDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayPanCarDetails.Location = new System.Drawing.Point(2, 2);
            this.tblLayPanCarDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayPanCarDetails.Name = "tblLayPanCarDetails";
            this.tblLayPanCarDetails.RowCount = 4;
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayPanCarDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayPanCarDetails.Size = new System.Drawing.Size(644, 243);
            this.tblLayPanCarDetails.TabIndex = 0;
            // 
            // Mileagetxtbx
            // 
            this.Mileagetxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mileagetxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mileagetxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mileagetxtbx.Location = new System.Drawing.Point(514, 200);
            this.Mileagetxtbx.Multiline = true;
            this.Mileagetxtbx.Name = "Mileagetxtbx";
            this.Mileagetxtbx.Size = new System.Drawing.Size(119, 22);
            this.Mileagetxtbx.TabIndex = 13;
            this.Mileagetxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transtxtbx
            // 
            this.transtxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transtxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transtxtbx.Location = new System.Drawing.Point(157, 200);
            this.transtxtbx.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.transtxtbx.Multiline = true;
            this.transtxtbx.Name = "transtxtbx";
            this.transtxtbx.Size = new System.Drawing.Size(112, 22);
            this.transtxtbx.TabIndex = 12;
            this.transtxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // steeringtxtbx
            // 
            this.steeringtxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.steeringtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.steeringtxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steeringtxtbx.Location = new System.Drawing.Point(514, 139);
            this.steeringtxtbx.Multiline = true;
            this.steeringtxtbx.Name = "steeringtxtbx";
            this.steeringtxtbx.Size = new System.Drawing.Size(119, 22);
            this.steeringtxtbx.TabIndex = 11;
            this.steeringtxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fueltypetxtbx
            // 
            this.fueltypetxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fueltypetxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fueltypetxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fueltypetxtbx.Location = new System.Drawing.Point(514, 79);
            this.fueltypetxtbx.Multiline = true;
            this.fueltypetxtbx.Name = "fueltypetxtbx";
            this.fueltypetxtbx.Size = new System.Drawing.Size(119, 22);
            this.fueltypetxtbx.TabIndex = 10;
            this.fueltypetxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bodytypetxtbx
            // 
            this.Bodytypetxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bodytypetxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bodytypetxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bodytypetxtbx.Location = new System.Drawing.Point(514, 19);
            this.Bodytypetxtbx.Multiline = true;
            this.Bodytypetxtbx.Name = "Bodytypetxtbx";
            this.Bodytypetxtbx.Size = new System.Drawing.Size(119, 22);
            this.Bodytypetxtbx.TabIndex = 9;
            this.Bodytypetxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMake.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(2, 0);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(137, 60);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            this.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModel.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(2, 60);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(137, 60);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(2, 120);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(137, 60);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransmission.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransmission.Location = new System.Drawing.Point(2, 180);
            this.lblTransmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(137, 63);
            this.lblTransmission.TabIndex = 3;
            this.lblTransmission.Text = "Transmission";
            this.lblTransmission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBodyType
            // 
            this.lblBodyType.AutoSize = true;
            this.lblBodyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBodyType.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodyType.Location = new System.Drawing.Point(364, 0);
            this.lblBodyType.Margin = new System.Windows.Forms.Padding(2, 0, 7, 0);
            this.lblBodyType.Name = "lblBodyType";
            this.lblBodyType.Size = new System.Drawing.Size(132, 60);
            this.lblBodyType.TabIndex = 4;
            this.lblBodyType.Text = "Body Type";
            this.lblBodyType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFuelType.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(364, 60);
            this.lblFuelType.Margin = new System.Windows.Forms.Padding(2, 0, 7, 0);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(132, 60);
            this.lblFuelType.TabIndex = 5;
            this.lblFuelType.Text = "Fuel Type";
            this.lblFuelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColour.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(364, 120);
            this.lblColour.Margin = new System.Windows.Forms.Padding(2, 0, 7, 0);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(132, 60);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Steering";
            this.lblColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEngine.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(364, 180);
            this.lblEngine.Margin = new System.Windows.Forms.Padding(2, 0, 7, 0);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(132, 63);
            this.lblEngine.TabIndex = 7;
            this.lblEngine.Text = "Mileage";
            this.lblEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modeltxtbx
            // 
            this.modeltxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modeltxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modeltxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeltxtbx.Location = new System.Drawing.Point(157, 79);
            this.modeltxtbx.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.modeltxtbx.Multiline = true;
            this.modeltxtbx.Name = "modeltxtbx";
            this.modeltxtbx.Size = new System.Drawing.Size(112, 22);
            this.modeltxtbx.TabIndex = 8;
            this.modeltxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yeartxtbx
            // 
            this.yeartxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yeartxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yeartxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartxtbx.Location = new System.Drawing.Point(157, 139);
            this.yeartxtbx.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.yeartxtbx.Multiline = true;
            this.yeartxtbx.Name = "yeartxtbx";
            this.yeartxtbx.Size = new System.Drawing.Size(112, 22);
            this.yeartxtbx.TabIndex = 8;
            this.yeartxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maketxtbx
            // 
            this.maketxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maketxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maketxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maketxtbx.Location = new System.Drawing.Point(157, 19);
            this.maketxtbx.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.maketxtbx.Multiline = true;
            this.maketxtbx.Name = "maketxtbx";
            this.maketxtbx.Size = new System.Drawing.Size(112, 22);
            this.maketxtbx.TabIndex = 8;
            this.maketxtbx.Text = "Test";
            this.maketxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "VIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VINtxtbx
            // 
            this.VINtxtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VINtxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VINtxtbx.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VINtxtbx.Location = new System.Drawing.Point(159, 22);
            this.VINtxtbx.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.VINtxtbx.Multiline = true;
            this.VINtxtbx.Name = "VINtxtbx";
            this.VINtxtbx.Size = new System.Drawing.Size(339, 24);
            this.VINtxtbx.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.55638F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.44362F));
            this.tableLayoutPanel2.Controls.Add(this.DisplayPicture, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 417F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1082, 417);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tblLayPanCarDetails, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(431, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.50608F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.49392F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(648, 411);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnAddReport);
            this.panel3.Controls.Add(this.Downloadbtn);
            this.panel3.Controls.Add(this.filenametxtbx);
            this.panel3.Controls.Add(this.Uploadbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 89);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VINtxtbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 69);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1088, 503);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.51052F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.48948F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IDlbl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 80);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(250, 5);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(35, 13);
            this.IDlbl.TabIndex = 1;
            this.IDlbl.Text = "label3";
            this.IDlbl.Visible = false;
            // 
            // Downloadnotifyicon
            // 
            this.Downloadnotifyicon.Visible = true;
            // 
            // VehicleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 503);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1104, 542);
            this.MinimumSize = new System.Drawing.Size(1104, 542);
            this.Name = "VehicleDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPicture)).EndInit();
            this.tblLayPanCarDetails.ResumeLayout(false);
            this.tblLayPanCarDetails.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VINtxtbx;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.TextBox filenametxtbx;
        private System.Windows.Forms.Button Downloadbtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon Downloadnotifyicon;
        private System.Windows.Forms.Button button1;
    }
}