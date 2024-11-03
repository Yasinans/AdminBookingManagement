using AdminBookingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBookingManagement.ModelViews
{
    internal class OptionMV : Database
    {
        public List<OptionModel> Options { get; set; } = new List<OptionModel>();
        public OptionMV()
        {
            LoadOptions();
        }

        public void AddOption(OptionModel option)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "INSERT INTO Options(type, value) " +
                    "VALUES(@type, @value)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@type", option.Type);
                    command.Parameters.AddWithValue("@value", option.Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadOptions();
            }
        }

        public void DeleteOptionById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "DELETE FROM Options WHERE id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadOptions();
            }

        }
        public void LoadOptions()
        {
            Options.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT id, type, value FROM Options";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        OptionModel purpose = new OptionModel
                        {
                            Id = reader.GetInt32(0),
                            Type = reader.GetString(1),
                            Value = reader.GetString(2),
                        };
                        Options.Add(purpose);
                    }
                    connection.Close();
                }
            }
        }

    

    }
}
