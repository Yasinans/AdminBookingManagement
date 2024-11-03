namespace AdminBookingManagement
{
    partial class BookingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.secondBookingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ControlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BookingsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.actionPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.approveButton = new Guna.UI2.WinForms.Guna2Button();
            this.declineButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.bookingLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FilterPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.statusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.nameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.facilitiesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.secondBookingPanel.SuspendLayout();
            this.ControlLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingsDataGridView)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // secondBookingPanel
            // 
            this.secondBookingPanel.BorderRadius = 10;
            this.secondBookingPanel.Controls.Add(this.ControlLayoutPanel);
            this.secondBookingPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.secondBookingPanel.Location = new System.Drawing.Point(40, 140);
            this.secondBookingPanel.Margin = new System.Windows.Forms.Padding(40, 10, 3, 3);
            this.secondBookingPanel.Name = "secondBookingPanel";
            this.secondBookingPanel.Size = new System.Drawing.Size(812, 261);
            this.secondBookingPanel.TabIndex = 4;
            // 
            // ControlLayoutPanel
            // 
            this.ControlLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlLayoutPanel.ColumnCount = 1;
            this.ControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.26601F));
            this.ControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.73399F));
            this.ControlLayoutPanel.Controls.Add(this.BookingsDataGridView, 0, 1);
            this.ControlLayoutPanel.Controls.Add(this.actionPanel, 0, 0);
            this.ControlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlLayoutPanel.Name = "ControlLayoutPanel";
            this.ControlLayoutPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ControlLayoutPanel.RowCount = 2;
            this.ControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97753F));
            this.ControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.02247F));
            this.ControlLayoutPanel.Size = new System.Drawing.Size(812, 261);
            this.ControlLayoutPanel.TabIndex = 0;
            // 
            // BookingsDataGridView
            // 
            this.BookingsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.BookingsDataGridView.ColumnHeadersHeight = 21;
            this.BookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingsDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.BookingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingsDataGridView.Location = new System.Drawing.Point(6, 51);
            this.BookingsDataGridView.MultiSelect = false;
            this.BookingsDataGridView.Name = "BookingsDataGridView";
            this.BookingsDataGridView.ReadOnly = true;
            this.BookingsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.BookingsDataGridView.RowHeadersVisible = false;
            this.BookingsDataGridView.Size = new System.Drawing.Size(800, 204);
            this.BookingsDataGridView.TabIndex = 2;
            this.BookingsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BookingsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BookingsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BookingsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookingsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookingsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookingsDataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.BookingsDataGridView.ThemeStyle.ReadOnly = true;
            this.BookingsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.BookingsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.approveButton);
            this.actionPanel.Controls.Add(this.declineButton);
            this.actionPanel.Controls.Add(this.deleteButton);
            this.actionPanel.CustomBorderColor = System.Drawing.Color.Gray;
            this.actionPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.Location = new System.Drawing.Point(3, 3);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(806, 45);
            this.actionPanel.TabIndex = 3;
            // 
            // approveButton
            // 
            this.approveButton.Animated = true;
            this.approveButton.BorderRadius = 3;
            this.approveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.approveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.approveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.approveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.approveButton.Font = new System.Drawing.Font("Plus Jakarta Sans", 8F, System.Drawing.FontStyle.Bold);
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.approveButton.IndicateFocus = true;
            this.approveButton.Location = new System.Drawing.Point(535, 11);
            this.approveButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(84, 25);
            this.approveButton.TabIndex = 6;
            this.approveButton.Text = "Approve";
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.Animated = true;
            this.declineButton.BorderRadius = 3;
            this.declineButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.declineButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.declineButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.declineButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.declineButton.Font = new System.Drawing.Font("Plus Jakarta Sans", 8F, System.Drawing.FontStyle.Bold);
            this.declineButton.ForeColor = System.Drawing.Color.White;
            this.declineButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.declineButton.IndicateFocus = true;
            this.declineButton.Location = new System.Drawing.Point(633, 11);
            this.declineButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(84, 25);
            this.declineButton.TabIndex = 5;
            this.declineButton.Text = "Decline";
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.BorderRadius = 3;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.Font = new System.Drawing.Font("Plus Jakarta Sans", 8F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteButton.IndicateFocus = true;
            this.deleteButton.Location = new System.Drawing.Point(731, 11);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(65, 25);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // bookingLabel
            // 
            this.bookingLabel.AutoSize = true;
            this.bookingLabel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.SetFlowBreak(this.bookingLabel, true);
            this.bookingLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.bookingLabel.Location = new System.Drawing.Point(20, 20);
            this.bookingLabel.Margin = new System.Windows.Forms.Padding(20, 20, 10, 15);
            this.bookingLabel.Name = "bookingLabel";
            this.bookingLabel.Size = new System.Drawing.Size(206, 29);
            this.bookingLabel.TabIndex = 2;
            this.bookingLabel.Text = "Booking Management";
            this.bookingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.flowLayoutPanel1.Controls.Add(this.bookingLabel);
            this.flowLayoutPanel1.Controls.Add(this.FilterPanel);
            this.flowLayoutPanel1.Controls.Add(this.secondBookingPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(893, 431);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FilterPanel
            // 
            this.FilterPanel.BorderRadius = 10;
            this.FilterPanel.Controls.Add(this.resetButton);
            this.FilterPanel.Controls.Add(this.statusComboBox);
            this.FilterPanel.Controls.Add(this.searchButton);
            this.FilterPanel.Controls.Add(this.guna2VSeparator1);
            this.FilterPanel.Controls.Add(this.nameInput);
            this.FilterPanel.Controls.Add(this.facilitiesComboBox);
            this.FilterPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.FilterPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.FilterPanel.Location = new System.Drawing.Point(40, 67);
            this.FilterPanel.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(812, 60);
            this.FilterPanel.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Animated = true;
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.BorderRadius = 3;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.LightSalmon;
            this.resetButton.Font = new System.Drawing.Font("Plus Jakarta Sans", 8F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resetButton.IndicateFocus = true;
            this.resetButton.Location = new System.Drawing.Point(721, 15);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(71, 30);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.statusComboBox.BorderRadius = 6;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 9F, System.Drawing.FontStyle.Bold);
            this.statusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusComboBox.ItemHeight = 30;
            this.statusComboBox.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Declined"});
            this.statusComboBox.Location = new System.Drawing.Point(308, 11);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(119, 36);
            this.statusComboBox.StartIndex = 0;
            this.statusComboBox.TabIndex = 9;
            this.statusComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // searchButton
            // 
            this.searchButton.Animated = true;
            this.searchButton.BorderRadius = 3;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.CadetBlue;
            this.searchButton.Font = new System.Drawing.Font("Plus Jakarta Sans", 8F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchButton.IndicateFocus = true;
            this.searchButton.Location = new System.Drawing.Point(641, 15);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(71, 30);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Silver;
            this.guna2VSeparator1.Location = new System.Drawing.Point(428, 7);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 45);
            this.guna2VSeparator1.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.Transparent;
            this.nameInput.BorderRadius = 3;
            this.nameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInput.DefaultText = "";
            this.nameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.Location = new System.Drawing.Point(444, 15);
            this.nameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderText = "Search by Name";
            this.nameInput.SelectedText = "";
            this.nameInput.Size = new System.Drawing.Size(186, 30);
            this.nameInput.TabIndex = 2;
            // 
            // facilitiesComboBox
            // 
            this.facilitiesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.facilitiesComboBox.BorderRadius = 6;
            this.facilitiesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.facilitiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facilitiesComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facilitiesComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.facilitiesComboBox.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 9F, System.Drawing.FontStyle.Bold);
            this.facilitiesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.facilitiesComboBox.ItemHeight = 30;
            this.facilitiesComboBox.Items.AddRange(new object[] {
            "All Facilities"});
            this.facilitiesComboBox.Location = new System.Drawing.Point(175, 11);
            this.facilitiesComboBox.Name = "facilitiesComboBox";
            this.facilitiesComboBox.Size = new System.Drawing.Size(127, 36);
            this.facilitiesComboBox.StartIndex = 0;
            this.facilitiesComboBox.TabIndex = 1;
            this.facilitiesComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BookingForm";
            this.Size = new System.Drawing.Size(893, 431);
            this.secondBookingPanel.ResumeLayout(false);
            this.ControlLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookingsDataGridView)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel secondBookingPanel;
        private System.Windows.Forms.TableLayoutPanel ControlLayoutPanel;
        private System.Windows.Forms.Label bookingLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel FilterPanel;
        private Guna.UI2.WinForms.Guna2DataGridView BookingsDataGridView;
        private Guna.UI2.WinForms.Guna2Panel actionPanel;
        private Guna.UI2.WinForms.Guna2Button declineButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button approveButton;
        private Guna.UI2.WinForms.Guna2TextBox nameInput;
        private Guna.UI2.WinForms.Guna2ComboBox facilitiesComboBox;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ComboBox statusComboBox;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button resetButton;
    }
}
