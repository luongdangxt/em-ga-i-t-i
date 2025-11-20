namespace ASM1_DATABASE
{
    partial class Statistics_Report_Screen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport_Excel = new System.Windows.Forms.Button();
            this.TopEmployee = new System.Windows.Forms.Label();
            this.RevenueChart = new System.Windows.Forms.Label();
            this.DateRange = new System.Windows.Forms.Label();
            this.txtSeachCustomer = new System.Windows.Forms.TextBox();
            this.By = new System.Windows.Forms.Label();
            this.StatisticsManagement = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(239, 143);
            this.dataGridView1.TabIndex = 95;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(656, 398);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 40);
            this.btnRefresh.TabIndex = 92;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExport_Excel
            // 
            this.btnExport_Excel.Location = new System.Drawing.Point(494, 398);
            this.btnExport_Excel.Name = "btnExport_Excel";
            this.btnExport_Excel.Size = new System.Drawing.Size(75, 40);
            this.btnExport_Excel.TabIndex = 91;
            this.btnExport_Excel.Text = "Export Excel";
            this.btnExport_Excel.UseVisualStyleBackColor = true;
            // 
            // TopEmployee
            // 
            this.TopEmployee.AutoSize = true;
            this.TopEmployee.Location = new System.Drawing.Point(135, 296);
            this.TopEmployee.Name = "TopEmployee";
            this.TopEmployee.Size = new System.Drawing.Size(97, 16);
            this.TopEmployee.TabIndex = 86;
            this.TopEmployee.Text = "Top Employee";
            // 
            // RevenueChart
            // 
            this.RevenueChart.AutoSize = true;
            this.RevenueChart.Location = new System.Drawing.Point(148, 156);
            this.RevenueChart.Name = "RevenueChart";
            this.RevenueChart.Size = new System.Drawing.Size(96, 16);
            this.RevenueChart.TabIndex = 85;
            this.RevenueChart.Text = "Revenue Chart";
            // 
            // DateRange
            // 
            this.DateRange.AutoSize = true;
            this.DateRange.Location = new System.Drawing.Point(148, 109);
            this.DateRange.Name = "DateRange";
            this.DateRange.Size = new System.Drawing.Size(80, 16);
            this.DateRange.TabIndex = 84;
            this.DateRange.Text = "Date Range";
            // 
            // txtSeachCustomer
            // 
            this.txtSeachCustomer.Location = new System.Drawing.Point(186, 70);
            this.txtSeachCustomer.Name = "txtSeachCustomer";
            this.txtSeachCustomer.Size = new System.Drawing.Size(195, 22);
            this.txtSeachCustomer.TabIndex = 83;
            // 
            // By
            // 
            this.By.AutoSize = true;
            this.By.Location = new System.Drawing.Point(148, 76);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(23, 16);
            this.By.TabIndex = 82;
            this.By.Text = "By";
            // 
            // StatisticsManagement
            // 
            this.StatisticsManagement.AutoSize = true;
            this.StatisticsManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsManagement.Location = new System.Drawing.Point(243, 20);
            this.StatisticsManagement.Name = "StatisticsManagement";
            this.StatisticsManagement.Size = new System.Drawing.Size(289, 31);
            this.StatisticsManagement.TabIndex = 75;
            this.StatisticsManagement.Text = "Statistics Management";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(488, 91);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 96;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(238, 296);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 97);
            this.listView1.TabIndex = 97;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 98;
            // 
            // Statistics_Report_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExport_Excel);
            this.Controls.Add(this.TopEmployee);
            this.Controls.Add(this.RevenueChart);
            this.Controls.Add(this.DateRange);
            this.Controls.Add(this.txtSeachCustomer);
            this.Controls.Add(this.By);
            this.Controls.Add(this.StatisticsManagement);
            this.Name = "Statistics_Report_Screen";
            this.Text = "Statistics_Report_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport_Excel;
        private System.Windows.Forms.Label TopEmployee;
        private System.Windows.Forms.Label RevenueChart;
        private System.Windows.Forms.Label DateRange;
        private System.Windows.Forms.TextBox txtSeachCustomer;
        private System.Windows.Forms.Label By;
        private System.Windows.Forms.Label StatisticsManagement;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}