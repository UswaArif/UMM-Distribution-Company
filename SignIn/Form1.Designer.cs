
namespace SignIn
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.BubbleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backbtn = new System.Windows.Forms.Button();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.productDLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BubbleChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BubbleChart
            // 
            this.BubbleChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.BubbleChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BubbleChart.Legends.Add(legend1);
            this.BubbleChart.Location = new System.Drawing.Point(741, 432);
            this.BubbleChart.Margin = new System.Windows.Forms.Padding(6);
            this.BubbleChart.Name = "BubbleChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Legend = "Legend1";
            series1.Name = "sales";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.YValuesPerPoint = 2;
            this.BubbleChart.Series.Add(series1);
            this.BubbleChart.Size = new System.Drawing.Size(615, 366);
            this.BubbleChart.TabIndex = 9;
            this.BubbleChart.Text = "BubbleChart";
            // 
            // PieChart
            // 
            this.PieChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(81, 432);
            this.PieChart.Margin = new System.Windows.Forms.Padding(6);
            this.PieChart.Name = "PieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "sales";
            this.PieChart.Series.Add(series2);
            this.PieChart.Size = new System.Drawing.Size(615, 366);
            this.PieChart.TabIndex = 8;
            this.PieChart.Text = "PieChart";
            // 
            // LineChart
            // 
            this.LineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.LineChart.Legends.Add(legend3);
            this.LineChart.Location = new System.Drawing.Point(741, 54);
            this.LineChart.Margin = new System.Windows.Forms.Padding(6);
            this.LineChart.Name = "LineChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "sales";
            this.LineChart.Series.Add(series3);
            this.LineChart.Size = new System.Drawing.Size(615, 366);
            this.LineChart.TabIndex = 7;
            this.LineChart.Text = "LineChart";
            this.LineChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // backbtn
            // 
            this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backbtn.Location = new System.Drawing.Point(1409, 774);
            this.backbtn.Margin = new System.Windows.Forms.Padding(6);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(249, 72);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "backbtn";
            this.backbtn.UseVisualStyleBackColor = true;
            // 
            // BarChart
            // 
            this.BarChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea4);
            this.BarChart.DataSource = this.productDLBindingSource;
            legend4.Name = "Legend1";
            this.BarChart.Legends.Add(legend4);
            this.BarChart.Location = new System.Drawing.Point(81, 54);
            this.BarChart.Margin = new System.Windows.Forms.Padding(6);
            this.BarChart.Name = "BarChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "sales";
            this.BarChart.Series.Add(series4);
            this.BarChart.Size = new System.Drawing.Size(615, 366);
            this.BarChart.TabIndex = 5;
            this.BarChart.Text = "BarChart";
            title1.Name = "Product/Month";
            this.BarChart.Titles.Add(title1);
            // 
            // productDLBindingSource
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 936);
            this.Controls.Add(this.BubbleChart);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.LineChart);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.BarChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BubbleChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BubbleChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.BindingSource productDLBindingSource;
    }
}

