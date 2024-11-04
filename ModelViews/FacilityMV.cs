using AdminBookingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdminBookingManagement.ModelViews
{
    internal class FacilityMV : Database
    {
        public List<FacilityModel> Facilities { get; set; } = new List<FacilityModel>();

        public FacilityMV()
        {
            LoadFacilities();
        }

        public void AddFacility(FacilityModel facility)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "INSERT INTO Facilities(facility_name, category, image) " +
                    "VALUES(@facility_name, @category, @image)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@facility_name", facility.FacilityName);
                    command.Parameters.AddWithValue("@category", facility.Category);
                    command.Parameters.AddWithValue("@image", facility.Image);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadFacilities();
            }
        }
        public FacilityModel GetFacilityByName(string name)
        {
            LoadFacilities();
            foreach (FacilityModel facility in Facilities)
            {
                if (facility.FacilityName.ToLower().Equals(name.ToLower())) return facility;
            }
            return null;
        }
        public FacilityModel GetFacilityById(int id)
        {
            LoadFacilities();
            foreach(FacilityModel facility in Facilities)
            {
                if (facility.Id == id) return facility;
            }
            return null;
        }

        public void UpdateFacilityById(int id, string facilityName, string category, string image)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                //Workaround to fix GDI+ error :(
                string query = "";
                if (image == null)
                {
                    query = "UPDATE Facilities SET facility_name=@facility_name, category=@category WHERE id=@id";
                }
                else
                {
                    query = "UPDATE Facilities SET facility_name=@facility_name, category=@category, image=@image WHERE id=@id";
                }
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@facility_name", facilityName);
                    command.Parameters.AddWithValue("@category", category);
                    if(image!=null) command.Parameters.AddWithValue("@image", image);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadFacilities();
            }
        }

        public void DeleteFacilityById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "DELETE FROM Facilities WHERE id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                //Perform deletion of Booking Details that has the ID, since the Facility is already non-existent.
                query = "DELETE FROM BookingDetails WHERE venue_id = @venue_id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@venue_id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                AdminBookingManagement.BookingDetailMV.LoadBookingDetails();
                LoadFacilities();
            }

        }

        public void LoadFacilities()
        {
            Facilities.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT id, facility_name, category, image FROM Facilities";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        FacilityModel facility = new FacilityModel
                        {
                            Id = reader.GetInt32(0),
                            FacilityName = reader.GetString(1),
                            Category = reader.GetString(2),
                            Image = reader.GetString(3),
                        };
                        Facilities.Add(facility);
                    }
                    connection.Close();
                }
            }
        }



        public string GetFacilityNameById(int id)
        {
            LoadFacilities();
            foreach (FacilityModel facility in Facilities)
            {
                if (facility.Id == id)
                {
                    return facility.FacilityName;
                }
            }
            return null;
        }

    }
}
