using AdminBookingManagement.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminBookingManagement
{
    internal class AdminBookingManagement
    {
        public static FacilityMV FacilityMV { get; set; } = new FacilityMV();
        public static BookingDetailMV BookingDetailMV { get; set; } = new BookingDetailMV();
        public static OptionMV OptionMV { get; set; } = new OptionMV();
        public static UserMV UserMV { get; set; } = new UserMV();
        public static AdminForm AdminForm { get; set; }
    }
}
