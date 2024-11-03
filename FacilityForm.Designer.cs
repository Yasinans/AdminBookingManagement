namespace AdminBookingManagement
{
    partial class FacilityForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilityForm));
            this.secondBookingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.FacilitiesDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.chooseButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectImageLabel = new System.Windows.Forms.Label();
            this.ImagePreview = new Guna.UI2.WinForms.Guna2ImageButton();
            this.facilityNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.categoryNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.facilityLabel = new System.Windows.Forms.Label();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.secondBookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.FlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // secondBookingPanel
            // 
            this.secondBookingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.secondBookingPanel.BorderRadius = 10;
            this.secondBookingPanel.Controls.Add(this.FacilitiesDataGridView);
            this.secondBookingPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.secondBookingPanel.Location = new System.Drawing.Point(40, 171);
            this.secondBookingPanel.Margin = new System.Windows.Forms.Padding(40, 10, 3, 3);
            this.secondBookingPanel.Name = "secondBookingPanel";
            this.secondBookingPanel.Padding = new System.Windows.Forms.Padding(10);
            this.secondBookingPanel.Size = new System.Drawing.Size(812, 229);
            this.secondBookingPanel.TabIndex = 4;
            // 
            // FacilitiesDataGridView
            // 
            this.FacilitiesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FacilitiesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacilitiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FacilitiesDataGridView.ColumnHeadersHeight = 21;
            this.FacilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FacilitiesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FacilitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacilitiesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FacilitiesDataGridView.Location = new System.Drawing.Point(10, 10);
            this.FacilitiesDataGridView.Name = "FacilitiesDataGridView";
            this.FacilitiesDataGridView.ReadOnly = true;
            this.FacilitiesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacilitiesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FacilitiesDataGridView.RowHeadersVisible = false;
            this.FacilitiesDataGridView.Size = new System.Drawing.Size(792, 209);
            this.FacilitiesDataGridView.TabIndex = 1;
            this.FacilitiesDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FacilitiesDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilitiesDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FacilitiesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FacilitiesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FacilitiesDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FacilitiesDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FacilitiesDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FacilitiesDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FacilitiesDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilitiesDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FacilitiesDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FacilitiesDataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.FacilitiesDataGridView.ThemeStyle.ReadOnly = true;
            this.FacilitiesDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FacilitiesDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FacilitiesDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilitiesDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FacilitiesDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.FacilitiesDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FacilitiesDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.BorderRadius = 10;
            this.guna2GradientPanel1.Controls.Add(this.updateButton);
            this.guna2GradientPanel1.Controls.Add(this.deleteButton);
            this.guna2GradientPanel1.Controls.Add(this.guna2VSeparator1);
            this.guna2GradientPanel1.Controls.Add(this.addButton);
            this.guna2GradientPanel1.Controls.Add(this.chooseButton);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.selectImageLabel);
            this.guna2GradientPanel1.Controls.Add(this.ImagePreview);
            this.guna2GradientPanel1.Controls.Add(this.facilityNameInput);
            this.guna2GradientPanel1.Controls.Add(this.categoryNameInput);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.FlowLayoutPanel.SetFlowBreak(this.guna2GradientPanel1, true);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(40, 67);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(812, 91);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Animated = true;
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 5;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.IndicateFocus = true;
            this.updateButton.Location = new System.Drawing.Point(672, 17);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(122, 27);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Selected";
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 5;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.IndicateFocus = true;
            this.deleteButton.Location = new System.Drawing.Point(672, 48);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 27);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete Selected";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Gray;
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(572, -12);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 120);
            this.guna2VSeparator1.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 5;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.IndicateFocus = true;
            this.addButton.Location = new System.Drawing.Point(591, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 59);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            // 
            // chooseButton
            // 
            this.chooseButton.Animated = true;
            this.chooseButton.BackColor = System.Drawing.Color.Transparent;
            this.chooseButton.BorderRadius = 5;
            this.chooseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chooseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chooseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chooseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chooseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chooseButton.ForeColor = System.Drawing.Color.White;
            this.chooseButton.IndicateFocus = true;
            this.chooseButton.Location = new System.Drawing.Point(358, 38);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(93, 27);
            this.chooseButton.TabIndex = 10;
            this.chooseButton.Text = "Choose";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Facility Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectImageLabel
            // 
            this.selectImageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectImageLabel.AutoSize = true;
            this.selectImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectImageLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImageLabel.Location = new System.Drawing.Point(361, 17);
            this.selectImageLabel.Name = "selectImageLabel";
            this.selectImageLabel.Size = new System.Drawing.Size(81, 18);
            this.selectImageLabel.TabIndex = 5;
            this.selectImageLabel.Text = "Select Image:";
            this.selectImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImagePreview
            // 
            this.ImagePreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImagePreview.BackColor = System.Drawing.Color.DimGray;
            this.ImagePreview.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImagePreview.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImagePreview.Image = ((System.Drawing.Image)(resources.GetObject("ImagePreview.Image")));
            this.ImagePreview.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImagePreview.ImageRotate = 0F;
            this.ImagePreview.IndicateFocus = true;
            this.ImagePreview.Location = new System.Drawing.Point(469, 17);
            this.ImagePreview.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImagePreview.Size = new System.Drawing.Size(84, 58);
            this.ImagePreview.TabIndex = 4;
            // 
            // facilityNameInput
            // 
            this.facilityNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.facilityNameInput.Animated = true;
            this.facilityNameInput.BackColor = System.Drawing.Color.Transparent;
            this.facilityNameInput.BorderRadius = 6;
            this.facilityNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.facilityNameInput.DefaultText = "";
            this.facilityNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.facilityNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.facilityNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.facilityNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.facilityNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facilityNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.facilityNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facilityNameInput.Location = new System.Drawing.Point(33, 36);
            this.facilityNameInput.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.facilityNameInput.Name = "facilityNameInput";
            this.facilityNameInput.PasswordChar = '\0';
            this.facilityNameInput.PlaceholderText = "Facility Name";
            this.facilityNameInput.SelectedText = "";
            this.facilityNameInput.Size = new System.Drawing.Size(162, 29);
            this.facilityNameInput.TabIndex = 6;
            // 
            // categoryNameInput
            // 
            this.categoryNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoryNameInput.Animated = true;
            this.categoryNameInput.BorderRadius = 6;
            this.categoryNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryNameInput.DefaultText = "";
            this.categoryNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameInput.Location = new System.Drawing.Point(218, 36);
            this.categoryNameInput.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.categoryNameInput.Name = "categoryNameInput";
            this.categoryNameInput.PasswordChar = '\0';
            this.categoryNameInput.PlaceholderText = "Category";
            this.categoryNameInput.SelectedText = "";
            this.categoryNameInput.Size = new System.Drawing.Size(124, 29);
            this.categoryNameInput.TabIndex = 7;
            // 
            // facilityLabel
            // 
            this.facilityLabel.AutoSize = true;
            this.facilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel.SetFlowBreak(this.facilityLabel, true);
            this.facilityLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.facilityLabel.Location = new System.Drawing.Point(20, 20);
            this.facilityLabel.Margin = new System.Windows.Forms.Padding(20, 20, 10, 15);
            this.facilityLabel.Name = "facilityLabel";
            this.facilityLabel.Size = new System.Drawing.Size(196, 29);
            this.facilityLabel.TabIndex = 2;
            this.facilityLabel.Text = "Facility Management";
            this.facilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.FlowLayoutPanel.Controls.Add(this.facilityLabel);
            this.FlowLayoutPanel.Controls.Add(this.guna2GradientPanel1);
            this.FlowLayoutPanel.Controls.Add(this.secondBookingPanel);
            this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(893, 431);
            this.FlowLayoutPanel.TabIndex = 2;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // FacilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowLayoutPanel);
            this.Name = "FacilityForm";
            this.Size = new System.Drawing.Size(893, 431);
            this.secondBookingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.FlowLayoutPanel.ResumeLayout(false);
            this.FlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel secondBookingPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Label facilityLabel;
        private System.Windows.Forms.Label selectImageLabel;
        private Guna.UI2.WinForms.Guna2ImageButton ImagePreview;
        private Guna.UI2.WinForms.Guna2TextBox facilityNameInput;
        private Guna.UI2.WinForms.Guna2TextBox categoryNameInput;
        private Guna.UI2.WinForms.Guna2Button chooseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2DataGridView FacilitiesDataGridView;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}
