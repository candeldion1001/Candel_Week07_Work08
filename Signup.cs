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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtUsername.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            foreach (var u in Users.UserList)
            {
                if (u.Username == txtUsername.Text)
                {
                    MessageBox.Show("Username is already taken.");
                    return;
                }
            }

            Users newUser = new Users()
            {
                FullName = txtName.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            Users.UserList.Add(newUser);

            MessageBox.Show("Signup successful! You can now log in.");

            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
