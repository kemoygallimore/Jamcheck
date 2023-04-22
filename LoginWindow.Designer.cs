
namespace Jamcheck
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernamevallbl = new System.Windows.Forms.Label();
            this.seepassword = new System.Windows.Forms.PictureBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LoginSSlbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seepassword)).BeginInit();
            this.LoginStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::Jamcheck.Properties.Resources.Jamcheck_logo_transparent;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoginStatusStrip, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usernamevallbl);
            this.panel1.Controls.Add(this.seepassword);
            this.panel1.Controls.Add(this.txtbxPassword);
            this.panel1.Controls.Add(this.txtbxUsername);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // usernamevallbl
            // 
            resources.ApplyResources(this.usernamevallbl, "usernamevallbl");
            this.usernamevallbl.ForeColor = System.Drawing.Color.Red;
            this.usernamevallbl.Name = "usernamevallbl";
            // 
            // seepassword
            // 
            this.seepassword.BackColor = System.Drawing.Color.DimGray;
            this.seepassword.Image = global::Jamcheck.Properties.Resources.eye_icon_1457;
            resources.ApplyResources(this.seepassword, "seepassword");
            this.seepassword.Name = "seepassword";
            this.seepassword.TabStop = false;
            this.seepassword.Click += new System.EventHandler(this.seepassword_Click);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtbxPassword, "txtbxPassword");
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.UseSystemPasswordChar = true;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            this.txtbxPassword.MouseLeave += new System.EventHandler(this.txtbxPassword_MouseLeave);
            this.txtbxPassword.MouseHover += new System.EventHandler(this.txtbxPassword_MouseHover);
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtbxUsername, "txtbxUsername");
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.TextChanged += new System.EventHandler(this.txtbxUsername_TextChanged);
            this.txtbxUsername.MouseLeave += new System.EventHandler(this.txtbxUsername_MouseLeave);
            this.txtbxUsername.MouseHover += new System.EventHandler(this.txtbxUsername_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LoginStatusStrip
            // 
            resources.ApplyResources(this.LoginStatusStrip, "LoginStatusStrip");
            this.LoginStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginSSlbl});
            this.LoginStatusStrip.Name = "LoginStatusStrip";
            // 
            // LoginSSlbl
            // 
            resources.ApplyResources(this.LoginSSlbl, "LoginSSlbl");
            this.LoginSSlbl.Name = "LoginSSlbl";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.CustomsLoginFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seepassword)).EndInit();
            this.LoginStatusStrip.ResumeLayout(false);
            this.LoginStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox seepassword;
        private System.Windows.Forms.Label usernamevallbl;
        private System.Windows.Forms.StatusStrip LoginStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LoginSSlbl;
    }
}