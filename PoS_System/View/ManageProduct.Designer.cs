namespace PoS_System.View
{
    partial class ManageProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProduct));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.prodcutPanel = new System.Windows.Forms.Panel();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.prodcutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.prodcutPanel);
            this.leftPanel.Controls.Add(this.topPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1184, 461);
            this.leftPanel.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.MistyRose;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1184, 41);
            this.topPanel.TabIndex = 1;
            // 
            // prodcutPanel
            // 
            this.prodcutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prodcutPanel.Controls.Add(this.productTable);
            this.prodcutPanel.Location = new System.Drawing.Point(378, 40);
            this.prodcutPanel.Name = "prodcutPanel";
            this.prodcutPanel.Size = new System.Drawing.Size(806, 421);
            this.prodcutPanel.TabIndex = 5;
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AllowUserToResizeRows = false;
            this.productTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.productTable.EnableHeadersVisualStyles = false;
            this.productTable.Location = new System.Drawing.Point(0, 0);
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersVisible = false;
            this.productTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTable.Size = new System.Drawing.Size(806, 421);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 421);
            this.panel1.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(129, 128);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(51, 57);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(233, 20);
            this.nameBox.TabIndex = 17;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(129, 83);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(210, 83);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(48, 83);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.leftPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProduct";
            this.Text = "Manage Product";
            this.leftPanel.ResumeLayout(false);
            this.prodcutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel prodcutPanel;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}