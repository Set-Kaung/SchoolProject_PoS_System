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
    
    public partial class Login : Form
    {
        StaffService staffService = new StaffServiceImpl();
        private long role;
        public Login()
        {
            InitializeComponent();
        }
        public void clearTextBoxes() 
        {
            this.nameBox.Clear();
            this.passwordBox.Clear();
        }

       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string password = passwordBox.Text;
            

            if(staffService.isValid(name,password)) 
            {
                this.role = staffService.getRole();
                switch (role)
                {
                    case 1:
                        {
                            {
                                this.Hide();
                                FirstPage firstPage = new FirstPage();
                                firstPage.ShowDialog();
                                clearTextBoxes();
                                if (firstPage.IsDisposed)
                                {
                                    this.Show();
                                }
                                break;
                            }
                        }
                    case 2: 
                        {
                            {
                                this.Hide();
                                CashierModule cashierModule = new CashierModule();
                                cashierModule.ShowDialog();
                                clearTextBoxes();
                                if (cashierModule.IsDisposed)
                                {
                                    this.Show();
                                }
                            }
                            break;
                        }
                }
            }
            else 
            {
                MessageBox.Show("Username or Password is invalid.");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            if (signUp.IsDisposed) 
            {
                this.Show();
            }
        }
    }
}
