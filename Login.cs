using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candel_Week07_Work08
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            bool isAuthenticated = false;

            foreach (var u in Users.UserList)
            {
                if (u.Username == txtUsername.Text && u.Password == txtPassword.Text)
                {
                    isAuthenticated = true;
                    break;
                }
            }

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!");

                Inventory dashboard = new Inventory();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup signUp = new Signup();

            signUp.Show();
            this.Hide();
        }
    }
}
