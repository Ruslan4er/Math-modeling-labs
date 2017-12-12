namespace Lab_1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SecondMethodButton = new System.Windows.Forms.Button();
            this.FirstMethodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputX0TextBox = new System.Windows.Forms.TextBox();
            this.FirstMethodStartValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ThirdMethodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ThirdMethodButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdMethodChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SecondMethodButton
            // 
            this.SecondMethodButton.Location = new System.Drawing.Point(90, 247);
            this.SecondMethodButton.Name = "SecondMethodButton";
            this.SecondMethodButton.Size = new System.Drawing.Size(100, 23);
            this.SecondMethodButton.TabIndex = 0;
            this.SecondMethodButton.Text = "Генерировать";
            this.SecondMethodButton.UseVisualStyleBackColor = true;
            this.SecondMethodButton.Click += new System.EventHandler(this.SecondMethodButton_Click);
            // 
            // FirstMethodButton
            // 
            this.FirstMethodButton.Location = new System.Drawing.Point(94, 84);
            this.FirstMethodButton.Name = "FirstMethodButton";
            this.FirstMethodButton.Size = new System.Drawing.Size(96, 23);
            this.FirstMethodButton.TabIndex = 1;
            this.FirstMethodButton.Text = "Генерировать";
            this.FirstMethodButton.UseVisualStyleBackColor = true;
            this.FirstMethodButton.Click += new System.EventHandler(this.FirstMethodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Метод середины квадратов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мультипликативный конгруэнтный метод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите X0";
            // 
            // InputX0TextBox
            // 
            this.InputX0TextBox.Location = new System.Drawing.Point(157, 206);
            this.InputX0TextBox.Name = "InputX0TextBox";
            this.InputX0TextBox.Size = new System.Drawing.Size(52, 20);
            this.InputX0TextBox.TabIndex = 5;
            this.InputX0TextBox.Text = "5";
            // 
            // FirstMethodStartValueTextBox
            // 
            this.FirstMethodStartValueTextBox.Location = new System.Drawing.Point(166, 58);
            this.FirstMethodStartValueTextBox.Name = "FirstMethodStartValueTextBox";
            this.FirstMethodStartValueTextBox.Size = new System.Drawing.Size(52, 20);
            this.FirstMethodStartValueTextBox.TabIndex = 6;
            this.FirstMethodStartValueTextBox.Text = "1994";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите значение";
            // 
            // ThirdMethodChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ThirdMethodChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ThirdMethodChart.Legends.Add(legend1);
            this.ThirdMethodChart.Location = new System.Drawing.Point(333, 45);
            this.ThirdMethodChart.Name = "ThirdMethodChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ThirdMethodChart.Series.Add(series1);
            this.ThirdMethodChart.Size = new System.Drawing.Size(463, 311);
            this.ThirdMethodChart.TabIndex = 8;
            this.ThirdMethodChart.Text = "chart";
            // 
            // ThirdMethodButton
            // 
            this.ThirdMethodButton.Location = new System.Drawing.Point(333, 362);
            this.ThirdMethodButton.Name = "ThirdMethodButton";
            this.ThirdMethodButton.Size = new System.Drawing.Size(458, 43);
            this.ThirdMethodButton.TabIndex = 9;
            this.ThirdMethodButton.Text = "ТЫК";
            this.ThirdMethodButton.UseVisualStyleBackColor = true;
            this.ThirdMethodButton.Click += new System.EventHandler(this.ThirdMethodButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 417);
            this.Controls.Add(this.ThirdMethodButton);
            this.Controls.Add(this.ThirdMethodChart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstMethodStartValueTextBox);
            this.Controls.Add(this.InputX0TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstMethodButton);
            this.Controls.Add(this.SecondMethodButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ThirdMethodChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SecondMethodButton;
        private System.Windows.Forms.Button FirstMethodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputX0TextBox;
        private System.Windows.Forms.TextBox FirstMethodStartValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart ThirdMethodChart;
        private System.Windows.Forms.Button ThirdMethodButton;
    }
}