using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBookingManagement.Models
{
    internal class FacilityModel
    {
        public int Id { get; set; }
        public string FacilityName { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
