namespace Jamcheck
{
    partial class StaffLoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLoginFrm));
            this.lblStaffLogin = new System.Windows.Forms.Label();
            this.txtBxStfUserName = new System.Windows.Forms.TextBox();
            this.lblStfUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBxStfPassword = new System.Windows.Forms.TextBox();
            this.btnStfLogin = new System.Windows.Forms.Button();
            this.picBxStfLoginPg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaffExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBxStfLoginPg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStaffLogin
            // 
            this.lblStaffLogin.AutoSize = true;
            this.lblStaffLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStaffLogin.Font = new System.Drawing.Font("Source Sans Pro", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLogin.Location = new System.Drawing.Point(2, 0);
            this.lblStaffLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffLogin.Name = "lblStaffLogin";
            this.lblStaffLogin.Size = new System.Drawing.Size(780, 50);
            this.lblStaffLogin.TabIndex = 0;
            this.lblStaffLogin.Text = "STAFF LOGIN";
            this.lblStaffLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBxStfUserName
            // 
            this.txtBxStfUserName.BackColor = System.Drawing.Color.White;
            this.txtBxStfUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxStfUserName.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxStfUserName.Location = new System.Drawing.Point(160, 80);
            this.txtBxStfUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxStfUserName.Name = "txtBxStfUserName";
            this.txtBxStfUserName.Size = new System.Drawing.Size(220, 28);
            this.txtBxStfUserName.TabIndex = 1;
            this.txtBxStfUserName.TextChanged += new System.EventHandler(this.txtBxUserName_TextChanged);
            // 
            // lblStfUserName
            // 
            this.lblStfUserName.AutoSize = true;
            this.lblStfUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStfUserName.Location = new System.Drawing.Point(20, 80);
            this.lblStfUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStfUserName.Name = "lblStfUserName";
            this.lblStfUserName.Size = new System.Drawing.Size(129, 24);
            this.lblStfUserName.TabIndex = 2;
            this.lblStfUserName.Text = "USERNAME";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 140);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(127, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtBxStfPassword
            // 
            this.txtBxStfPassword.BackColor = System.Drawing.Color.White;
            this.txtBxStfPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxStfPassword.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxStfPassword.Location = new System.Drawing.Point(160, 140);
            this.txtBxStfPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxStfPassword.Name = "txtBxStfPassword";
            this.txtBxStfPassword.PasswordChar = '*';
            this.txtBxStfPassword.Size = new System.Drawing.Size(220, 28);
            this.txtBxStfPassword.TabIndex = 4;
            this.txtBxStfPassword.TextChanged += new System.EventHandler(this.txtBxStfPassword_TextChanged);
            // 
            // btnStfLogin
            // 
            this.btnStfLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStfLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStfLogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStfLogin.Location = new System.Drawing.Point(160, 200);
            this.btnStfLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnStfLogin.Name = "btnStfLogin";
            this.btnStfLogin.Size = new System.Drawing.Size(100, 40);
            this.btnStfLogin.TabIndex = 5;
            this.btnStfLogin.Text = "LOGIN";
            this.btnStfLogin.UseVisualStyleBackColor = false;
            this.btnStfLogin.Click += new System.EventHandler(this.btnStfLogin_Click);
            // 
            // picBxStfLoginPg
            // 
            this.picBxStfLoginPg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxStfLoginPg.Image = ((System.Drawing.Image)(resources.GetObject("picBxStfLoginPg.Image")));
            this.picBxStfLoginPg.Location = new System.Drawing.Point(5, 5);
            this.picBxStfLoginPg.Margin = new System.Windows.Forms.Padding(5);
            this.picBxStfLoginPg.Name = "picBxStfLoginPg";
            this.picBxStfLoginPg.Padding = new System.Windows.Forms.Padding(5);
            this.picBxStfLoginPg.Size = new System.Drawing.Size(340, 312);
            this.picBxStfLoginPg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxStfLoginPg.TabIndex = 7;
            this.picBxStfLoginPg.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblStaffLogin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Controls.Add(this.picBxStfLoginPg, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 322);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.btnStaffExit);
            this.panel1.Controls.Add(this.btnStfLogin);
            this.panel1.Controls.Add(this.lblStfUserName);
            this.panel1.Controls.Add(this.txtBxStfPassword);
            this.panel1.Controls.Add(this.txtBxStfUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(353, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 316);
            this.panel1.TabIndex = 8;
            // 
            // btnStaffExit
            // 
            this.btnStaffExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStaffExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffExit.Location = new System.Drawing.Point(280, 200);
            this.btnStaffExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffExit.Name = "btnStaffExit";
            this.btnStaffExit.Size = new System.Drawing.Size(100, 40);
            this.btnStaffExit.TabIndex = 5;
            this.btnStaffExit.Text = "EXIT";
            this.btnStaffExit.UseVisualStyleBackColor = false;
            this.btnStaffExit.Click += new System.EventHandler(this.btnStaffExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblDate);
            this.panel2.Controls.Add(this.LblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 77);
            this.panel2.TabIndex = 9;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(365, 46);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(53, 25);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "Date";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(362, 21);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(56, 25);
            this.LblTime.TabIndex = 0;
            this.LblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StaffLoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "StaffLoginFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Login";
            ((System.ComponentModel.ISupportInitialize)(this.picBxStfLoginPg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStaffLogin;
        private System.Windows.Forms.TextBox txtBxStfUserName;
        private System.Windows.Forms.Label lblStfUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBxStfPassword;
        private System.Windows.Forms.Button btnStfLogin;
        private System.Windows.Forms.PictureBox picBxStfLoginPg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer timer1;
        private object btnStfExit;
        private System.Windows.Forms.Button btnStaffExit;
    }
}