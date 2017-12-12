using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        readonly Method method = new Method();

        private readonly double[,] probabilityMatrix = { { 0.12, 0.22, 0.06 }, 
            { 0.04, 0.12, 0.14 }, { 0.13, 0.13, 0.04 } };
        private double[] xValue = { 7.2, 10, 12.8 };
        private double[] yValue = { 0.8, 1.6, 2.4 };
        private string[] xyVAlue = { "7.2|0.8", "7.2|1.6", "7.2|2.4", "10|0.8", "10|1.6",
            "10|2.4", "12.8|0.8", "12.8|1.6", "12.8|2.4" };

        private List<double> xRowList = new List<double>();
        private List<double> yRowList = new List<double>();
        private List<double> resultRndValueProbabilityList = new List<double>();
        private List<double> resultXYofValueList = new List<double>();
        private int lenght;

        private void CalculetseRows()
        {
            xRowList = method.CalculateSeriesX(probabilityMatrix);
            yRowList = method.CalculateSeriesY(probabilityMatrix);
        }

        //Розыгрыш СВ
        private void RollXY()
        {
            double x;
            double y;
            method.RollX(xRowList, xValue, out x);
            method.RollY(yRowList, yValue, out y);
            resultXYofValueList.Add(x);
            resultXYofValueList.Add(y);
            resultRndValueProbabilityList.Add(FindResultProbability(x, y));
        }

        private double FindResultProbability(double x, double y)
        {
            int xResult = 0;
            int yResult = 0;
            for (var i = 0; i < xValue.Length; i++)
                if (Equals(x, xValue[i])) xResult = i;
            for (var i = 0; i < yValue.Length; i++)
                if (Equals(y, yValue[i])) yResult = i;
            return probabilityMatrix[xResult, yResult];
        }
        
        //Построение графиков
        private void GenerateChart(List<double> densinyList, double[] valueList,
            string chartTitle, Chart chartName)
        {
            chartName.Titles.Add(chartTitle);
            chartName.Palette = ChartColorPalette.Berry;
            for (var i = 0; i < densinyList.Count; i++)
            {
                var series = chartName.Series.Add(valueList[i].ToString());
                series.Points.Add(densinyList[i]);
            }
        }

        private void GenerateXYChart(List<double> DensinyList, string[] valueList,
            string chartName, Chart ChartName)
        {
            ChartName.Titles.Add(chartName);
            ChartName.Palette = ChartColorPalette.Berry;
            for (var i = 0; i < DensinyList.Count; i++)
            {
                var series = ChartName.Series.Add(valueList[i].ToString());
                series.Points.Add(DensinyList[i]);
            }
        }

        private bool LengthIsValid()
        {
            if (!int.TryParse(RandomListLengthTextBox.Text, out var data))
            {
                MessageBox.Show(@"Неверное значение");
                return false;
            }
            lenght = Convert.ToInt32(RandomListLengthTextBox.Text);
            return true;
        }

        //Подсчет числовых характеристик
        private void CalculateNumericalCharacteristic()
        {
            MXLabel.Text = @"M(x)=" + method.CalculateMathX(xValue, xRowList);
            MYLabel.Text = @"M(y)=" + method.CalculateMathY(yValue, xRowList);
            DXLabel.Text = @"D(x)=" + method.CalculateDX(xValue, xRowList);
            DYLabel.Text = @"D(y)=" + method.CalculateDY(yValue, yRowList);
            MXYLabel.Text = @"M(XY)=" + method.CalculateMathXY(xValue, yValue,
                probabilityMatrix);
            KXYLabel.Text = @"K(xy)=" + method.CalculateCorrelation();
        }

        private void GenerateGraphics()
        {
            GenerateChart(method.CalculateXDensity(resultXYofValueList),
                xValue, @"Распределение x", XСhart);
            GenerateChart(method.CalculateYDensity(resultXYofValueList),
                yValue, @"Распределение y", YChart);
            GenerateXYChart(method.CalculateXYDensity(resultXYofValueList, xValue, yValue), xyVAlue, @"Плотность СВ", XYChart);
        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            if (!LengthIsValid()) return;
                CalculetseRows();
            for (var i = 0; i < lenght; i++)
                RollXY();
            CalculateNumericalCharacteristic();
            GenerateGraphics();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
