namespace PoS_System.View
{
    partial class ManageBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBrand));
            this.brandTable = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).BeginInit();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // brandTable
            // 
            this.brandTable.AllowUserToAddRows = false;
            this.brandTable.AllowUserToDeleteRows = false;
            this.brandTable.AllowUserToResizeRows = false;
            this.brandTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brandTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brandTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.brandTable.ColumnHeadersHeight = 30;
            this.brandTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.brandTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.brandName});
            this.brandTable.EnableHeadersVisualStyles = false;
            this.brandTable.Location = new System.Drawing.Point(376, 42);
            this.brandTable.Name = "brandTable";
            this.brandTable.RowHeadersVisible = false;
            this.brandTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandTable.Size = new System.Drawing.Size(604, 415);
            this.brandTable.TabIndex = 2;
            this.brandTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandTable_CellContentClick);
            this.brandTable.SelectionChanged += new System.EventHandler(this.brandTable_SelectionChanged);
            this.brandTable.Click += new System.EventHandler(this.brandTable_Click);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 37;
            // 
            // brandName
            // 
            this.brandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brandName.HeaderText = "Name";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.backPanel.Controls.Add(this.cancelBtn);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.topPanel);
            this.backPanel.Controls.Add(this.updateBtn);
            this.backPanel.Controls.Add(this.deleteBtn);
            this.backPanel.Controls.Add(this.addBtn);
            this.backPanel.Controls.Add(this.brandTable);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(980, 457);
            this.backPanel.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(117, 175);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(39, 104);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(233, 20);
            this.nameBox.TabIndex = 7;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.MistyRose;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(980, 44);
            this.topPanel.TabIndex = 6;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(117, 130);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(198, 130);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(36, 130);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ManageBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 457);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Brand";
            this.Load += new System.EventHandler(this.ManageBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandTable)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView brandTable;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
    }
}