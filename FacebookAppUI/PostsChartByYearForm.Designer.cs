
﻿namespace BasicFacebookFeatures

{
    partial class PostsChartByYearForm
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
            this.text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.text.Location = new System.Drawing.Point(62, -31);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(620, 20);
            this.text.TabIndex = 8;
            this.text.Text = "The chart displays for each months the numbers of comments that all the post rece" +
    "ived";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, -68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // commentsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.commentsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.commentsChart.Legends.Add(legend1);
            this.commentsChart.Location = new System.Drawing.Point(-23, 98);
            this.commentsChart.Name = "commentsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Posts";
            this.commentsChart.Series.Add(series1);
            this.commentsChart.Size = new System.Drawing.Size(1068, 497);
            this.commentsChart.TabIndex = 6;
            this.commentsChart.Text = "chart1";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.message.Location = new System.Drawing.Point(231, 20);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(427, 40);
            this.message.TabIndex = 9;
            this.message.Text = "The chart displays the number of posts the user has posted\r\nper year";
            // 
            // PostsChartByYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(993, 587);
            this.Controls.Add(this.message);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentsChart);
            this.Name = "PostsChartByYear";
            this.Text = "PostChartByYear";
            ((System.ComponentModel.ISupportInitialize)(this.commentsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart commentsChart;
        private System.Windows.Forms.Label message;
    }
}