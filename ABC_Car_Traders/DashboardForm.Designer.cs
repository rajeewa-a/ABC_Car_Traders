
namespace ABC_Car_Traders
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btn_cars = new System.Windows.Forms.Button();
            this.btn_parts = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime_from = new System.Windows.Forms.DateTimePicker();
            this.datetime_to = new System.Windows.Forms.DateTimePicker();
            this.chart_revenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_rev2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_car = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_part = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_rev2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_part)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cars
            // 
            this.btn_cars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btn_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cars.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars.ForeColor = System.Drawing.Color.White;
            this.btn_cars.Location = new System.Drawing.Point(701, 344);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(200, 48);
            this.btn_cars.TabIndex = 1;
            this.btn_cars.Text = "Generate Car Report...";
            this.btn_cars.UseVisualStyleBackColor = false;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // btn_parts
            // 
            this.btn_parts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btn_parts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parts.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parts.ForeColor = System.Drawing.Color.White;
            this.btn_parts.Location = new System.Drawing.Point(701, 413);
            this.btn_parts.Name = "btn_parts";
            this.btn_parts.Size = new System.Drawing.Size(200, 48);
            this.btn_parts.TabIndex = 2;
            this.btn_parts.Text = "Generate Car Part Report...";
            this.btn_parts.UseVisualStyleBackColor = false;
            this.btn_parts.Click += new System.EventHandler(this.btn_parts_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.Location = new System.Drawing.Point(698, 207);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(200, 48);
            this.btn_sales.TabIndex = 3;
            this.btn_sales.Text = "Generate Sales Report";
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(701, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sales";
            // 
            // datetime_from
            // 
            this.datetime_from.Location = new System.Drawing.Point(698, 118);
            this.datetime_from.Name = "datetime_from";
            this.datetime_from.Size = new System.Drawing.Size(200, 20);
            this.datetime_from.TabIndex = 6;
            this.datetime_from.ValueChanged += new System.EventHandler(this.datetime_from_ValueChanged);
            // 
            // datetime_to
            // 
            this.datetime_to.Location = new System.Drawing.Point(698, 166);
            this.datetime_to.Name = "datetime_to";
            this.datetime_to.Size = new System.Drawing.Size(203, 20);
            this.datetime_to.TabIndex = 7;
            // 
            // chart_revenue
            // 
            chartArea1.AxisX.Title = "Month";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Rs. (Millions)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart_revenue.ChartAreas.Add(chartArea1);
            this.chart_revenue.Location = new System.Drawing.Point(26, 57);
            this.chart_revenue.Name = "chart_revenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chart_revenue.Series.Add(series1);
            this.chart_revenue.Size = new System.Drawing.Size(300, 217);
            this.chart_revenue.TabIndex = 8;
            this.chart_revenue.Text = "chart1";
            this.chart_revenue.Click += new System.EventHandler(this.chart_revenue_Click);
            // 
            // chart_rev2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_rev2.ChartAreas.Add(chartArea2);
            this.chart_rev2.Location = new System.Drawing.Point(355, 57);
            this.chart_rev2.Name = "chart_rev2";
            this.chart_rev2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_rev2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(78)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Revenue";
            this.chart_rev2.Series.Add(series2);
            this.chart_rev2.Size = new System.Drawing.Size(300, 217);
            this.chart_rev2.TabIndex = 9;
            this.chart_rev2.Text = "chart2";
            this.chart_rev2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart_car
            // 
            chartArea3.AxisX.Title = "Month";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.Title = "Rs. (Millions)";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.Name = "ChartArea1";
            this.chart_car.ChartAreas.Add(chartArea3);
            this.chart_car.Location = new System.Drawing.Point(26, 293);
            this.chart_car.Name = "chart_car";
            series3.ChartArea = "ChartArea1";
            series3.Name = "carsales";
            this.chart_car.Series.Add(series3);
            this.chart_car.Size = new System.Drawing.Size(300, 250);
            this.chart_car.TabIndex = 10;
            this.chart_car.Text = "chart3";
            title1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Car Sales";
            title1.Text = "Car Sales";
            this.chart_car.Titles.Add(title1);
            // 
            // chart_part
            // 
            chartArea4.AxisX.Title = "Month";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.Title = "Rs. (Millions)";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.Name = "ChartArea1";
            this.chart_part.ChartAreas.Add(chartArea4);
            this.chart_part.Location = new System.Drawing.Point(355, 293);
            this.chart_part.Name = "chart_part";
            series4.ChartArea = "ChartArea1";
            series4.Name = "carpartsales";
            this.chart_part.Series.Add(series4);
            this.chart_part.Size = new System.Drawing.Size(300, 250);
            this.chart_part.TabIndex = 11;
            this.chart_part.Text = "chart4";
            title2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Car Part Sales";
            this.chart_part.Titles.Add(title2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Monthly Revenue";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_part);
            this.Controls.Add(this.chart_car);
            this.Controls.Add(this.chart_rev2);
            this.Controls.Add(this.chart_revenue);
            this.Controls.Add(this.datetime_to);
            this.Controls.Add(this.datetime_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_parts);
            this.Controls.Add(this.btn_cars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_rev2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_part)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btn_parts;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetime_from;
        private System.Windows.Forms.DateTimePicker datetime_to;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_rev2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_car;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_part;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}