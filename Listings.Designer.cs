namespace Jamcheck
{
    partial class Listings
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
            this.lblStaffLogin = new System.Windows.Forms.Label();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.lblStfUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBxStfPassword = new System.Windows.Forms.TextBox();
            this.btnStfLogin = new System.Windows.Forms.Button();
            this.btnStfExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStaffLogin
            // 
            this.lblStaffLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStaffLogin.AutoSize = true;
            this.lblStaffLogin.Font = new System.Drawing.Font("Bernard MT Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLogin.Location = new System.Drawing.Point(286, 9);
            this.lblStaffLogin.Name = "lblStaffLogin";
            this.lblStaffLogin.Size = new System.Drawing.Size(224, 55);
            this.lblStaffLogin.TabIndex = 0;
            this.lblStaffLogin.Text = "Staff Login";
            this.lblStaffLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.Location = new System.Drawing.Point(555, 143);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(210, 22);
            this.txtBxUserName.TabIndex = 1;
            // 
            // lblStfUserName
            // 
            this.lblStfUserName.AutoSize = true;
            this.lblStfUserName.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStfUserName.Location = new System.Drawing.Point(437, 136);
            this.lblStfUserName.Name = "lblStfUserName";
            this.lblStfUserName.Size = new System.Drawing.Size(112, 28);
            this.lblStfUserName.TabIndex = 2;
            this.lblStfUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bernard MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(439, 192);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 28);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtBxStfPassword
            // 
            this.txtBxStfPassword.Location = new System.Drawing.Point(555, 197);
            this.txtBxStfPassword.Name = "txtBxStfPassword";
            this.txtBxStfPassword.Size = new System.Drawing.Size(210, 22);
            this.txtBxStfPassword.TabIndex = 4;
            // 
            // btnStfLogin
            // 
            this.btnStfLogin.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStfLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStfLogin.Location = new System.Drawing.Point(444, 297);
            this.btnStfLogin.Name = "btnStfLogin";
            this.btnStfLogin.Size = new System.Drawing.Size(81, 35);
            this.btnStfLogin.TabIndex = 5;
            this.btnStfLogin.Text = "Login";
            this.btnStfLogin.UseVisualStyleBackColor = false;
            // 
            // btnStfExit
            // 
            this.btnStfExit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStfExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStfExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStfExit.Location = new System.Drawing.Point(555, 297);
            this.btnStfExit.Name = "btnStfExit";
            this.btnStfExit.Size = new System.Drawing.Size(91, 35);
            this.btnStfExit.TabIndex = 6;
            this.btnStfExit.Text = "Exit";
            this.btnStfExit.UseVisualStyleBackColor = false;
            // 
            // Listings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStfExit);
            this.Controls.Add(this.btnStfLogin);
            this.Controls.Add(this.txtBxStfPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblStfUserName);
            this.Controls.Add(this.txtBxUserName);
            this.Controls.Add(this.lblStaffLogin);
            this.Name = "Listings";
            this.Text = "Listings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffLogin;
        private System.Windows.Forms.TextBox txtBxUserName;
        private System.Windows.Forms.Label lblStfUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBxStfPassword;
        private System.Windows.Forms.Button btnStfLogin;
        private System.Windows.Forms.Button btnStfExit;
    }
}