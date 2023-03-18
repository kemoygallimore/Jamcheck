﻿
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
            this.addVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerAndBodytypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerProfileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehiclesToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.dealerToolStripMenuItem,
            this.manufacturerAndBodytypeToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.CustomerProfileStripMenuItem,
            this.TransactionsToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1836, 35);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // addVehiclesToolStripMenuItem
            // 
            this.addVehiclesToolStripMenuItem.Name = "addVehiclesToolStripMenuItem";
            this.addVehiclesToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.addVehiclesToolStripMenuItem.Text = "Add Vehicles";
            this.addVehiclesToolStripMenuItem.Click += new System.EventHandler(this.addVehiclesToolStripMenuItem_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentToolStripMenuItem,
            this.allVehiclesToolStripMenuItem});
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.manageVehiclesToolStripMenuItem.Text = "Manage Vehicles";
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.recentToolStripMenuItem.Text = " Recent Vehicles";
            this.recentToolStripMenuItem.Click += new System.EventHandler(this.recentToolStripMenuItem_Click);
            // 
            // allVehiclesToolStripMenuItem
            // 
            this.allVehiclesToolStripMenuItem.Name = "allVehiclesToolStripMenuItem";
            this.allVehiclesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.allVehiclesToolStripMenuItem.Text = "All Vehicles";
            this.allVehiclesToolStripMenuItem.Click += new System.EventHandler(this.allVehiclesToolStripMenuItem_Click);
            // 
            // dealerToolStripMenuItem
            // 
            this.dealerToolStripMenuItem.Name = "dealerToolStripMenuItem";
            this.dealerToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.dealerToolStripMenuItem.Text = "Dealerships";
            this.dealerToolStripMenuItem.Click += new System.EventHandler(this.dealerToolStripMenuItem_Click);
            // 
            // manufacturerAndBodytypeToolStripMenuItem
            // 
            this.manufacturerAndBodytypeToolStripMenuItem.Name = "manufacturerAndBodytypeToolStripMenuItem";
            this.manufacturerAndBodytypeToolStripMenuItem.Size = new System.Drawing.Size(249, 29);
            this.manufacturerAndBodytypeToolStripMenuItem.Text = "Manufacturer and Bodytype";
            this.manufacturerAndBodytypeToolStripMenuItem.Click += new System.EventHandler(this.manufacturerAndBodytypeToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // CustomerProfileStripMenuItem
            // 
            this.CustomerProfileStripMenuItem.Name = "CustomerProfileStripMenuItem";
            this.CustomerProfileStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.CustomerProfileStripMenuItem.Text = "Customer Profile";
            // 
            // TransactionsToolStripMenuItem
            // 
            this.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem";
            this.TransactionsToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.TransactionsToolStripMenuItem.Text = "Transactions";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // Parentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 1050);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ToolStripMenuItem TransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerAndBodytypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
    }
}