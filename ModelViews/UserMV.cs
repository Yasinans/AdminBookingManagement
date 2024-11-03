using AdminBookingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBookingManagement.ModelViews
{
    public class UserMV: Database
    {
        public List<UserModel> Users { get; set; } = new List<UserModel> ();

        public UserMV()
        {
            LoadUsers();
        }

        public void AddUser(UserModel user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "INSERT INTO Users(username, password) " +
                    "VALUES(@username, @password)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadUsers();
            }
        }

        public void UpdateUserById(int userId, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "UPDATE Users SET username=@username, password=@password WHERE id=@id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@id", userId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadUsers();
            }
        }

        public void DeleteUserById(int userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "DELETE FROM Users WHERE id = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadUsers();
            }

        }
        public void LoadUsers()
        {
            Users.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString()))
            {
                string query = "SELECT * FROM Users";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UserModel user = new UserModel
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),
                           
                        };
                        Users.Add(user);
                    }
                    connection.Close();
                }
            }
        }
    }
}
