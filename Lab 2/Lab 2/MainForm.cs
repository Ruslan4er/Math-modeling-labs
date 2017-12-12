using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private readonly UniformProbability uniform = new UniformProbability();
        private List<double> uniformDistrList = new List<double>();
        private int minValue;
        private int maxValue;

        private void GenerateBarchart(List<double> pList)
        {
            this.ResultChart.Titles.Add(@"Равномерное распределение");
            this.ResultChart.Palette = ChartColorPalette.Berry;
            for (var i = 0; i < pList.Count; i++)
            {
                var series = this.ResultChart.Series.Add(((double)(i + 1) / 10 * maxValue).ToString());
                series.Points.Add(pList[i]);
            }
        }

        private List<double> FillList(int count, int minValue, int maxValue)
        {
            List<double> filledList = new List<double>();
            for (var i = 0; i < count; i++)
                filledList.Add(uniform.GenerateRandomValue(minValue, maxValue));
            return filledList;
        }

        //Создание графиков
        private void GenerateChart(List<double> inputList)
        {
            this.DistributionFunctionChart.Titles.Add(@"Функция распределения");
            DistributionFunctionChart.Series[0].ChartType = SeriesChartType.Spline;
            for (var i = 0; i < inputList.Count; i = i + 10)
                DistributionFunctionChart.Series[0].Points.AddXY((double)i / 10, inputList[i]);
        }

        private void GenerateChart2(List<double> inputList)
        {
            this.DensityDistributionChart.Titles.Add(@"Плотность распределения");
            DensityDistributionChart.Series[0].ChartType = SeriesChartType.Spline;
            for (var i = 0; i < inputList.Count; i = i + 10)
                DensityDistributionChart.Series[0].Points.AddXY((double)i / 10, inputList[i]);
        }
        //Проверочка на корректный ввод значений 
        private bool BordersIsValid()
        {
            if (!int.TryParse(MinValueTextBox.Text, out int data))
            {
                MessageBox.Show(@"Неверное минимальное значение");
                return false;
            }
            if (!int.TryParse(MaxValueTextBox.Text, out data))
            {
                MessageBox.Show(@"Неверное максимальное значение");
                return false;
            }
            minValue = Convert.ToInt32(MinValueTextBox.Text);
            maxValue = Convert.ToInt32(MaxValueTextBox.Text);
            return true;
        }

        //Подсчет мат ожидания и дисперсии
        private void FillTextBoxes(int minValue, int maxValue)
        {
            label3.Text = @"M= " + ((minValue + maxValue) / 2);
            label4.Text = @"D= " + (Math.Pow((maxValue - minValue), 2) / 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!BordersIsValid()) return;
            uniformDistrList = FillList(10000, minValue, maxValue);
            GenerateBarchart(uniform.CalculateProbability(uniformDistrList, minValue, maxValue));
            GenerateChart(uniform.DistributionFunction(uniformDistrList, minValue, maxValue));
            GenerateChart2(uniform.DistributionDensity(uniformDistrList, minValue, maxValue));
            FillTextBoxes(minValue, maxValue);
        }
    }
}
