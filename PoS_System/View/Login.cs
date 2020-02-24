using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS_System.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string password = passwordBox.Text;
            //string userPassword = "admin123";

            if(name.Equals("admin")) 
            {
                this.Hide();
                FirstPage firstPage = new FirstPage();
                firstPage.ShowDialog();
                if (firstPage.IsDisposed) 
                {
                    this.Show();
                }

                

               

            }
            else 
            {
                MessageBox.Show("username or password is wrong");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
