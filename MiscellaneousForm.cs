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
    public partial class MiscellaneousForm : UserControl
    {
        public MiscellaneousForm()
        {
            InitializeComponent();
            RefreshData();
        }

        public void Show()
        {
            base.Show();
            RefreshData();
        }

        private void RefreshData()
        {
            OptionsDataGridView.DataSource = null;
            OptionsDataGridView.DataSource = AdminBookingManagement.OptionMV.Options;
            valueInput.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(valueInput.Text.Length==0) return;
            AdminBookingManagement.OptionMV.AddOption(new Models.OptionModel
            {
                Value = valueInput.Text,
                Type = typeComboBox.SelectedItem.ToString(),
            });
            RefreshData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(OptionsDataGridView.SelectedRows.Count==0) return;
            AdminBookingManagement.OptionMV.DeleteOptionById((int)OptionsDataGridView.SelectedRows[0].Cells[0].Value);
            RefreshData();
        }
    }
}
