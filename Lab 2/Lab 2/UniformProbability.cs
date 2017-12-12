using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class UniformProbability
    {
        private static Random Rnd = new Random();

        //Равномероное распределение
        //Формирование равномерно распределенной последовательности последовательности и 
        //плотности.
        public List<double> CalculateProbability(List<double> inputList, int a, int b)
        {
            var resultList = new List<double>();
            for (var i = 0; i < 10; i++) resultList.Add(0);
            foreach (var value in inputList)
            {
                for (var i = 0; i < 10; i++)
                    if ((value >= b * i / 10) && (value <= b * (i + 0.1)))
                        resultList[i]++;
            }
            for (var i = 0; i < 10; i++)
                resultList[i] = resultList[i] / inputList.Count * 100;
            return resultList;
        }

        //Подсчет функции распределения
        public List<double> DistributionFunction(List<double> filledList, int minValue, int maxValue)
        {
            var distrFunctionList = new List<double>();
            foreach (var x in filledList)
            {
                if (x <= minValue)
                    distrFunctionList.Add(0);
                else if ((minValue < x) && (x < maxValue))
                    distrFunctionList.Add(x);
                else distrFunctionList.Add(1);
            }
            distrFunctionList.Sort();
            return distrFunctionList;
        }
        //Подсчет плотности распределения
        public List<double> DistributionDensity(List<double> filledList, int a, int b)
        {
            var densityList = new List<double>();
            for (var i = 0; i < filledList.Count; i++)
                densityList.Add((double)1 / (b - a));
            return densityList;
        }
        //Генерация равномерно распределенной СВ
        public double GenerateRandomValue(double minValue, double maxValue)
        {
            return minValue + Rnd.NextDouble() * (maxValue - minValue);
        }
    }
}
