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
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
            RefreshData();
        }

        public void Show()
        {
            base.Show();
            RefreshData();
        }

        private void RefreshData()
        {
            UsersDataGridView.DataSource = null;
            UsersDataGridView.DataSource = AdminBookingManagement.UserMV.Users;
            usernameInput.Text = "";
            passwordInput.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(AdminBookingManagement.UserMV.Users.FindAll(user=>user.Username.Equals(usernameInput.Text)).Count > 0)
            {
                return;
            }
            AdminBookingManagement.UserMV.AddUser(new UserModel{
                Username=usernameInput.Text, 
                Password=passwordInput.Text
            });
            RefreshData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }
            AdminBookingManagement.UserMV.UpdateUserById((int)UsersDataGridView.SelectedRows[0].Cells[0].Value, usernameInput.Text, passwordInput.Text);
            RefreshData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }
            AdminBookingManagement.UserMV.DeleteUserById((int)UsersDataGridView.SelectedRows[0].Cells[0].Value);
            RefreshData();
        }
    }
}
