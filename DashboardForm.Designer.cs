namespace AdminBookingManagement
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DashboardSplitContainer = new System.Windows.Forms.SplitContainer();
            this.firstDashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.totalBookingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.secondDashboardPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pendingLabel = new System.Windows.Forms.Label();
            this.pendingAmountLabel = new System.Windows.Forms.Label();
            this.adminTitle = new System.Windows.Forms.Label();
            this.thirdDashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.RecentBookingDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardSplitContainer)).BeginInit();
            this.DashboardSplitContainer.Panel1.SuspendLayout();
            this.DashboardSplitContainer.Panel2.SuspendLayout();
            this.DashboardSplitContainer.SuspendLayout();
            this.firstDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalBookingChart)).BeginInit();
            this.secondDashboardPanel.SuspendLayout();
            this.thirdDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecentBookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.DashboardSplitContainer);
            this.flowLayoutPanel1.Controls.Add(this.adminTitle);
            this.flowLayoutPanel1.Controls.Add(this.thirdDashboardPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(893, 431);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.SetFlowBreak(this.label1, true);
            this.label1.Font = new System.Drawing.Font("Plus Jakarta Sans", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardSplitContainer
            // 
            this.DashboardSplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.DashboardSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardSplitContainer.IsSplitterFixed = true;
            this.DashboardSplitContainer.Location = new System.Drawing.Point(40, 67);
            this.DashboardSplitContainer.Margin = new System.Windows.Forms.Padding(40, 3, 3, 10);
            this.DashboardSplitContainer.Name = "DashboardSplitContainer";
            // 
            // DashboardSplitContainer.Panel1
            // 
            this.DashboardSplitContainer.Panel1.Controls.Add(this.firstDashboardPanel);
            this.DashboardSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // DashboardSplitContainer.Panel2
            // 
            this.DashboardSplitContainer.Panel2.Controls.Add(this.secondDashboardPanel);
            this.DashboardSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardSplitContainer.Size = new System.Drawing.Size(812, 140);
            this.DashboardSplitContainer.SplitterDistance = 580;
            this.DashboardSplitContainer.SplitterWidth = 3;
            this.DashboardSplitContainer.TabIndex = 3;
            // 
            // firstDashboardPanel
            // 
            this.firstDashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.firstDashboardPanel.BorderRadius = 10;
            this.firstDashboardPanel.Controls.Add(this.label2);
            this.firstDashboardPanel.Controls.Add(this.totalBookingChart);
            this.firstDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstDashboardPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.firstDashboardPanel.Location = new System.Drawing.Point(3, 3);
            this.firstDashboardPanel.Name = "firstDashboardPanel";
            this.firstDashboardPanel.Padding = new System.Windows.Forms.Padding(5);
            this.firstDashboardPanel.ShadowDecoration.BorderRadius = 10;
            this.firstDashboardPanel.ShadowDecoration.Enabled = true;
            this.firstDashboardPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.firstDashboardPanel.Size = new System.Drawing.Size(574, 134);
            this.firstDashboardPanel.TabIndex = 0;
            // 
            // totalBookingChart
            // 
            chartArea4.Name = "ChartArea1";
            this.totalBookingChart.ChartAreas.Add(chartArea4);
            this.totalBookingChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.totalBookingChart.Legends.Add(legend4);
            this.totalBookingChart.Location = new System.Drawing.Point(5, 5);
            this.totalBookingChart.Name = "totalBookingChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            series4.Legend = "Legend1";
            series4.Name = "Bookings";
            this.totalBookingChart.Series.Add(series4);
            this.totalBookingChart.Size = new System.Drawing.Size(564, 124);
            this.totalBookingChart.TabIndex = 0;
            this.totalBookingChart.Text = "chart1";
            // 
            // secondDashboardPanel
            // 
            this.secondDashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.secondDashboardPanel.BorderRadius = 10;
            this.secondDashboardPanel.Controls.Add(this.pendingLabel);
            this.secondDashboardPanel.Controls.Add(this.pendingAmountLabel);
            this.secondDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondDashboardPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.secondDashboardPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.secondDashboardPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.secondDashboardPanel.Location = new System.Drawing.Point(3, 3);
            this.secondDashboardPanel.Name = "secondDashboardPanel";
            this.secondDashboardPanel.Padding = new System.Windows.Forms.Padding(10);
            this.secondDashboardPanel.ShadowDecoration.BorderRadius = 10;
            this.secondDashboardPanel.ShadowDecoration.Enabled = true;
            this.secondDashboardPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.secondDashboardPanel.Size = new System.Drawing.Size(223, 134);
            this.secondDashboardPanel.TabIndex = 0;
            // 
            // pendingLabel
            // 
            this.pendingLabel.AutoSize = true;
            this.pendingLabel.BackColor = System.Drawing.Color.Transparent;
            this.pendingLabel.Font = new System.Drawing.Font("Plus Jakarta Sans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pendingLabel.Location = new System.Drawing.Point(10, 21);
            this.pendingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pendingLabel.Name = "pendingLabel";
            this.pendingLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pendingLabel.Size = new System.Drawing.Size(121, 20);
            this.pendingLabel.TabIndex = 6;
            this.pendingLabel.Text = "Pending Approval";
            this.pendingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pendingAmountLabel
            // 
            this.pendingAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.pendingAmountLabel.Font = new System.Drawing.Font("Plus Jakarta Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pendingAmountLabel.Location = new System.Drawing.Point(10, 32);
            this.pendingAmountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pendingAmountLabel.Name = "pendingAmountLabel";
            this.pendingAmountLabel.Size = new System.Drawing.Size(79, 53);
            this.pendingAmountLabel.TabIndex = 7;
            this.pendingAmountLabel.Text = "24";
            this.pendingAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adminTitle
            // 
            this.adminTitle.AutoSize = true;
            this.adminTitle.BackColor = System.Drawing.Color.Transparent;
            this.adminTitle.Font = new System.Drawing.Font("Plus Jakarta Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.adminTitle.Location = new System.Drawing.Point(40, 217);
            this.adminTitle.Margin = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(107, 20);
            this.adminTitle.TabIndex = 2;
            this.adminTitle.Text = "Recent Bookings";
            this.adminTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // thirdDashboardPanel
            // 
            this.thirdDashboardPanel.BorderRadius = 10;
            this.thirdDashboardPanel.Controls.Add(this.RecentBookingDataGridView);
            this.thirdDashboardPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.thirdDashboardPanel.Location = new System.Drawing.Point(40, 247);
            this.thirdDashboardPanel.Margin = new System.Windows.Forms.Padding(40, 10, 3, 3);
            this.thirdDashboardPanel.Name = "thirdDashboardPanel";
            this.thirdDashboardPanel.Padding = new System.Windows.Forms.Padding(10);
            this.thirdDashboardPanel.Size = new System.Drawing.Size(812, 155);
            this.thirdDashboardPanel.TabIndex = 4;
            // 
            // RecentBookingDataGridView
            // 
            this.RecentBookingDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RecentBookingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecentBookingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.RecentBookingDataGridView.ColumnHeadersHeight = 21;
            this.RecentBookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecentBookingDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.RecentBookingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentBookingDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RecentBookingDataGridView.Location = new System.Drawing.Point(10, 10);
            this.RecentBookingDataGridView.Name = "RecentBookingDataGridView";
            this.RecentBookingDataGridView.ReadOnly = true;
            this.RecentBookingDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Plus Jakarta Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecentBookingDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.RecentBookingDataGridView.RowHeadersVisible = false;
            this.RecentBookingDataGridView.Size = new System.Drawing.Size(792, 135);
            this.RecentBookingDataGridView.TabIndex = 0;
            this.RecentBookingDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RecentBookingDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentBookingDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RecentBookingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RecentBookingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RecentBookingDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RecentBookingDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RecentBookingDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RecentBookingDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RecentBookingDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentBookingDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RecentBookingDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RecentBookingDataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.RecentBookingDataGridView.ThemeStyle.ReadOnly = true;
            this.RecentBookingDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RecentBookingDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RecentBookingDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentBookingDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RecentBookingDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.RecentBookingDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RecentBookingDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Plus Jakarta Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(398, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Bookings By Facility";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DashboardForm";
            this.Size = new System.Drawing.Size(893, 431);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.DashboardSplitContainer.Panel1.ResumeLayout(false);
            this.DashboardSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardSplitContainer)).EndInit();
            this.DashboardSplitContainer.ResumeLayout(false);
            this.firstDashboardPanel.ResumeLayout(false);
            this.firstDashboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalBookingChart)).EndInit();
            this.secondDashboardPanel.ResumeLayout(false);
            this.secondDashboardPanel.PerformLayout();
            this.thirdDashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecentBookingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.SplitContainer DashboardSplitContainer;
        private Guna.UI2.WinForms.Guna2Panel thirdDashboardPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel secondDashboardPanel;
        private System.Windows.Forms.Label pendingAmountLabel;
        private System.Windows.Forms.Label pendingLabel;
        private Guna.UI2.WinForms.Guna2Panel firstDashboardPanel;
        private Guna.UI2.WinForms.Guna2DataGridView RecentBookingDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart totalBookingChart;
        private System.Windows.Forms.Label label2;
    }
}
