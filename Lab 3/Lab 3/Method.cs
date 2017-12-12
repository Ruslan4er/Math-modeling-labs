using System;
using System.Collections.Generic;

namespace Lab_3
{
    class Method
    {
        private Random rnd = new Random();
        private double mX;
        private double mY;
        private double mXY;

        public List<double> CalculateSeriesX(double[,] matrix)
        {
            var resultList = new List<double>();
            for (var i = 0; i < 3; i++)
            {
                double series = 0;
                for (var j = 0; j < 3; j++)
                    series = series + matrix[i, j];
                resultList.Add(series);
            }
            return resultList;
        }

        public List<double> CalculateSeriesY(double[,] matrix)
        {
            var resultList = new List<double>();
            for (var i = 0; i < 3; i++)
            {
                double series = 0;
                for (var j = 0; j < 3; j++)
                    series = series + matrix[j, i];
                resultList.Add(series);
            }
            return resultList;
        }

        public double RollX(List<double> XRowList, double[] XValue, out double resultX)
        {
            var x = rnd.NextDouble();
            if (x <= XRowList[0])
                resultX = XValue[0];
            else if (x > XRowList[0] && x < XRowList[0] + XRowList[1])
                resultX = XValue[1];
            else resultX = XValue[2];
            return resultX;
        }

        public double RollY(List<double> YRowList, double[] YValue, out double resultY)
        {
            var x = rnd.NextDouble();
            if (x <= YRowList[0])
                resultY = YValue[0];
            else if (x > YRowList[0] && x <= YRowList[0] + YRowList[1])
                resultY = YValue[1];
            else resultY = YValue[2];
            return resultY;
        }

        public double CalculateMathX(double[] XValue, List<double> XRowList)
        {
            double result = 0;
            for (var i = 0; i < 3; i++)
                result += XValue[i] * XRowList[i];
            mX = result;
            return result;
        }

        private double CalculateSquareMathX(double[] XValue, List<double> XRowList)
        {
            double result = 0;
            for (var i = 0; i < 3; i++)
                result += Math.Pow(XValue[i], 2) * XRowList[i];
            return result;
        }

        public double CalculateMathY(double[] YValue, List<double> YRowList)
        {
            double result = 0;
            for (var i = 0; i < 3; i++)
                result += YValue[i] * YRowList[i];
            mY = result;
            return result;
        }

        private double CalculateSquareMathY(double[] YValue, List<double> YRowList)
        {
            double result = 0;
            for (var i = 0; i < 3; i++)
                result += Math.Pow(YValue[i], 2) * YRowList[i];
            return result;
        }

        public double CalculateDX(double[] XValue, List<double> XRowList)
        {
            return CalculateSquareMathX(XValue, XRowList) -
                Math.Pow(CalculateMathX(XValue, XRowList), 2);
        }

        public double CalculateDY(double[] YValue, List<double> YRowList)
        {
            return CalculateSquareMathY(YValue, YRowList) -
                Math.Pow(CalculateMathY(YValue, YRowList), 2);
        }

        public double CalculateMathXY(double[] XValue, double[] YValues,
            double[,] probabilityMatrix)
        {
            double result = 0;
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                    result += XValue[i] * YValues[j] * probabilityMatrix[i, j];
            }
            mXY = result;
            return result;
        }

        public List<double> CalculateXDensity(List<double> ResultXYofValueList)
        {
            var resultXList = new List<double>();
            for (var i = 0; i < 3; i++) resultXList.Add(0);
            foreach (var value in ResultXYofValueList)
            {
                switch (value)
                {
                    case 7.2:
                        resultXList[0]++;
                        break;
                    case 10:
                        resultXList[1]++;
                        break;
                    case 12.8:
                        resultXList[2]++;
                        break;
                }
            }
            return resultXList;
        }

        public List<double> CalculateYDensity(List<double> ResultXYofValueList)
        {
            var resultYList = new List<double>();
            for (var i = 0; i < 3; i++) resultYList.Add(0);
            foreach (var value in ResultXYofValueList)
            {
                switch (value)
                {
                    case 0.8:
                        resultYList[0]++;
                        break;
                    case 1.6:
                        resultYList[1]++;
                        break;
                    case 2.4:
                        resultYList[2]++;
                        break;
                }
            }
            return resultYList;
        }

        public List<double> CalculateXYDensity(List<double> ResultXYofValueList, double[] XValue,
            double[] YValue)
        {
            var resultXYList = new List<double>();
            for (var i = 0; i < 9; i++) resultXYList.Add(0);
            for (var i = 0; i < ResultXYofValueList.Count; i = i + 2)
            {
                var x = ResultXYofValueList[i];
                var y = ResultXYofValueList[i + 1];
                if (Equals(x, XValue[0]))
                {
                    if (Equals(y, YValue[0]))
                        resultXYList[0]++;
                    else if (Equals(y, YValue[1]))
                        resultXYList[1]++;
                    else resultXYList[2]++;
                }
                if (Equals(x, XValue[1]))
                {
                    if (Equals(y, YValue[0]))
                        resultXYList[3]++;
                    else if (Equals(y, YValue[1]))
                        resultXYList[4]++;
                    else resultXYList[5]++;
                }
                if (Equals(x, XValue[2]))
                {
                    if (Equals(y, YValue[0]))
                        resultXYList[6]++;
                    else if (Equals(y, YValue[1]))
                        resultXYList[7]++;
                    else resultXYList[8]++;
                }
            }
            return resultXYList;
        }
        
        public double CalculateCorrelation()
        {
            var result = mXY - mX * mY;
            return result;
        }

    }
}
