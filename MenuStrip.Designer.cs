namespace Jamcheck
{
    partial class MenuStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffLogInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customsVehicleAddFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffLogInToolStripMenuItem,
            this.addVehicleFormToolStripMenuItem,
            this.customsVehicleAddFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffLogInToolStripMenuItem
            // 
            this.staffLogInToolStripMenuItem.Name = "staffLogInToolStripMenuItem";
            this.staffLogInToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.staffLogInToolStripMenuItem.Text = "Staff Log In";
            // 
            // addVehicleFormToolStripMenuItem
            // 
            this.addVehicleFormToolStripMenuItem.Name = "addVehicleFormToolStripMenuItem";
            this.addVehicleFormToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.addVehicleFormToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicleFormToolStripMenuItem.Click += new System.EventHandler(this.addVehicleFormToolStripMenuItem_Click);
            // 
            // customsVehicleAddFormToolStripMenuItem
            // 
            this.customsVehicleAddFormToolStripMenuItem.Name = "customsVehicleAddFormToolStripMenuItem";
            this.customsVehicleAddFormToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.customsVehicleAddFormToolStripMenuItem.Text = "Customs Vehicle Add ";
            // 
            // MenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 596);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuStrip";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem staffLogInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customsVehicleAddFormToolStripMenuItem;
    }
}