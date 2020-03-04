namespace PoS_System.View
{
    partial class ManageCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategory));
            this.backPanel = new System.Windows.Forms.Panel();
            this.tablePanle = new System.Windows.Forms.Panel();
            this.categoryTable = new System.Windows.Forms.DataGridView();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.backPanel.SuspendLayout();
            this.tablePanle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.backPanel.Controls.Add(this.tablePanle);
            this.backPanel.Controls.Add(this.leftPanel);
            this.backPanel.Controls.Add(this.topPanel);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(984, 461);
            this.backPanel.TabIndex = 0;
            // 
            // tablePanle
            // 
            this.tablePanle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanle.BackColor = System.Drawing.Color.White;
            this.tablePanle.Controls.Add(this.categoryTable);
            this.tablePanle.Location = new System.Drawing.Point(337, 45);
            this.tablePanle.Name = "tablePanle";
            this.tablePanle.Size = new System.Drawing.Size(647, 416);
            this.tablePanle.TabIndex = 2;
            // 
            // categoryTable
            // 
            this.categoryTable.AllowUserToAddRows = false;
            this.categoryTable.AllowUserToDeleteRows = false;
            this.categoryTable.AllowUserToResizeRows = false;
            this.categoryTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.categoryTable.Size = new System.Drawing.Size(647, 416);
            this.categoryTable.TabIndex = 5;
            this.categoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryTable_CellContentClick);
            this.categoryTable.SelectionChanged += new System.EventHandler(this.categoryTable_SelectionChanged);
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
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.leftPanel.Controls.Add(this.cancelBtn);
            this.leftPanel.Controls.Add(this.nameBox);
            this.leftPanel.Controls.Add(this.updateBtn);
            this.leftPanel.Controls.Add(this.deleteBtn);
            this.leftPanel.Controls.Add(this.addBtn);
            this.leftPanel.Location = new System.Drawing.Point(0, 45);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(337, 421);
            this.leftPanel.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(115, 128);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(37, 57);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(233, 20);
            this.nameBox.TabIndex = 12;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(115, 83);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(196, 83);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(34, 83);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.MistyRose;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(984, 47);
            this.topPanel.TabIndex = 0;
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.backPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Category";
            this.Load += new System.EventHandler(this.ManageCaetgory_Load);
            this.backPanel.ResumeLayout(false);
            this.tablePanle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel tablePanle;
        private System.Windows.Forms.DataGridView categoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
    }
}