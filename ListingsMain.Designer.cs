﻿namespace Jamcheck
{
    partial class ListingsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingsMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picBxListingMain = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.Mainlayout = new System.Windows.Forms.TableLayoutPanel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.CatalogueGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBxListingMain)).BeginInit();
            this.Header.SuspendLayout();
            this.Mainlayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogueGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxListingMain
            // 
            this.picBxListingMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxListingMain.Image = ((System.Drawing.Image)(resources.GetObject("picBxListingMain.Image")));
            this.picBxListingMain.Location = new System.Drawing.Point(20, 0);
            this.picBxListingMain.Margin = new System.Windows.Forms.Padding(0);
            this.picBxListingMain.Name = "picBxListingMain";
            this.picBxListingMain.Size = new System.Drawing.Size(160, 92);
            this.picBxListingMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxListingMain.TabIndex = 1;
            this.picBxListingMain.TabStop = false;
            // 
            // Header
            // 
            this.Header.ColumnCount = 3;
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.Header.Controls.Add(this.picBxListingMain, 0, 0);
            this.Header.Controls.Add(this.btnViewAll, 2, 0);
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Header.RowCount = 1;
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Header.Size = new System.Drawing.Size(1071, 92);
            this.Header.TabIndex = 0;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewAll.BackColor = System.Drawing.Color.Chartreuse;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(894, 29);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Padding = new System.Windows.Forms.Padding(5);
            this.btnViewAll.Size = new System.Drawing.Size(147, 33);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View All Vehicles";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Visible = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // Mainlayout
            // 
            this.Mainlayout.ColumnCount = 1;
            this.Mainlayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Mainlayout.Controls.Add(this.Header, 0, 0);
            this.Mainlayout.Controls.Add(this.CatalogueGridView, 0, 1);
            this.Mainlayout.Controls.Add(this.BtnExit, 0, 2);
            this.Mainlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainlayout.Location = new System.Drawing.Point(0, 0);
            this.Mainlayout.Margin = new System.Windows.Forms.Padding(0);
            this.Mainlayout.Name = "Mainlayout";
            this.Mainlayout.RowCount = 3;
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Mainlayout.Size = new System.Drawing.Size(1071, 619);
            this.Mainlayout.TabIndex = 11;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnExit.FlatAppearance.BorderSize = 2;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(925, 572);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(106, 35);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CatalogueGridView
            // 
            this.CatalogueGridView.AllowUserToAddRows = false;
            this.CatalogueGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatalogueGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CatalogueGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatalogueGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CatalogueGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatalogueGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CatalogueGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatalogueGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.CatalogueGridView.Location = new System.Drawing.Point(0, 92);
            this.CatalogueGridView.Margin = new System.Windows.Forms.Padding(0);
            this.CatalogueGridView.MultiSelect = false;
            this.CatalogueGridView.Name = "CatalogueGridView";
            this.CatalogueGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatalogueGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CatalogueGridView.RowHeadersWidth = 60;
            this.CatalogueGridView.RowTemplate.Height = 100;
            this.CatalogueGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatalogueGridView.Size = new System.Drawing.Size(1071, 477);
            this.CatalogueGridView.TabIndex = 12;
            this.CatalogueGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatalogueGridView_CellDoubleClick);
            // 
            // ListingsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 619);
            this.Controls.Add(this.Mainlayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListingsMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recent Vehicles";
            this.Load += new System.EventHandler(this.ListingsMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxListingMain)).EndInit();
            this.Header.ResumeLayout(false);
            this.Mainlayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CatalogueGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxListingMain;
        private System.Windows.Forms.TableLayoutPanel Header;
        private System.Windows.Forms.TableLayoutPanel Mainlayout;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DataGridView CatalogueGridView;
        private System.Windows.Forms.Button BtnExit;
    }
}