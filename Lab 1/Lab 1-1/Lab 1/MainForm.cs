using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Вызовы методов, которые описаны в ЛР из класса Methods

        private void FirstMethodButton_Click(object sender, EventArgs e)
        {
            Methods method = new Methods();
            int num = Convert.ToInt32(FirstMethodStartValueTextBox.Text);
            method.MidSquareMethod(num);
        }

        private void SecondMethodButton_Click(object sender, EventArgs e)
        {
            Methods method = new Methods();
            int x = Convert.ToInt32(InputX0TextBox.Text);
            method.MultiplicationMethod(x);
        }

        private void ThirdMethodButton_Click(object sender, EventArgs e)
        {
            Methods method = new Methods();
            GenerateChart(method.ThirdMethod());
        }

        //Создание графика
        private void GenerateChart(List<double> PList)
        {
            this.ThirdMethodChart.Titles.Add("График");
            this.ThirdMethodChart.Palette = ChartColorPalette.Berry;
            foreach (double value in PList)
            {
                // Add series.
                Series series = this.ThirdMethodChart.Series.Add(value.ToString());
                // Add point.
                series.Points.Add(value);
            }
        }
    }
}
