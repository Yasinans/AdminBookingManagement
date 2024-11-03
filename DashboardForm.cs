using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AdminBookingManagement
{
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
            RefreshData();
        }

        public void Show()
        {
            base.Show();
            RefreshData();
        }

        public void RefreshData()
        {
            //For Pending Panel
            AdminBookingManagement.BookingDetailMV.LoadBookingDetails();
            int pendingAmount = AdminBookingManagement.BookingDetailMV.BookingDetails.FindAll(e => e.Status.Equals("Pending")).Count;
            pendingAmountLabel.Text = pendingAmount.ToString();
            RecentBookingDataGridView.DataSource = AdminBookingManagement.BookingDetailMV.BookingDetails.OrderByDescending(e => e.Id).ToList();

            //For Chart
            totalBookingChart.Series.Clear();
            var facilityCounts = AdminBookingManagement.BookingDetailMV.GetBookingCountByFacility();
            var series = new Series("Bookings")
            {
                ChartType = SeriesChartType.Pie,
                Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F),
            };
            foreach (var kvp in facilityCounts)
            {
                series.Points.AddXY($"Facility {kvp.Key}", kvp.Value);
            }
            totalBookingChart.Series.Add(series);

            foreach (DataPoint point in series.Points)
            {
                point.Label = $"{point.AxisLabel}: {point.YValues[0]}";

            }
        }
    }
}
