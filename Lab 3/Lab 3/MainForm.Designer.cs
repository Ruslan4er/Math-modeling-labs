namespace Lab_3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.XСhart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.YChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.RandomListLengthTextBox = new System.Windows.Forms.TextBox();
            this.MXLabel = new System.Windows.Forms.Label();
            this.DXLabel = new System.Windows.Forms.Label();
            this.MXYLabel = new System.Windows.Forms.Label();
            this.MYLabel = new System.Windows.Forms.Label();
            this.DYLabel = new System.Windows.Forms.Label();
            this.KXYLabel = new System.Windows.Forms.Label();
            this.XYChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.XСhart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // XСhart
            // 
            chartArea1.Name = "ChartArea1";
            this.XСhart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.XСhart.Legends.Add(legend1);
            this.XСhart.Location = new System.Drawing.Point(267, 12);
            this.XСhart.Name = "XСhart";
            this.XСhart.Size = new System.Drawing.Size(312, 217);
            this.XСhart.TabIndex = 0;
            this.XСhart.Text = "chart1";
            // 
            // YChart
            // 
            chartArea2.Name = "ChartArea1";
            this.YChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.YChart.Legends.Add(legend2);
            this.YChart.Location = new System.Drawing.Point(585, 12);
            this.YChart.Name = "YChart";
            this.YChart.Size = new System.Drawing.Size(312, 217);
            this.YChart.TabIndex = 1;
            this.YChart.Text = "chart2";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(7, 41);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 30);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // RandomListLengthTextBox
            // 
            this.RandomListLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomListLengthTextBox.Location = new System.Drawing.Point(98, 47);
            this.RandomListLengthTextBox.Name = "RandomListLengthTextBox";
            this.RandomListLengthTextBox.Size = new System.Drawing.Size(100, 21);
            this.RandomListLengthTextBox.TabIndex = 3;
            this.RandomListLengthTextBox.Text = "100";
            // 
            // MXLabel
            // 
            this.MXLabel.AutoSize = true;
            this.MXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MXLabel.Location = new System.Drawing.Point(13, 110);
            this.MXLabel.Name = "MXLabel";
            this.MXLabel.Size = new System.Drawing.Size(41, 15);
            this.MXLabel.TabIndex = 4;
            this.MXLabel.Text = "M(X)=";
            // 
            // DXLabel
            // 
            this.DXLabel.AutoSize = true;
            this.DXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DXLabel.Location = new System.Drawing.Point(12, 151);
            this.DXLabel.Name = "DXLabel";
            this.DXLabel.Size = new System.Drawing.Size(39, 15);
            this.DXLabel.TabIndex = 5;
            this.DXLabel.Text = "D(X)=";
            // 
            // MXYLabel
            // 
            this.MXYLabel.AutoSize = true;
            this.MXYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MXYLabel.Location = new System.Drawing.Point(12, 187);
            this.MXYLabel.Name = "MXYLabel";
            this.MXYLabel.Size = new System.Drawing.Size(48, 15);
            this.MXYLabel.TabIndex = 6;
            this.MXYLabel.Text = "M(XY)=";
            // 
            // MYLabel
            // 
            this.MYLabel.AutoSize = true;
            this.MYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MYLabel.Location = new System.Drawing.Point(117, 110);
            this.MYLabel.Name = "MYLabel";
            this.MYLabel.Size = new System.Drawing.Size(40, 15);
            this.MYLabel.TabIndex = 7;
            this.MYLabel.Text = "M(Y)=";
            // 
            // DYLabel
            // 
            this.DYLabel.AutoSize = true;
            this.DYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DYLabel.Location = new System.Drawing.Point(117, 151);
            this.DYLabel.Name = "DYLabel";
            this.DYLabel.Size = new System.Drawing.Size(38, 15);
            this.DYLabel.TabIndex = 8;
            this.DYLabel.Text = "D(Y)=";
            // 
            // KXYLabel
            // 
            this.KXYLabel.AutoSize = true;
            this.KXYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KXYLabel.Location = new System.Drawing.Point(13, 223);
            this.KXYLabel.Name = "KXYLabel";
            this.KXYLabel.Size = new System.Drawing.Size(41, 15);
            this.KXYLabel.TabIndex = 9;
            this.KXYLabel.Text = "K(xy)=";
            // 
            // XYChart
            // 
            chartArea3.Name = "ChartArea1";
            this.XYChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.XYChart.Legends.Add(legend3);
            this.XYChart.Location = new System.Drawing.Point(348, 235);
            this.XYChart.Name = "XYChart";
            this.XYChart.Size = new System.Drawing.Size(549, 230);
            this.XYChart.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.XYChart);
            this.Controls.Add(this.KXYLabel);
            this.Controls.Add(this.DYLabel);
            this.Controls.Add(this.MYLabel);
            this.Controls.Add(this.MXYLabel);
            this.Controls.Add(this.DXLabel);
            this.Controls.Add(this.MXLabel);
            this.Controls.Add(this.RandomListLengthTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.YChart);
            this.Controls.Add(this.XСhart);
            this.Name = "MainForm";
            this.Text = "x";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XСhart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart XСhart;
        private System.Windows.Forms.DataVisualization.Charting.Chart YChart;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox RandomListLengthTextBox;
        private System.Windows.Forms.Label MXLabel;
        private System.Windows.Forms.Label DXLabel;
        private System.Windows.Forms.Label MXYLabel;
        private System.Windows.Forms.Label MYLabel;
        private System.Windows.Forms.Label DYLabel;
        private System.Windows.Forms.Label KXYLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart XYChart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

