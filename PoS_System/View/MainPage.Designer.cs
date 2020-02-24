using System.Drawing;

namespace PoS_System.View
{
    partial class MainPage
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.brandsTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.brandNameLbl = new System.Windows.Forms.Label();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.deleteBrandBtn = new System.Windows.Forms.Button();
            this.updateBrandBtn = new System.Windows.Forms.Button();
            this.addBrandBtn = new System.Windows.Forms.Button();
            this.brandTable = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.categoryNameLbl = new System.Windows.Forms.Label();
            this.cateoryBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addCatBtn = new System.Windows.Forms.Button();
            this.categoryLbl = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTab = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.brandsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).BeginInit();
            this.categoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLbl)).BeginInit();
            this.productTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tabs.Controls.Add(this.brandsTab);
            this.Tabs.Controls.Add(this.categoryTab);
            this.Tabs.Controls.Add(this.productTab);
            this.Tabs.Location = new System.Drawing.Point(3, 2);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(858, 480);
            this.Tabs.TabIndex = 0;
            // 
            // brandsTab
            // 
            this.brandsTab.BackgroundImage = global::PoS_System.Properties.Resources.mainBackground;
            this.brandsTab.Controls.Add(this.button4);
            this.brandsTab.Controls.Add(this.brandNameLbl);
            this.brandsTab.Controls.Add(this.brandBox);
            this.brandsTab.Controls.Add(this.deleteBrandBtn);
            this.brandsTab.Controls.Add(this.updateBrandBtn);
            this.brandsTab.Controls.Add(this.addBrandBtn);
            this.brandsTab.Controls.Add(this.brandTable);
            this.brandsTab.Location = new System.Drawing.Point(4, 25);
            this.brandsTab.Name = "brandsTab";
            this.brandsTab.Padding = new System.Windows.Forms.Padding(3);
            this.brandsTab.Size = new System.Drawing.Size(850, 451);
            this.brandsTab.TabIndex = 0;
            this.brandsTab.Text = "Brand";
            this.brandsTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = global::PoS_System.Properties.Resources.categoryIcon;
            this.button4.Location = new System.Drawing.Point(730, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 47);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // brandNameLbl
            // 
            this.brandNameLbl.AutoSize = true;
            this.brandNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.brandNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandNameLbl.ForeColor = System.Drawing.Color.SeaShell;
            this.brandNameLbl.Location = new System.Drawing.Point(25, 90);
            this.brandNameLbl.Name = "brandNameLbl";
            this.brandNameLbl.Size = new System.Drawing.Size(52, 18);
            this.brandNameLbl.TabIndex = 5;
            this.brandNameLbl.Text = "Name:";
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(80, 90);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(100, 20);
            this.brandBox.TabIndex = 4;
            // 
            // deleteBrandBtn
            // 
            this.deleteBrandBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBrandBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteBrandBtn.Location = new System.Drawing.Point(180, 130);
            this.deleteBrandBtn.Name = "deleteBrandBtn";
            this.deleteBrandBtn.Size = new System.Drawing.Size(75, 25);
            this.deleteBrandBtn.TabIndex = 3;
            this.deleteBrandBtn.Text = "Delete";
            this.deleteBrandBtn.UseVisualStyleBackColor = true;
            // 
            // updateBrandBtn
            // 
            this.updateBrandBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateBrandBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.updateBrandBtn.Location = new System.Drawing.Point(100, 130);
            this.updateBrandBtn.Name = "updateBrandBtn";
            this.updateBrandBtn.Size = new System.Drawing.Size(75, 25);
            this.updateBrandBtn.TabIndex = 2;
            this.updateBrandBtn.Text = "Update";
            this.updateBrandBtn.UseVisualStyleBackColor = true;
            // 
            // addBrandBtn
            // 
            this.addBrandBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBrandBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addBrandBtn.Location = new System.Drawing.Point(20, 130);
            this.addBrandBtn.Name = "addBrandBtn";
            this.addBrandBtn.Size = new System.Drawing.Size(75, 25);
            this.addBrandBtn.TabIndex = 1;
            this.addBrandBtn.Text = "Add";
            this.addBrandBtn.UseVisualStyleBackColor = true;
            // 
            // brandTable
            // 
            this.brandTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brandTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.brandTable.Location = new System.Drawing.Point(310, 90);
            this.brandTable.Name = "brandTable";
            this.brandTable.Size = new System.Drawing.Size(243, 46);
            this.brandTable.TabIndex = 0;
            this.brandTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandTable_CellContentClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "ID";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "Name";
            this.col2.Name = "col2";
            // 
            // categoryTab
            // 
            this.categoryTab.BackgroundImage = global::PoS_System.Properties.Resources.mainBackground;
            this.categoryTab.Controls.Add(this.button3);
            this.categoryTab.Controls.Add(this.categoryNameLbl);
            this.categoryTab.Controls.Add(this.cateoryBox);
            this.categoryTab.Controls.Add(this.button1);
            this.categoryTab.Controls.Add(this.button2);
            this.categoryTab.Controls.Add(this.addCatBtn);
            this.categoryTab.Controls.Add(this.categoryLbl);
            this.categoryTab.Location = new System.Drawing.Point(4, 25);
            this.categoryTab.Name = "categoryTab";
            this.categoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.categoryTab.Size = new System.Drawing.Size(850, 451);
            this.categoryTab.TabIndex = 1;
            this.categoryTab.Text = "Category";
            this.categoryTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            
            this.button3.Location = new System.Drawing.Point(730, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 47);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // categoryNameLbl
            // 
            this.categoryNameLbl.AutoSize = true;
            this.categoryNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLbl.ForeColor = System.Drawing.Color.SeaShell;
            this.categoryNameLbl.Location = new System.Drawing.Point(25, 90);
            this.categoryNameLbl.Name = "categoryNameLbl";
            this.categoryNameLbl.Size = new System.Drawing.Size(52, 18);
            this.categoryNameLbl.TabIndex = 11;
            this.categoryNameLbl.Text = "Name:";
            // 
            // cateoryBox
            // 
            this.cateoryBox.Location = new System.Drawing.Point(80, 90);
            this.cateoryBox.Name = "cateoryBox";
            this.cateoryBox.Size = new System.Drawing.Size(100, 20);
            this.cateoryBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addCatBtn
            // 
            this.addCatBtn.Location = new System.Drawing.Point(20, 130);
            this.addCatBtn.Name = "addCatBtn";
            this.addCatBtn.Size = new System.Drawing.Size(75, 25);
            this.addCatBtn.TabIndex = 7;
            this.addCatBtn.Text = "Add";
            this.addCatBtn.UseVisualStyleBackColor = true;
            // 
            // categoryLbl
            // 
            this.categoryLbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryLbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoryLbl.Location = new System.Drawing.Point(310, 90);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(243, 46);
            this.categoryLbl.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // productTab
            // 
            this.productTab.BackgroundImage = global::PoS_System.Properties.Resources.mainBackground;
            this.productTab.Controls.Add(this.button5);
            this.productTab.Location = new System.Drawing.Point(4, 25);
            this.productTab.Name = "productTab";
            this.productTab.Padding = new System.Windows.Forms.Padding(3);
            this.productTab.Size = new System.Drawing.Size(850, 451);
            this.productTab.TabIndex = 2;
            this.productTab.Text = "Product";
            this.productTab.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            
            this.button5.Location = new System.Drawing.Point(730, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 47);
            this.button5.TabIndex = 13;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 441);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Tabs.ResumeLayout(false);
            this.brandsTab.ResumeLayout(false);
            this.brandsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).EndInit();
            this.categoryTab.ResumeLayout(false);
            this.categoryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLbl)).EndInit();
            this.productTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage brandsTab;
        private System.Windows.Forms.TabPage categoryTab;
        private System.Windows.Forms.TabPage productTab;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.Button deleteBrandBtn;
        private System.Windows.Forms.Button updateBrandBtn;
        private System.Windows.Forms.Button addBrandBtn;
        private System.Windows.Forms.DataGridView brandTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.TextBox cateoryBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addCatBtn;
        private System.Windows.Forms.DataGridView categoryLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label brandNameLbl;
        private System.Windows.Forms.Label categoryNameLbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}