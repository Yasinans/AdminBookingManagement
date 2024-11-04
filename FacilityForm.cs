using AdminBookingManagement.Models;
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
        private Image Image {  get; set; }
        public FacilityForm()
        {
            //NOTE: Perform deletion of all Booking details, if it has the same value as a deleted venueid 
            InitializeComponent();
        }

        public void RefreshData()
        {
            AdminBookingManagement.FacilityMV.LoadFacilities();
            FacilitiesDataGridView.DataSource = null;
            FacilitiesDataGridView.DataSource = AdminBookingManagement.FacilityMV.Facilities;
            addButton.Enabled = false;
            errorLabel.Visible = false;
            categoryNameInput.Text = "";
            facilityNameInput.Text = "";
            imagePreview.Image = null;

            //Delete last column (image) since we can't display images at the last column
            if (FacilitiesDataGridView.ColumnCount > 0)
            {
                FacilitiesDataGridView.Columns.RemoveAt(FacilitiesDataGridView.ColumnCount - 1);
            }
            FacilitiesDataGridView.ClearSelection();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Image = Image.FromFile(OpenFileDialog.FileName);
                imagePreview.Image = Image;
                addButton.Enabled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FacilityModel facility = new FacilityModel
            {
                FacilityName = facilityNameInput.Text,
                Category = categoryNameInput.Text,
                Image = ImageUtil.ImageToBase64(imagePreview.Image, System.Drawing.Imaging.ImageFormat.Jpeg),
            };
            AdminBookingManagement.FacilityMV.AddFacility(facility);
            RefreshData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (FacilitiesDataGridView.SelectedRows.Count <= 0) return;
            AdminBookingManagement.FacilityMV.UpdateFacilityById((int)FacilitiesDataGridView.SelectedRows[0].Cells[0].Value, 
                facilityNameInput.Text, categoryNameInput.Text, ImageUtil.ImageToBase64(Image, System.Drawing.Imaging.ImageFormat.Jpeg));
            RefreshData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FacilitiesDataGridView.SelectedRows.Count <= 0) return;
            AdminBookingManagement.FacilityMV.DeleteFacilityById((int)FacilitiesDataGridView.SelectedRows[0].Cells[0].Value);
            RefreshData();
        }

        private void ValidateEntry(object sender, EventArgs e)
        {
            if (AdminBookingManagement.FacilityMV.Facilities.Find(a => a.FacilityName.ToLower().Equals(facilityNameInput.Text.ToLower())) != null)
            {
                errorLabel.Visible = true;
                addButton.Enabled = false;
                if(FacilitiesDataGridView.SelectedRows.Count >= 1 
                    && !((string)FacilitiesDataGridView.SelectedRows[0].Cells[1].Value).ToLower().Equals(facilityNameInput.Text.ToLower()))
                {
                    updateButton.Enabled = false;
                }
                return;
            }
            errorLabel.Visible = false;
            if (facilityNameInput.Text.Equals("")) { addButton.Enabled = false; updateButton.Enabled = false; return; }
            if (categoryNameInput.Text.Equals("")) {addButton.Enabled = false; updateButton.Enabled = false;  return; }
            if (imagePreview.Image ==null) { addButton.Enabled = false; updateButton.Enabled = false; return; }
            //for update
            if (FacilitiesDataGridView.SelectedRows.Count <= 0) updateButton.Enabled = false;
            else updateButton.Enabled = true;
            addButton.Enabled = true;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FacilitiesDataGridView.SelectedRows.Count <= 0) return;
            FacilityModel facilityModel = AdminBookingManagement.FacilityMV.GetFacilityById((int)FacilitiesDataGridView.SelectedRows[0].Cells[0].Value);
            facilityNameInput.Text = facilityModel.FacilityName;
            categoryNameInput.Text = facilityModel.Category;
            updateButton.Enabled = true;
            Image = ImageUtil.Base64ToImage(facilityModel.Image);
            imagePreview.Image = Image;
        }
    }
 }
