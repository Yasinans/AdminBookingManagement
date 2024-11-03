namespace AdminBookingManagement
{
    partial class LoginForm
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
            this.adminTitle = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.signInButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTitle
            // 
            this.adminTitle.BackColor = System.Drawing.Color.Transparent;
            this.adminTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminTitle.Font = new System.Drawing.Font("Plus Jakarta Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.adminTitle.Location = new System.Drawing.Point(0, 0);
            this.adminTitle.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(458, 36);
            this.adminTitle.TabIndex = 1;
            this.adminTitle.Text = "Admin Panel";
            this.adminTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 7;
            this.guna2GradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 36);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(458, 284);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.passwordInput, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameInput, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.signInButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.37349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.62651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 284);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.Transparent;
            this.passwordInput.BorderRadius = 10;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            this.passwordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordInput.Location = new System.Drawing.Point(50, 156);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(50, 4, 50, 4);
            this.passwordInput.MaxLength = 30;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.PlaceholderText = "";
            this.passwordInput.SelectedText = "";
            this.passwordInput.Size = new System.Drawing.Size(358, 38);
            this.passwordInput.TabIndex = 7;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.passwordLabel.Location = new System.Drawing.Point(50, 118);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(405, 34);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.usernameLabel.Location = new System.Drawing.Point(50, 35);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(405, 36);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.Transparent;
            this.usernameInput.BorderRadius = 10;
            this.usernameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameInput.DefaultText = "";
            this.usernameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.usernameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameInput.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            this.usernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.usernameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameInput.Location = new System.Drawing.Point(50, 74);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.usernameInput.MaxLength = 30;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.PasswordChar = '\0';
            this.usernameInput.PlaceholderText = "";
            this.usernameInput.SelectedText = "";
            this.usernameInput.Size = new System.Drawing.Size(358, 36);
            this.usernameInput.TabIndex = 5;
            // 
            // signInButton
            // 
            this.signInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.signInButton.Animated = true;
            this.signInButton.AutoRoundedCorners = true;
            this.signInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.signInButton.BorderRadius = 21;
            this.signInButton.BorderThickness = 1;
            this.signInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.signInButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.signInButton.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 10F, System.Drawing.FontStyle.Bold);
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.signInButton.Location = new System.Drawing.Point(150, 223);
            this.signInButton.Margin = new System.Windows.Forms.Padding(150, 3, 150, 3);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(158, 45);
            this.signInButton.TabIndex = 8;
            this.signInButton.Text = "Sign in";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLabel.Location = new System.Drawing.Point(3, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.errorLabel.Size = new System.Drawing.Size(452, 25);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Incorrect Username or Password";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.adminTitle);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(458, 320);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label adminTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameInput;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private System.Windows.Forms.Label passwordLabel;
        private Guna.UI2.WinForms.Guna2GradientButton signInButton;
        private System.Windows.Forms.Label errorLabel;
    }
}
