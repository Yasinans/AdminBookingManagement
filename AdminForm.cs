using System.Windows.Forms;
using AdminBookingManagement.Models;
using Guna.UI2.WinForms;

namespace AdminBookingManagement
{
    public partial class AdminForm : Form
    {
        UserModel currentUser;
        public AdminForm()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            //currentUser = new User("Admin", "Password");

            InitializeComponent();
            ShowUnauthenticatedView();
        }

        public void AuthenticateUser(UserModel user)
        {
            currentUser = user;
            AdminTabControl.TabMenuVisible = true;
            userLabel.Text = "Logged in as " + currentUser.Username;
            userLabel.Show();
            DashboardForm.Show();
            LoginPanel.Hide();
            LogOutButton.Show();
            BookingForm.Show();
        }
        private void ShowUnauthenticatedView()
        {
            AdminTabControl.SelectedIndex = 0;
            AdminTabControl.TabMenuVisible = false;
            userLabel.Hide();
            DashboardForm.Hide();
            LogOutButton.Hide();
            LoginPanel.Show();
        }
        private void AdminTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (currentUser == null)
            {
                AdminTabControl.SelectedIndex = 0;
                return;
            }

            if (AdminTabControl.SelectedIndex == 0) {
                DashboardForm.RefreshData();
            }
            else if (AdminTabControl.SelectedIndex == 1){ 
                facilityForm.RefreshData();
            }
        }

        private void LogoutButton_Click(object sender, System.EventArgs e)
        {
            ShowUnauthenticatedView();
            this.currentUser = null;
        }
    }
}
