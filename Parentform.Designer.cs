
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parentform));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.addVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerAndBodytypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerProfileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.useridlbl = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehiclesToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.dealerToolStripMenuItem,
            this.manufacturerAndBodytypeToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.CustomerProfileStripMenuItem,
            this.helpToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MainMenu.Size = new System.Drawing.Size(913, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // addVehiclesToolStripMenuItem
            // 
            this.addVehiclesToolStripMenuItem.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehiclesToolStripMenuItem.Name = "addVehiclesToolStripMenuItem";
            this.addVehiclesToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.addVehiclesToolStripMenuItem.Text = "Add Vehicles";
            this.addVehiclesToolStripMenuItem.Click += new System.EventHandler(this.addVehiclesToolStripMenuItem_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentToolStripMenuItem,
            this.allVehiclesToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.recentToolStripMenuItem.Text = " Recent Vehicles";
            this.recentToolStripMenuItem.Click += new System.EventHandler(this.recentToolStripMenuItem_Click);
            // 
            // allVehiclesToolStripMenuItem
            // 
            this.allVehiclesToolStripMenuItem.Name = "allVehiclesToolStripMenuItem";
            this.allVehiclesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.allVehiclesToolStripMenuItem.Text = "All Vehicles";
            this.allVehiclesToolStripMenuItem.Visible = false;
            this.allVehiclesToolStripMenuItem.Click += new System.EventHandler(this.allVehiclesToolStripMenuItem_Click);
            // 
            // dealerToolStripMenuItem
            // 
            this.dealerToolStripMenuItem.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerToolStripMenuItem.Name = "dealerToolStripMenuItem";
            this.dealerToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.dealerToolStripMenuItem.Text = "Dealerships";
            this.dealerToolStripMenuItem.Click += new System.EventHandler(this.dealerToolStripMenuItem_Click);
            // 
            // manufacturerAndBodytypeToolStripMenuItem
            // 
            this.manufacturerAndBodytypeToolStripMenuItem.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerAndBodytypeToolStripMenuItem.Name = "manufacturerAndBodytypeToolStripMenuItem";
            this.manufacturerAndBodytypeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.manufacturerAndBodytypeToolStripMenuItem.Text = "Manufacturer and Bodytype";
            this.manufacturerAndBodytypeToolStripMenuItem.Click += new System.EventHandler(this.manufacturerAndBodytypeToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // CustomerProfileStripMenuItem
            // 
            this.CustomerProfileStripMenuItem.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerProfileStripMenuItem.Name = "CustomerProfileStripMenuItem";
            this.CustomerProfileStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.CustomerProfileStripMenuItem.Text = "Customer Profile";
            this.CustomerProfileStripMenuItem.Click += new System.EventHandler(this.CustomerProfileStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(39, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.Location = new System.Drawing.Point(705, 173);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(35, 13);
            this.useridlbl.TabIndex = 3;
            this.useridlbl.Text = "label1";
            // 
            // Parentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Parentform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jam Check";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem addVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerProfileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerAndBodytypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.Label useridlbl;
    }
}