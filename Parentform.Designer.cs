
namespace Jamcheck
{
    partial class Parentform
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.CustomsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.JamcheckMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ParentDisplayWindow = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ParentDisplayWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomsMenu,
            this.JamcheckMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // CustomsMenu
            // 
            this.CustomsMenu.Name = "CustomsMenu";
            this.CustomsMenu.Size = new System.Drawing.Size(154, 20);
            this.CustomsMenu.Text = "Jamaica Customs Agency";
            this.CustomsMenu.Click += new System.EventHandler(this.CustomsMenu_Click);
            // 
            // JamcheckMenu
            // 
            this.JamcheckMenu.Name = "JamcheckMenu";
            this.JamcheckMenu.Size = new System.Drawing.Size(76, 20);
            this.JamcheckMenu.Text = "Jam Check";
            this.JamcheckMenu.Click += new System.EventHandler(this.JamcheckMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Jamcheck.Properties.Resources.Jamcheck_logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ParentDisplayWindow
            // 
            this.ParentDisplayWindow.BackColor = System.Drawing.Color.White;
            this.ParentDisplayWindow.ColumnCount = 1;
            this.ParentDisplayWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ParentDisplayWindow.Controls.Add(this.pictureBox1, 0, 0);
            this.ParentDisplayWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParentDisplayWindow.Location = new System.Drawing.Point(0, 24);
            this.ParentDisplayWindow.Name = "ParentDisplayWindow";
            this.ParentDisplayWindow.RowCount = 2;
            this.ParentDisplayWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ParentDisplayWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ParentDisplayWindow.Size = new System.Drawing.Size(800, 426);
            this.ParentDisplayWindow.TabIndex = 0;
            // 
            // Parentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParentDisplayWindow);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Parentform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jam Check";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ParentDisplayWindow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem CustomsMenu;
        private System.Windows.Forms.ToolStripMenuItem JamcheckMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel ParentDisplayWindow;
    }
}