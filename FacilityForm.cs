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
    public partial class FacilityForm : UserControl
    {
        public FacilityForm()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            AdminBookingManagement.FacilityMV.LoadFacilities();
            FacilitiesDataGridView.DataSource = AdminBookingManagement.FacilityMV.Facilities;
        }
    }
 }
