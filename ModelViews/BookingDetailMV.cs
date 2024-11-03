using AdminBookingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBookingManagement.ModelViews
{
    internal class BookingDetailMV : Database
    {
        public List<BookingDetailModel> BookingDetails { get; set; } = new List<BookingDetailModel>();

        public BookingDetailMV()
        {
            LoadBookingDetails();
        }

        public void DeleteBookingStatusById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "DELETE FROM BookingDetails WHERE id=@id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadBookingDetails();
            }
        }
        public void UpdateBookingStatusById(int id, string status)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "UPDATE BookingDetails SET status=@status WHERE id=@id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@status", status);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadBookingDetails();
            }
        }
        public void LoadBookingDetails()
        {
            BookingDetails.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT * FROM BookingDetails";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        BookingDetailModel bookingDetails = new BookingDetailModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            VenueId = reader.GetInt32(2),
                            Department = reader.GetString(3),
                            Occupation = reader.GetString(4),
                            Purpose = reader.GetString(5),
                            StartDate = reader.GetDateTime(6),
                            EndDate = reader.GetDateTime(7),
                            Recurrence = reader.GetString(8),
                            AdditionalDetails = reader.GetString(9),
                            Status = reader.GetString(10),
                        };
                        BookingDetails.Add(bookingDetails);
                    }
                    connection.Close();
                }
            }
        }

        public Dictionary<string, int> GetBookingCountByFacility()
        {
            Dictionary<string, int> BookingCountByFacility = new Dictionary<string, int>();
            FacilityMV facilityMV = AdminBookingManagement.FacilityMV;
            foreach (BookingDetailModel facility in AdminBookingManagement.BookingDetailMV.BookingDetails)
            {
                if (BookingCountByFacility.ContainsKey(facilityMV.GetFacilityNameById(facility.VenueId))) BookingCountByFacility[facilityMV.GetFacilityNameById(facility.VenueId)] += 1;
                else BookingCountByFacility[facilityMV.GetFacilityNameById(facility.VenueId)] = 1;
            }
            return BookingCountByFacility;
        }
    }
}
