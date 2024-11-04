namespace AdminBookingManagement
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userLabel = new System.Windows.Forms.Label();
            this.AdminTitle = new System.Windows.Forms.Label();
            this.LogOutButton = new Guna.UI2.WinForms.Guna2Button();
            this.AdminTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.DashboardForm = new DashboardForm();
            this.DashboardPanel = new System.Windows.Forms.TabPage();
            this.LoginPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoginForm = new LoginForm();
            this.BookingPanel = new System.Windows.Forms.TabPage();
            this.BookingForm = new BookingForm();
            this.FacilityPanel = new System.Windows.Forms.TabPage();
            this.FacilityForm = new FacilityForm();
            this.MiscellaneousPanel = new System.Windows.Forms.TabPage();
            this.MiscellaneousForm = new MiscellaneousForm();
            this.UserPanel = new System.Windows.Forms.TabPage();
            this.UserForm = new UserForm();
            this.tableLayoutPanel1.SuspendLayout();
            this.AdminTabControl.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.BookingPanel.SuspendLayout();
            this.FacilityPanel.SuspendLayout();
            this.MiscellaneousPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.65613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.343868F));
            this.tableLayoutPanel1.Controls.Add(this.userLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogOutButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(755, 18);
            this.userLabel.Margin = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(150, 23);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Logged in as Roberto";
            // 
            // adminTitle
            // 
            this.AdminTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AdminTitle.AutoSize = true;
            this.AdminTitle.Font = new System.Drawing.Font("Plus Jakarta Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTitle.ForeColor = System.Drawing.Color.White;
            this.AdminTitle.Location = new System.Drawing.Point(30, 16);
            this.AdminTitle.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.AdminTitle.Name = "adminTitle";
            this.AdminTitle.Size = new System.Drawing.Size(106, 27);
            this.AdminTitle.TabIndex = 0;
            this.AdminTitle.Text = "Admin Panel";
            // 
            // LogOutButton
            // 
            this.LogOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogOutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Image = global::AdminBookingManagement.Properties.Resources.door_open;
            this.LogOutButton.Location = new System.Drawing.Point(925, 3);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(53, 54);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.AdminTabControl.Controls.Add(this.DashboardPanel);
            this.AdminTabControl.Controls.Add(this.BookingPanel);
            this.AdminTabControl.Controls.Add(this.FacilityPanel);
            this.AdminTabControl.Controls.Add(this.MiscellaneousPanel);
            this.AdminTabControl.Controls.Add(this.UserPanel);
            this.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTabControl.ItemSize = new System.Drawing.Size(80, 80);
            this.AdminTabControl.Location = new System.Drawing.Point(0, 59);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(981, 439);
            this.AdminTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.AdminTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.AdminTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.AdminTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.AdminTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.AdminTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.AdminTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AdminTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(79)))));
            this.AdminTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AdminTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.AdminTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(104)))), ((int)(((byte)(134)))));
            this.AdminTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.AdminTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.AdminTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.Empty;
            this.AdminTabControl.TabButtonSize = new System.Drawing.Size(80, 80);
            this.AdminTabControl.TabIndex = 2;
            this.AdminTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AdminTabControl.SelectedIndexChanged += new System.EventHandler(this.AdminTabControl_SelectedIndexChanged);
            //
            // DashboardForm
            //
            this.DashboardForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardForm.Location = new System.Drawing.Point(3, 3);
            this.DashboardForm.Name = "DashboardForm";
            this.DashboardForm.Size = new System.Drawing.Size(887, 425);
            this.DashboardForm.TabIndex = 0;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.DashboardPanel.Controls.Add(this.LoginPanel);
            this.DashboardPanel.Controls.Add(this.DashboardForm);
            this.DashboardPanel.Location = new System.Drawing.Point(84, 4);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardPanel.Size = new System.Drawing.Size(893, 431);
            this.DashboardPanel.TabIndex = 0;
            this.DashboardPanel.Text = "Home";
            // 
            // LoginPanel
            // 
            this.LoginPanel.ColumnCount = 3;
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.87381F));
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25239F));
            this.LoginPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.87381F));
            this.LoginPanel.Controls.Add(this.LoginForm, 1, 1);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(3, 3);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.RowCount = 3;
            this.LoginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.176471F));
            this.LoginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.LoginPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.82353F));
            this.LoginPanel.Size = new System.Drawing.Size(887, 425);
            this.LoginPanel.TabIndex = 1;
            // 
            // loginForm1
            // 
            this.LoginForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginForm.BackColor = System.Drawing.Color.Transparent;
            this.LoginForm.Location = new System.Drawing.Point(223, 42);
            this.LoginForm.Name = "loginForm1";
            this.LoginForm.Size = new System.Drawing.Size(439, 300);
            this.LoginForm.TabIndex = 1;
            // 
            // BookingPanel
            // 
            this.BookingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.BookingPanel.Controls.Add(this.BookingForm);
            this.BookingPanel.Location = new System.Drawing.Point(84, 4);
            this.BookingPanel.Name = "BookingPanel";
            this.BookingPanel.Padding = new System.Windows.Forms.Padding(3);
            this.BookingPanel.Size = new System.Drawing.Size(893, 431);
            this.BookingPanel.TabIndex = 1;
            this.BookingPanel.Text = "Bookings";
            // 
            // BookingForm
            // 
            this.BookingForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingForm.Location = new System.Drawing.Point(3, 3);
            this.BookingForm.Name = "BookingForm";
            this.BookingForm.Size = new System.Drawing.Size(887, 425);
            this.BookingForm.TabIndex = 0;
            // 
            // FacilityPanel
            // 
            this.FacilityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.FacilityPanel.Controls.Add(this.FacilityForm);
            this.FacilityPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FacilityPanel.Location = new System.Drawing.Point(84, 4);
            this.FacilityPanel.Name = "FacilityPanel";
            this.FacilityPanel.Padding = new System.Windows.Forms.Padding(3);
            this.FacilityPanel.Size = new System.Drawing.Size(893, 431);
            this.FacilityPanel.TabIndex = 2;
            this.FacilityPanel.Text = "Facility Panel";
            // 
            // facilityForm
            // 
            this.FacilityForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacilityForm.Location = new System.Drawing.Point(3, 3);
            this.FacilityForm.Name = "facilityForm";
            this.FacilityForm.Size = new System.Drawing.Size(887, 425);
            this.FacilityForm.TabIndex = 0;
            // 
            // MiscellaneousPanel
            // 
            this.MiscellaneousPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.MiscellaneousPanel.Controls.Add(this.MiscellaneousForm);
            this.MiscellaneousPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MiscellaneousPanel.Location = new System.Drawing.Point(84, 4);
            this.MiscellaneousPanel.Name = "Miscellaneous Panel";
            this.MiscellaneousPanel.Padding = new System.Windows.Forms.Padding(3);
            this.MiscellaneousPanel.Size = new System.Drawing.Size(893, 431);
            this.MiscellaneousPanel.TabIndex = 3;
            this.MiscellaneousPanel.Text = "Miscellaneous";
            // 
            // miscellaneousForm1
            // 
            this.MiscellaneousForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscellaneousForm.Location = new System.Drawing.Point(3, 3);
            this.MiscellaneousForm.Name = "miscellaneousForm1";
            this.MiscellaneousForm.Size = new System.Drawing.Size(887, 425);
            this.MiscellaneousForm.TabIndex = 0;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.UserPanel.Controls.Add(this.UserForm);
            this.UserPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UserPanel.Location = new System.Drawing.Point(84, 4);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Padding = new System.Windows.Forms.Padding(3);
            this.UserPanel.Size = new System.Drawing.Size(893, 431);
            this.UserPanel.TabIndex = 4;
            this.UserPanel.Text = "UserPanel";
            // 
            // UserForm
            // 
            this.UserForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserForm.Location = new System.Drawing.Point(3, 3);
            this.UserForm.Margin = new System.Windows.Forms.Padding(2);
            this.UserForm.Name = "UserForm";
            this.UserForm.Size = new System.Drawing.Size(887, 425);
            this.UserForm.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 498);
            this.Controls.Add(this.AdminTabControl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminForm";
            this.Text = "Admin Booking Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.AdminTabControl.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.BookingPanel.ResumeLayout(false);
            this.FacilityPanel.ResumeLayout(false);
            this.MiscellaneousPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TabControl AdminTabControl;
        private System.Windows.Forms.TabPage DashboardPanel;
        private System.Windows.Forms.TabPage BookingPanel;
        private System.Windows.Forms.TabPage FacilityPanel;
        private System.Windows.Forms.TabPage MiscellaneousPanel;
        private System.Windows.Forms.Label AdminTitle;
        private System.Windows.Forms.TableLayoutPanel LoginPanel;
        private LoginForm LoginForm;
        private System.Windows.Forms.Label userLabel;
        private DashboardForm DashboardForm;
        private BookingForm BookingForm;
        private System.Windows.Forms.TabPage UserPanel;
        private FacilityForm FacilityForm;
        private MiscellaneousForm MiscellaneousForm;
        private UserForm UserForm;
        private Guna.UI2.WinForms.Guna2Button LogOutButton;
    }
}

