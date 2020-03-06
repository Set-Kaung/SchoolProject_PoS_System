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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.stockLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.categoryIDLbl = new System.Windows.Forms.Label();
            this.brandIDLbl = new System.Windows.Forms.Label();
            this.desLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.categoryIDBox = new System.Windows.Forms.TextBox();
            this.brandIDBox = new System.Windows.Forms.TextBox();
            this.desBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.prodcutPanel = new System.Windows.Forms.Panel();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.productBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.prodcutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(160)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.barcodeLbl);
            this.panel1.Controls.Add(this.stockLbl);
            this.panel1.Controls.Add(this.priceLbl);
            this.panel1.Controls.Add(this.categoryIDLbl);
            this.panel1.Controls.Add(this.brandIDLbl);
            this.panel1.Controls.Add(this.desLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.barcodeBox);
            this.panel1.Controls.Add(this.stockBox);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.categoryIDBox);
            this.panel1.Controls.Add(this.brandIDBox);
            this.panel1.Controls.Add(this.desBox);
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
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(105, 349);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 32;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.barcodeLbl.Location = new System.Drawing.Point(28, 39);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(68, 18);
            this.barcodeLbl.TabIndex = 31;
            this.barcodeLbl.Text = "Barcode:";
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.stockLbl.Location = new System.Drawing.Point(50, 266);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(51, 18);
            this.stockLbl.TabIndex = 30;
            this.stockLbl.Text = "Stock:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.priceLbl.Location = new System.Drawing.Point(50, 228);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(46, 18);
            this.priceLbl.TabIndex = 29;
            this.priceLbl.Text = "Price:";
            // 
            // categoryIDLbl
            // 
            this.categoryIDLbl.AutoSize = true;
            this.categoryIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDLbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.categoryIDLbl.Location = new System.Drawing.Point(6, 189);
            this.categoryIDLbl.Name = "categoryIDLbl";
            this.categoryIDLbl.Size = new System.Drawing.Size(90, 18);
            this.categoryIDLbl.TabIndex = 28;
            this.categoryIDLbl.Text = "Category ID:";
            // 
            // brandIDLbl
            // 
            this.brandIDLbl.AutoSize = true;
            this.brandIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandIDLbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.brandIDLbl.Location = new System.Drawing.Point(27, 148);
            this.brandIDLbl.Name = "brandIDLbl";
            this.brandIDLbl.Size = new System.Drawing.Size(69, 18);
            this.brandIDLbl.TabIndex = 27;
            this.brandIDLbl.Text = "Brand ID:";
            // 
            // desLbl
            // 
            this.desLbl.AutoSize = true;
            this.desLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desLbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.desLbl.Location = new System.Drawing.Point(9, 107);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(87, 18);
            this.desLbl.TabIndex = 26;
            this.desLbl.Text = "Description:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.nameLbl.Location = new System.Drawing.Point(44, 72);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(52, 18);
            this.nameLbl.TabIndex = 25;
            this.nameLbl.Text = "Name:";
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(105, 37);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(233, 20);
            this.barcodeBox.TabIndex = 24;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(105, 266);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(233, 20);
            this.stockBox.TabIndex = 23;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(105, 226);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(233, 20);
            this.priceBox.TabIndex = 22;
            // 
            // categoryIDBox
            // 
            this.categoryIDBox.Location = new System.Drawing.Point(105, 187);
            this.categoryIDBox.Name = "categoryIDBox";
            this.categoryIDBox.Size = new System.Drawing.Size(233, 20);
            this.categoryIDBox.TabIndex = 21;
            // 
            // brandIDBox
            // 
            this.brandIDBox.Location = new System.Drawing.Point(105, 146);
            this.brandIDBox.Name = "brandIDBox";
            this.brandIDBox.Size = new System.Drawing.Size(233, 20);
            this.brandIDBox.TabIndex = 20;
            // 
            // desBox
            // 
            this.desBox.Location = new System.Drawing.Point(105, 108);
            this.desBox.Name = "desBox";
            this.desBox.Size = new System.Drawing.Size(233, 20);
            this.desBox.TabIndex = 19;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(186, 349);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(139, 320);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(105, 72);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(233, 20);
            this.nameBox.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(58, 320);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(220, 320);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.productBarcode,
            this.productName,
            this.productDescription,
            this.productBrand,
            this.productCategory,
            this.productPrice,
            this.productStock});
            this.productTable.EnableHeadersVisualStyles = false;
            this.productTable.Location = new System.Drawing.Point(0, 0);
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersVisible = false;
            this.productTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTable.Size = new System.Drawing.Size(806, 421);
            this.productTable.TabIndex = 4;
            this.productTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productTable_CellContentClick);
            this.productTable.SelectionChanged += new System.EventHandler(this.productTable_SelectionChanged);
            // 
            // productBarcode
            // 
            this.productBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productBarcode.HeaderText = "Barcode";
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.ReadOnly = true;
            this.productBarcode.Width = 87;
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
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Product";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.prodcutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel prodcutPanel;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox categoryIDBox;
        private System.Windows.Forms.TextBox brandIDBox;
        private System.Windows.Forms.TextBox desBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label desLbl;
        private System.Windows.Forms.Label brandIDLbl;
        private System.Windows.Forms.Label categoryIDLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStock;
    }
}