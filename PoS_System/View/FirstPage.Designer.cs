namespace PoS_System.View
{
    partial class FirstPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.topPanel = new System.Windows.Forms.Panel();
            this.searchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchBox = new System.Windows.Forms.TextBox();
            this.brandTable = new System.Windows.Forms.DataGridView();
            this.brandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandPanel = new System.Windows.Forms.Panel();
            this.categoryTable = new System.Windows.Forms.DataGridView();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodcutPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.manageProductBtn = new System.Windows.Forms.Button();
            this.manageCategoryBtn = new System.Windows.Forms.Button();
            this.manageBrandBtn = new System.Windows.Forms.Button();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).BeginInit();
            this.brandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).BeginInit();
            this.categoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.prodcutPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1220, 40);
            this.topPanel.TabIndex = 0;
            // 
            // searchToolTip
            // 
            this.searchToolTip.ToolTipTitle = "Search Product";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(313, 313);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(226, 24);
            this.searchBox.TabIndex = 5;
            this.searchToolTip.SetToolTip(this.searchBox, "Search product by barcode");
            // 
            // brandTable
            // 
            this.brandTable.AllowUserToAddRows = false;
            this.brandTable.AllowUserToDeleteRows = false;
            this.brandTable.AllowUserToResizeRows = false;
            this.brandTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brandTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brandTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.brandTable.ColumnHeadersHeight = 30;
            this.brandTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.brandTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandID,
            this.brandName});
            this.brandTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandTable.EnableHeadersVisualStyles = false;
            this.brandTable.Location = new System.Drawing.Point(0, 0);
            this.brandTable.Name = "brandTable";
            this.brandTable.RowHeadersVisible = false;
            this.brandTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandTable.Size = new System.Drawing.Size(475, 257);
            this.brandTable.TabIndex = 3;
            this.brandTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandTable_CellContentClick);
            // 
            // brandID
            // 
            this.brandID.HeaderText = "ID";
            this.brandID.Name = "brandID";
            this.brandID.ReadOnly = true;
            // 
            // brandName
            // 
            this.brandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brandName.HeaderText = "Brand Name";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            // 
            // brandPanel
            // 
            this.brandPanel.Controls.Add(this.brandTable);
            this.brandPanel.Location = new System.Drawing.Point(292, 41);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Size = new System.Drawing.Size(475, 257);
            this.brandPanel.TabIndex = 2;
            // 
            // categoryTable
            // 
            this.categoryTable.AllowUserToAddRows = false;
            this.categoryTable.AllowUserToDeleteRows = false;
            this.categoryTable.AllowUserToResizeRows = false;
            this.categoryTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoryTable.ColumnHeadersHeight = 30;
            this.categoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryID,
            this.categoryName});
            this.categoryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTable.EnableHeadersVisualStyles = false;
            this.categoryTable.Location = new System.Drawing.Point(0, 0);
            this.categoryTable.Name = "categoryTable";
            this.categoryTable.RowHeadersVisible = false;
            this.categoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryTable.Size = new System.Drawing.Size(448, 258);
            this.categoryTable.TabIndex = 4;
            // 
            // categoryID
            // 
            this.categoryID.HeaderText = "ID";
            this.categoryID.Name = "categoryID";
            this.categoryID.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryName.HeaderText = "Category Name";
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // categoryPanel
            // 
            this.categoryPanel.Controls.Add(this.categoryTable);
            this.categoryPanel.Location = new System.Drawing.Point(773, 40);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(448, 258);
            this.categoryPanel.TabIndex = 3;
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AllowUserToResizeRows = false;
            this.productTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productTable.ColumnHeadersHeight = 30;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productDescription,
            this.productBrand,
            this.productCategory,
            this.productPrice,
            this.productStock,
            this.productBarcode});
            this.productTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTable.EnableHeadersVisualStyles = false;
            this.productTable.Location = new System.Drawing.Point(0, 0);
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersVisible = false;
            this.productTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTable.Size = new System.Drawing.Size(928, 308);
            this.productTable.TabIndex = 4;
            // 
            // productID
            // 
            this.productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productID.HeaderText = "ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 45;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productDescription
            // 
            this.productDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDescription.HeaderText = "Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            // 
            // productBrand
            // 
            this.productBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productBrand.HeaderText = "Brand ID";
            this.productBrand.Name = "productBrand";
            this.productBrand.ReadOnly = true;
            // 
            // productCategory
            // 
            this.productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCategory.HeaderText = "Category ID";
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productStock
            // 
            this.productStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productStock.HeaderText = "Stock";
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            // 
            // productBarcode
            // 
            this.productBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productBarcode.HeaderText = "Barcode";
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.ReadOnly = true;
            // 
            // prodcutPanel
            // 
            this.prodcutPanel.Controls.Add(this.productTable);
            this.prodcutPanel.Location = new System.Drawing.Point(293, 342);
            this.prodcutPanel.Name = "prodcutPanel";
            this.prodcutPanel.Size = new System.Drawing.Size(928, 308);
            this.prodcutPanel.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(554, 312);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 27);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // usernameLbl
            // 
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.usernameLbl.Location = new System.Drawing.Point(75, 120);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(123, 18);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleLbl
            // 
            this.roleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.roleLbl.Location = new System.Drawing.Point(75, 138);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(126, 18);
            this.roleLbl.TabIndex = 2;
            this.roleLbl.Text = "Adminstrator";
            this.roleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.leftPanel.Controls.Add(this.logoutBtn);
            this.leftPanel.Controls.Add(this.manageProductBtn);
            this.leftPanel.Controls.Add(this.manageCategoryBtn);
            this.leftPanel.Controls.Add(this.manageBrandBtn);
            this.leftPanel.Controls.Add(this.roleLbl);
            this.leftPanel.Controls.Add(this.usernameLbl);
            this.leftPanel.Controls.Add(this.profileIcon);
            this.leftPanel.Location = new System.Drawing.Point(0, 40);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(291, 611);
            this.leftPanel.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.Image = global::PoS_System.Properties.Resources.exitIcon;
            this.logoutBtn.Location = new System.Drawing.Point(3, 499);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(288, 91);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // manageProductBtn
            // 
            this.manageProductBtn.FlatAppearance.BorderSize = 0;
            this.manageProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageProductBtn.Image = global::PoS_System.Properties.Resources.productIcon;
            this.manageProductBtn.Location = new System.Drawing.Point(3, 277);
            this.manageProductBtn.Name = "manageProductBtn";
            this.manageProductBtn.Size = new System.Drawing.Size(282, 38);
            this.manageProductBtn.TabIndex = 6;
            this.manageProductBtn.Text = "Manage Product";
            this.manageProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageProductBtn.UseVisualStyleBackColor = true;
            this.manageProductBtn.Click += new System.EventHandler(this.manageProductBtn_Click);
            // 
            // manageCategoryBtn
            // 
            this.manageCategoryBtn.FlatAppearance.BorderSize = 0;
            this.manageCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCategoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageCategoryBtn.Image = global::PoS_System.Properties.Resources.categoryIcon;
            this.manageCategoryBtn.Location = new System.Drawing.Point(3, 233);
            this.manageCategoryBtn.Name = "manageCategoryBtn";
            this.manageCategoryBtn.Size = new System.Drawing.Size(285, 38);
            this.manageCategoryBtn.TabIndex = 4;
            this.manageCategoryBtn.Text = "Manage Category";
            this.manageCategoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageCategoryBtn.UseVisualStyleBackColor = true;
            this.manageCategoryBtn.Click += new System.EventHandler(this.manageCategoryBtn_Click);
            // 
            // manageBrandBtn
            // 
            this.manageBrandBtn.FlatAppearance.BorderSize = 0;
            this.manageBrandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBrandBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageBrandBtn.Image = global::PoS_System.Properties.Resources.brandIcon;
            this.manageBrandBtn.Location = new System.Drawing.Point(3, 189);
            this.manageBrandBtn.Name = "manageBrandBtn";
            this.manageBrandBtn.Size = new System.Drawing.Size(285, 38);
            this.manageBrandBtn.TabIndex = 5;
            this.manageBrandBtn.Text = "Manage Brand";
            this.manageBrandBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageBrandBtn.UseVisualStyleBackColor = true;
            this.manageBrandBtn.Click += new System.EventHandler(this.manageBrandBtn_Click);
            // 
            // profileIcon
            // 
            this.profileIcon.Image = global::PoS_System.Properties.Resources.profileIcon;
            this.profileIcon.Location = new System.Drawing.Point(95, 35);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(80, 82);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileIcon.TabIndex = 0;
            this.profileIcon.TabStop = false;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 650);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.prodcutPanel);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.brandPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).EndInit();
            this.brandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).EndInit();
            this.categoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.prodcutPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.ToolTip searchToolTip;
        private System.Windows.Forms.DataGridView brandTable;
        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.DataGridView categoryTable;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.Panel prodcutPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Button manageBrandBtn;
        private System.Windows.Forms.Button manageCategoryBtn;
        private System.Windows.Forms.Button manageProductBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
    }
}