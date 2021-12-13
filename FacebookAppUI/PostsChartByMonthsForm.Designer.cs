
﻿namespace BasicFacebookFeatures
{
    partial class PostsChartByMonthsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.commentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // commentsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.commentsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.commentsChart.Legends.Add(legend2);
            this.commentsChart.Location = new System.Drawing.Point(-30, 99);
            this.commentsChart.Name = "commentsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Posts";
            this.commentsChart.Series.Add(series2);
            this.commentsChart.Size = new System.Drawing.Size(1068, 497);
            this.commentsChart.TabIndex = 3;
            this.commentsChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.text.Location = new System.Drawing.Point(166, 46);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(511, 40);
            this.text.TabIndex = 5;
            this.text.Text = "The chart displays the number of posts the user has posted per months\r\n\r\n";
            // 
            // PostsChartByMonths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(993, 587);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentsChart);
            this.Name = "PostsChartByMonths";
            this.Text = "PostChartByMonths";
            ((System.ComponentModel.ISupportInitialize)(this.commentsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart commentsChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text;
    }
}