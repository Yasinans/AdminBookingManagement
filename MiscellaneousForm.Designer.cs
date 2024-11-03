namespace AdminBookingManagement
{
    partial class MiscellaneousForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.facilityLabel = new System.Windows.Forms.Label();
            this.FilterPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.typeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.valueInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.secondBookingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.OptionsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.secondBookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.flowLayoutPanel1.Controls.Add(this.facilityLabel);
            this.flowLayoutPanel1.Controls.Add(this.FilterPanel);
            this.flowLayoutPanel1.Controls.Add(this.secondBookingPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(893, 431);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // facilityLabel
            // 
            this.facilityLabel.AutoSize = true;
            this.facilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.SetFlowBreak(this.facilityLabel, true);
            this.facilityLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.facilityLabel.Location = new System.Drawing.Point(20, 20);
            this.facilityLabel.Margin = new System.Windows.Forms.Padding(20, 20, 10, 15);
            this.facilityLabel.Name = "facilityLabel";
            this.facilityLabel.Size = new System.Drawing.Size(139, 29);
            this.facilityLabel.TabIndex = 2;
            this.facilityLabel.Text = "Miscellaneous";
            this.facilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilterPanel
            // 
            this.FilterPanel.BorderRadius = 10;
            this.FilterPanel.Controls.Add(this.deleteButton);
            this.FilterPanel.Controls.Add(this.typeComboBox);
            this.FilterPanel.Controls.Add(this.addButton);
            this.FilterPanel.Controls.Add(this.guna2VSeparator1);
            this.FilterPanel.Controls.Add(this.valueInput);
            this.FilterPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.FilterPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.FilterPanel.Location = new System.Drawing.Point(40, 67);
            this.FilterPanel.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(812, 60);
            this.FilterPanel.TabIndex = 9;
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
            this.deleteButton.Location = new System.Drawing.Point(721, 15);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 30);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.typeComboBox.BorderRadius = 6;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 9F, System.Drawing.FontStyle.Bold);
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typeComboBox.ItemHeight = 30;
            this.typeComboBox.Items.AddRange(new object[] {
            "Purpose",
            "Department"});
            this.typeComboBox.Location = new System.Drawing.Point(498, 13);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(119, 36);
            this.typeComboBox.StartIndex = 0;
            this.typeComboBox.TabIndex = 9;
            this.typeComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 3;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.Font = new System.Drawing.Font("Plus Jakarta Sans", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addButton.IndicateFocus = true;
            this.addButton.Location = new System.Drawing.Point(641, 15);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(71, 30);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Silver;
            this.guna2VSeparator1.Location = new System.Drawing.Point(625, 10);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 45);
            this.guna2VSeparator1.TabIndex = 3;
            // 
            // valueInput
            // 
            this.valueInput.BackColor = System.Drawing.Color.Transparent;
            this.valueInput.BorderRadius = 3;
            this.valueInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valueInput.DefaultText = "";
            this.valueInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.valueInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.valueInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.valueInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.valueInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.valueInput.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.valueInput.Location = new System.Drawing.Point(349, 15);
            this.valueInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueInput.Name = "valueInput";
            this.valueInput.PasswordChar = '\0';
            this.valueInput.PlaceholderText = "Value";
            this.valueInput.SelectedText = "";
            this.valueInput.Size = new System.Drawing.Size(143, 30);
            this.valueInput.TabIndex = 2;
            // 
            // secondBookingPanel
            // 
            this.secondBookingPanel.BorderRadius = 10;
            this.secondBookingPanel.Controls.Add(this.OptionsDataGridView);
            this.secondBookingPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.secondBookingPanel.Location = new System.Drawing.Point(40, 140);
            this.secondBookingPanel.Margin = new System.Windows.Forms.Padding(40, 10, 3, 3);
            this.secondBookingPanel.Name = "secondBookingPanel";
            this.secondBookingPanel.Padding = new System.Windows.Forms.Padding(6);
            this.secondBookingPanel.Size = new System.Drawing.Size(812, 261);
            this.secondBookingPanel.TabIndex = 8;
            // 
            // OptionsDataGridView
            // 
            this.OptionsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OptionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OptionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OptionsDataGridView.ColumnHeadersHeight = 21;
            this.OptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OptionsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.OptionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OptionsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.OptionsDataGridView.MultiSelect = false;
            this.OptionsDataGridView.Name = "OptionsDataGridView";
            this.OptionsDataGridView.ReadOnly = true;
            this.OptionsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OptionsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OptionsDataGridView.RowHeadersVisible = false;
            this.OptionsDataGridView.Size = new System.Drawing.Size(800, 249);
            this.OptionsDataGridView.TabIndex = 3;
            this.OptionsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OptionsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OptionsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OptionsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OptionsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OptionsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OptionsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OptionsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OptionsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OptionsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OptionsDataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.OptionsDataGridView.ThemeStyle.ReadOnly = true;
            this.OptionsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OptionsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OptionsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OptionsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.OptionsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OptionsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MiscellaneousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MiscellaneousForm";
            this.Size = new System.Drawing.Size(893, 431);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FilterPanel.ResumeLayout(false);
            this.secondBookingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OptionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label facilityLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel FilterPanel;
        private Guna.UI2.WinForms.Guna2ComboBox typeComboBox;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2TextBox valueInput;
        private Guna.UI2.WinForms.Guna2Panel secondBookingPanel;
        private Guna.UI2.WinForms.Guna2DataGridView OptionsDataGridView;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
    }
}
