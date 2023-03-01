namespace Jamcheck
{
    partial class StaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogin));
            this.lblStaffLogin = new System.Windows.Forms.Label();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.lblStfUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBxStfPassword = new System.Windows.Forms.TextBox();
            this.btnStfLogin = new System.Windows.Forms.Button();
            this.picBxStfLoginPg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBxStfLoginPg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStaffLogin
            // 
            this.lblStaffLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStaffLogin.AutoSize = true;
            this.lblStaffLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLogin.Location = new System.Drawing.Point(196, 0);
            this.lblStaffLogin.Name = "lblStaffLogin";
            this.lblStaffLogin.Size = new System.Drawing.Size(498, 65);
            this.lblStaffLogin.TabIndex = 0;
            this.lblStaffLogin.Text = "Vehicle Add Form";
            this.lblStaffLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStaffLogin.Click += new System.EventHandler(this.lblStaffLogin_Click);
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.BackColor = System.Drawing.Color.White;
            this.txtBxUserName.Location = new System.Drawing.Point(216, 92);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(199, 26);
            this.txtBxUserName.TabIndex = 1;
            this.txtBxUserName.TextChanged += new System.EventHandler(this.txtBxUserName_TextChanged);
            // 
            // lblStfUserName
            // 
            this.lblStfUserName.AutoSize = true;
            this.lblStfUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStfUserName.Location = new System.Drawing.Point(55, 92);
            this.lblStfUserName.Name = "lblStfUserName";
            this.lblStfUserName.Size = new System.Drawing.Size(83, 32);
            this.lblStfUserName.TabIndex = 2;
            this.lblStfUserName.Text = "Make";
            this.lblStfUserName.Click += new System.EventHandler(this.lblStfUserName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(17, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(179, 32);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Vehicle Type";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtBxStfPassword
            // 
            this.txtBxStfPassword.BackColor = System.Drawing.Color.White;
            this.txtBxStfPassword.Location = new System.Drawing.Point(216, 154);
            this.txtBxStfPassword.Name = "txtBxStfPassword";
            this.txtBxStfPassword.PasswordChar = '*';
            this.txtBxStfPassword.Size = new System.Drawing.Size(199, 26);
            this.txtBxStfPassword.TabIndex = 4;
            this.txtBxStfPassword.TextChanged += new System.EventHandler(this.txtBxStfPassword_TextChanged);
            // 
            // btnStfLogin
            // 
            this.btnStfLogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnStfLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStfLogin.Location = new System.Drawing.Point(161, 228);
            this.btnStfLogin.Name = "btnStfLogin";
            this.btnStfLogin.Size = new System.Drawing.Size(105, 43);
            this.btnStfLogin.TabIndex = 5;
            this.btnStfLogin.Text = "SUBMIT";
            this.btnStfLogin.UseVisualStyleBackColor = false;
            this.btnStfLogin.Click += new System.EventHandler(this.btnStfLogin_Click);
            // 
            // picBxStfLoginPg
            // 
            this.picBxStfLoginPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxStfLoginPg.Image = ((System.Drawing.Image)(resources.GetObject("picBxStfLoginPg.Image")));
            this.picBxStfLoginPg.Location = new System.Drawing.Point(8, 8);
            this.picBxStfLoginPg.Margin = new System.Windows.Forms.Padding(8);
            this.picBxStfLoginPg.Name = "picBxStfLoginPg";
            this.picBxStfLoginPg.Padding = new System.Windows.Forms.Padding(8);
            this.picBxStfLoginPg.Size = new System.Drawing.Size(432, 283);
            this.picBxStfLoginPg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxStfLoginPg.TabIndex = 7;
            this.picBxStfLoginPg.TabStop = false;
            this.picBxStfLoginPg.Click += new System.EventHandler(this.picBxStfLoginPg_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStaffLogin, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.74863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.38798F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 502);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.84175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.15825F));
            this.tableLayoutPanel2.Controls.Add(this.picBxStfLoginPg, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 130);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(883, 299);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.btnStfLogin);
            this.panel1.Controls.Add(this.lblStfUserName);
            this.panel1.Controls.Add(this.txtBxStfPassword);
            this.panel1.Controls.Add(this.txtBxUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(452, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 289);
            this.panel1.TabIndex = 8;
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(913, 558);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(913, 558);
            this.Name = "StaffLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleAddForm";
            this.Load += new System.EventHandler(this.Listings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxStfLoginPg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStaffLogin;
        private System.Windows.Forms.TextBox txtBxUserName;
        private System.Windows.Forms.Label lblStfUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBxStfPassword;
        private System.Windows.Forms.Button btnStfLogin;
        private System.Windows.Forms.PictureBox picBxStfLoginPg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}