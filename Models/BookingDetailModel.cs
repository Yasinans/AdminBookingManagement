﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBookingManagement.Models
{
    internal class BookingDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Occupation { get; set; }
        public string Purpose { get; set; }

        public string Recurrence { get; set; }
        public string AdditionalDetails { get; set; }
        public string Venue_Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Status { get; set; }
    }
}
