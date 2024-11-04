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
        }

        public void RefreshData()
        {
            AdminBookingManagement.UserMV.LoadUsers();
            UsersDataGridView.DataSource = null;
            UsersDataGridView.DataSource = AdminBookingManagement.UserMV.Users;
            usernameInput.Text = "";
            passwordInput.Text = "";
            if (UsersDataGridView.ColumnCount > 0)
            {
                UsersDataGridView.Columns.RemoveAt(UsersDataGridView.ColumnCount - 1);
            }
            UsersDataGridView.ClearSelection();
        }

        private void ValidateEntry(object sender, EventArgs e)
        {
            if (AdminBookingManagement.UserMV.Users.Find(a => a.Username.ToLower().Equals(usernameInput.Text.ToLower())) != null)
            {
                errorLabel.Visible = true;
                addButton.Enabled = false;
                if (UsersDataGridView.SelectedRows.Count >= 1
                    && !((string)UsersDataGridView.SelectedRows[0].Cells[1].Value).ToLower().Equals(usernameInput.Text.ToLower()))
                {
                    updateButton.Enabled = false;
                }
                return;
            }
            errorLabel.Visible = false;
            if (usernameInput.Text.Equals("")) { addButton.Enabled = false; updateButton.Enabled = false; return; }
            if (passwordInput.Text.Length <= 0) { addButton.Enabled = false; updateButton.Enabled = false; return; }
            //for update
            if (UsersDataGridView.SelectedRows.Count <= 0) updateButton.Enabled = false;
            else updateButton.Enabled = true;
            addButton.Enabled = true;
        }
        private void AddButton_Click(object sender, EventArgs e)
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }
            AdminBookingManagement.UserMV.UpdateUserById((int)UsersDataGridView.SelectedRows[0].Cells[0].Value, usernameInput.Text, passwordInput.Text);
            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }
            AdminBookingManagement.UserMV.DeleteUserById((int)UsersDataGridView.SelectedRows[0].Cells[0].Value);
            RefreshData();
        }

        private void UsersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count <= 0) return;
            usernameInput.Text = (string) UsersDataGridView.SelectedRows[0].Cells[1].Value;
            updateButton.Enabled = true;
        }
    }
}
