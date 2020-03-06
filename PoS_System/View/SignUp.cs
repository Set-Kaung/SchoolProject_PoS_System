using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoS_System.Services;


namespace PoS_System.View
{
    
    public partial class SignUp : Form
    {
        StaffService staffService = new StaffServiceImpl();
        public SignUp()
        {
            InitializeComponent();
        }

        public void clearTextBoxes() 
        {
            this.nameBox.Clear();
            this.passwordBox.Clear();
            this.confirmBox.Clear();
        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string password = passwordBox.Text;
            string confirmPassword = confirmBox.Text;
            if (name.Equals("") || password.Equals("") || confirmPassword.Equals(""))
            {
                MessageBox.Show("Please make sure username,passoword and confirm password fields are filled");
            }
            else if (!(confirmPassword.Equals(password))) 
            {
                MessageBox.Show("Please make sure password and confrim password fields are matched.");
            }
            else
            {
                staffService.addStaff(name, password,2L);
                MessageBox.Show("Sign Up successful!");
                clearTextBoxes();
                this.Dispose();

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
