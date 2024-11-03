using AdminBookingManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBookingManagement
{
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (AdminBookingManagement.UserMV.Users.Find(u => u.Username == usernameInput.Text) != null &&
                AdminBookingManagement.UserMV.Users.Find(u => u.Password == passwordInput.Text) != null)
            {
                errorLabel.Visible = false;
                AdminBookingManagement.AdminForm.AuthenticateUser(AdminBookingManagement.UserMV.Users.Find(u => u.Username == usernameInput.Text));
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}
