using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    public class Methods
    {
        Random rnd = new Random();

        public double FourMethod()
        {
            List<double> RandomList = new List<double>();

            int count = 2000;
            int step = 2;
            double Sum = 0;

            for (int j = 0; j < count; j++)
                RandomList.Add(rnd.NextDouble());
           
            for (int i = 0; i < count - step; i++)
                Sum = Sum + RandomList[i] * RandomList[i + step];
            
            double R = 1.0 / (12*count - step) * Sum;
            return R;
        }



    }
}

