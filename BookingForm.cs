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
    public partial class BookingForm : UserControl
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            facilitiesComboBox.Items.Clear();
            facilitiesComboBox.Items.Add("All Facilities");
            facilitiesComboBox.SelectedIndex = 0;
            facilitiesComboBox.Items.AddRange(AdminBookingManagement.FacilityMV.Facilities.Select(e=>e.FacilityName).ToArray());
            BookingsDataGridView.DataSource = null;
            BookingsDataGridView.DataSource = GetBookingDetailsByFilter();
            BookingsDataGridView.ClearSelection();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = 0;
            facilitiesComboBox.SelectedIndex = 0;
            nameInput.Text = "";
        }


        private List<BookingDetailModel> GetBookingDetailsByFilter()
        {
            List<BookingDetailModel> filteredBookingDetails = new List<BookingDetailModel> ();
            foreach (BookingDetailModel bookingDetail in AdminBookingManagement.BookingDetailMV.BookingDetails)
            {
                bool nameMatched = bookingDetail.Name.ToLower().Contains(nameInput.Text.ToLower());
                bool isAllStatus = statusComboBox.SelectedIndex == 0;
                bool isAllFacility = facilitiesComboBox.SelectedIndex == 0;
                if (!nameMatched) continue;
                if(isAllStatus && isAllFacility)
                {
                    filteredBookingDetails.Add(bookingDetail);
                }
                else if (isAllStatus && 
                    bookingDetail.Venue_Name.Equals((string)facilitiesComboBox.SelectedItem))
                {
                    filteredBookingDetails.Add(bookingDetail);
                }
                else if (isAllFacility && bookingDetail.Status.Equals(statusComboBox.SelectedItem.ToString()))
                {
                    filteredBookingDetails.Add(bookingDetail);
                } else if (bookingDetail.Venue_Name.Equals((string)facilitiesComboBox.SelectedItem)
                    && bookingDetail.Status.Equals(statusComboBox.SelectedItem.ToString())) {
                    filteredBookingDetails.Add(bookingDetail);
                }
            }
            return filteredBookingDetails;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            BookingsDataGridView.DataSource = GetBookingDetailsByFilter();
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            if(BookingsDataGridView.SelectedRows.Count == 0) { return; }
            AdminBookingManagement.BookingDetailMV.UpdateBookingStatusById((int)BookingsDataGridView.SelectedRows[0].Cells[0].Value, "Approved");
            BookingsDataGridView.DataSource = GetBookingDetailsByFilter();
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            if (BookingsDataGridView.SelectedRows.Count == 0) { return; }
            AdminBookingManagement.BookingDetailMV.UpdateBookingStatusById((int)BookingsDataGridView.SelectedRows[0].Cells[0].Value, "Declined");
            BookingsDataGridView.DataSource = GetBookingDetailsByFilter();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (BookingsDataGridView.SelectedRows.Count == 0) { return; }
            AdminBookingManagement.BookingDetailMV.DeleteBookingStatusById((int)BookingsDataGridView.SelectedRows[0].Cells[0].Value);
            BookingsDataGridView.DataSource = GetBookingDetailsByFilter();
        }
    }
}
