namespace PoS_System.View
{
    partial class CashierModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierModule));
            this.backPanel = new System.Windows.Forms.Panel();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.productBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.backPanel.Controls.Add(this.checkoutBtn);
            this.backPanel.Controls.Add(this.removeBtn);
            this.backPanel.Controls.Add(this.addBtn);
            this.backPanel.Controls.Add(this.amountLbl);
            this.backPanel.Controls.Add(this.nameLbl);
            this.backPanel.Controls.Add(this.amountBox);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.barcodeBox);
            this.backPanel.Controls.Add(this.barcodeLbl);
            this.backPanel.Controls.Add(this.dataPanel);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1150, 550);
            this.backPanel.TabIndex = 0;
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AllowUserToResizeRows = false;
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
            this.productTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTable.EnableHeadersVisualStyles = false;
            this.productTable.Location = new System.Drawing.Point(0, 0);
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersVisible = false;
            this.productTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTable.Size = new System.Drawing.Size(1150, 368);
            this.productTable.TabIndex = 5;
            // 
            // productBarcode
            // 
            this.productBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productBarcode.HeaderText = "Barcode";
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.ReadOnly = true;
            // 
            // productStock
            // 
            this.productStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productStock.HeaderText = "Stock";
            this.productStock.Name = "productStock";
            this.productStock.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productCategory
            // 
            this.productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCategory.HeaderText = "Category ID";
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // productBrand
            // 
            this.productBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productBrand.HeaderText = "Brand ID";
            this.productBrand.Name = "productBrand";
            this.productBrand.ReadOnly = true;
            // 
            // productDescription
            // 
            this.productDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDescription.HeaderText = "Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productID
            // 
            this.productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productID.HeaderText = "ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Width = 45;
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPanel.BackColor = System.Drawing.Color.White;
            this.dataPanel.Controls.Add(this.productTable);
            this.dataPanel.Location = new System.Drawing.Point(0, 182);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1150, 368);
            this.dataPanel.TabIndex = 0;
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.BackColor = System.Drawing.Color.Transparent;
            this.barcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.barcodeLbl.Location = new System.Drawing.Point(22, 32);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(68, 18);
            this.barcodeLbl.TabIndex = 1;
            this.barcodeLbl.Text = "Bracode:";
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(96, 33);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(113, 20);
            this.barcodeBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(287, 32);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 20);
            this.nameBox.TabIndex = 3;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(509, 33);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 4;
            this.amountBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLbl.Location = new System.Drawing.Point(229, 35);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(52, 18);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Name:";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.BackColor = System.Drawing.Color.Transparent;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.amountLbl.Location = new System.Drawing.Point(440, 33);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(63, 18);
            this.amountLbl.TabIndex = 6;
            this.amountLbl.Text = "Amount:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(96, 117);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(216, 117);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Location = new System.Drawing.Point(329, 117);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(75, 23);
            this.checkoutBtn.TabIndex = 9;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            // 
            // CashierModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashierModule";
            this.Text = "CashierModule";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcode;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button checkoutBtn;
    }
}