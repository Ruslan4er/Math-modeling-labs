namespace Lab_2
{
    partial class MainForm
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
        /// Required uniform for Designer support - do not modify
        /// the contents of this uniform with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GenerateSequenceButton = new System.Windows.Forms.Button();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DistributionFunctionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DensityDistributionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinValueTextBox = new System.Windows.Forms.TextBox();
            this.MaxValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistributionFunctionChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityDistributionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateSequenceButton
            // 
            this.GenerateSequenceButton.Location = new System.Drawing.Point(29, 77);
            this.GenerateSequenceButton.Name = "GenerateSequenceButton";
            this.GenerateSequenceButton.Size = new System.Drawing.Size(152, 45);
            this.GenerateSequenceButton.TabIndex = 0;
            this.GenerateSequenceButton.Text = "Генерировать случайную последовательность";
            this.GenerateSequenceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GenerateSequenceButton.UseVisualStyleBackColor = true;
            this.GenerateSequenceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultChart
            // 
            this.ResultChart.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            chartArea1.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ResultChart.Legends.Add(legend1);
            this.ResultChart.Location = new System.Drawing.Point(233, 12);
            this.ResultChart.Name = "ResultChart";
            this.ResultChart.Size = new System.Drawing.Size(473, 243);
            this.ResultChart.TabIndex = 1;
            // 
            // DistributionFunctionChart
            // 
            this.DistributionFunctionChart.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.DistributionFunctionChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DistributionFunctionChart.Legends.Add(legend2);
            this.DistributionFunctionChart.Location = new System.Drawing.Point(12, 261);
            this.DistributionFunctionChart.Name = "DistributionFunctionChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DistributionFunctionChart.Series.Add(series1);
            this.DistributionFunctionChart.Size = new System.Drawing.Size(339, 231);
            this.DistributionFunctionChart.TabIndex = 2;
            this.DistributionFunctionChart.Text = "Функция распределения";
            // 
            // DensityDistributionChart
            // 
            chartArea3.Name = "ChartArea1";
            this.DensityDistributionChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.DensityDistributionChart.Legends.Add(legend3);
            this.DensityDistributionChart.Location = new System.Drawing.Point(357, 261);
            this.DensityDistributionChart.Name = "DensityDistributionChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.DensityDistributionChart.Series.Add(series2);
            this.DensityDistributionChart.Size = new System.Drawing.Size(349, 231);
            this.DensityDistributionChart.TabIndex = 3;
            this.DensityDistributionChart.Text = "Плотность распределения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(93, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "до";
            // 
            // MinValueTextBox
            // 
            this.MinValueTextBox.Location = new System.Drawing.Point(41, 33);
            this.MinValueTextBox.Name = "MinValueTextBox";
            this.MinValueTextBox.Size = new System.Drawing.Size(46, 20);
            this.MinValueTextBox.TabIndex = 6;
            this.MinValueTextBox.Text = "0";
            // 
            // MaxValueTextBox
            // 
            this.MaxValueTextBox.Location = new System.Drawing.Point(118, 33);
            this.MaxValueTextBox.Name = "MaxValueTextBox";
            this.MaxValueTextBox.Size = new System.Drawing.Size(49, 20);
            this.MaxValueTextBox.TabIndex = 7;
            this.MaxValueTextBox.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "M=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "D=";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 563);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxValueTextBox);
            this.Controls.Add(this.MinValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DensityDistributionChart);
            this.Controls.Add(this.DistributionFunctionChart);
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.GenerateSequenceButton);
            this.Name = "MainForm";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistributionFunctionChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DensityDistributionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateSequenceButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DistributionFunctionChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DensityDistributionChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinValueTextBox;
        private System.Windows.Forms.TextBox MaxValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

