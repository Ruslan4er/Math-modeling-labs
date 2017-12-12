namespace Lab_4
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.button1 = new System.Windows.Forms.Button();
            this.FirstChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SecondChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Симуляция";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstChart
            // 
            chartArea1.Name = "ChartArea1";
            this.FirstChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.FirstChart.Legends.Add(legend1);
            this.FirstChart.Location = new System.Drawing.Point(124, 12);
            this.FirstChart.Name = "FirstChart";
            this.FirstChart.Size = new System.Drawing.Size(300, 300);
            this.FirstChart.TabIndex = 1;
            // 
            // SecondChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SecondChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SecondChart.Legends.Add(legend2);
            this.SecondChart.Location = new System.Drawing.Point(430, 12);
            this.SecondChart.Name = "SecondChart";
            this.SecondChart.Size = new System.Drawing.Size(300, 300);
            this.SecondChart.TabIndex = 2;
            this.SecondChart.Text = "chart2";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 245);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 39);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 321);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SecondChart);
            this.Controls.Add(this.FirstChart);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)(this.FirstChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart FirstChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SecondChart;
        private System.Windows.Forms.Button ExitButton;
    }
}