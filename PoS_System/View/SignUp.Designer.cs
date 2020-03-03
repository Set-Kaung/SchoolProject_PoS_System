namespace PoS_System.View
{
    partial class SignUp
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.confirmPwdLbl = new System.Windows.Forms.Label();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordBox.Location = new System.Drawing.Point(21, 140);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(234, 20);
            this.passwordBox.TabIndex = 9;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.SeaShell;
            this.passwordLbl.Location = new System.Drawing.Point(18, 119);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(79, 18);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameBox.Location = new System.Drawing.Point(21, 82);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(234, 20);
            this.nameBox.TabIndex = 7;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.SeaShell;
            this.usernameLbl.Location = new System.Drawing.Point(18, 61);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(81, 18);
            this.usernameLbl.TabIndex = 6;
            this.usernameLbl.Text = "Username:";
            this.usernameLbl.Click += new System.EventHandler(this.usernameLbl_Click);
            // 
            // signUpLbl
            // 
            this.signUpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.BackColor = System.Drawing.Color.Transparent;
            this.signUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.ForeColor = System.Drawing.Color.SeaShell;
            this.signUpLbl.Location = new System.Drawing.Point(72, 9);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(117, 31);
            this.signUpLbl.TabIndex = 5;
            this.signUpLbl.Text = "Sign Up";
            // 
            // confirmPwdLbl
            // 
            this.confirmPwdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmPwdLbl.AutoSize = true;
            this.confirmPwdLbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPwdLbl.ForeColor = System.Drawing.Color.SeaShell;
            this.confirmPwdLbl.Location = new System.Drawing.Point(18, 163);
            this.confirmPwdLbl.Name = "confirmPwdLbl";
            this.confirmPwdLbl.Size = new System.Drawing.Size(136, 18);
            this.confirmPwdLbl.TabIndex = 10;
            this.confirmPwdLbl.Text = "Confirm Password:";
            // 
            // confirmBox
            // 
            this.confirmBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmBox.Location = new System.Drawing.Point(21, 184);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.PasswordChar = '*';
            this.confirmBox.Size = new System.Drawing.Size(234, 20);
            this.confirmBox.TabIndex = 11;
            this.confirmBox.UseSystemPasswordChar = true;
            // 
            // signUpBtn
            // 
            this.signUpBtn.AutoEllipsis = true;
            this.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signUpBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.Black;
            this.signUpBtn.Location = new System.Drawing.Point(92, 242);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(74, 27);
            this.signUpBtn.TabIndex = 12;
            this.signUpBtn.Text = "Sign-Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoEllipsis = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(92, 288);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(74, 27);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoS_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(295, 452);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.confirmPwdLbl);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.signUpLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.Label confirmPwdLbl;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button backBtn;
    }
}