using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdminBookingManagement.ModelViews
{
    public abstract class Database
    {
        private readonly string connectionString;

        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public string ConnectionString() { return connectionString; }
    }
}
