using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public class Methods
    {
        List<int> firstMethodList = new List<int>();
        private List<int> secondMethodList = new List<int>();
        private List<int> thirdMethodRandonList = new List<int>();
        private List<double> pList = new List<double>();
        private List<int> thirdMethodCountList = new List<int>();

        private int count = 10000000;

        private Random rnd = new Random();

        //Метод середины квадратов
        public void MidSquareMethod(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                number = number * number;
                while (number <= count)
                    number = number * 10;
                int result = Convert.ToInt32(number.ToString().Substring(2, 4));
                firstMethodList.Add(result);
                number = result;
            }
            string res = null;
            foreach (var mb in firstMethodList)
                res = res + mb.ToString() + ", ";
            MessageBox.Show(@"Результат: " + res);
        }

        public void MultiplicationMethod(int x)
        {
            for (int i = 0; i < 10; i++)
            {
                //число
                //множитель или коэффициент
                int k = 8 * 3 + 3;
                //модуль
                int g = 4;
                int p = 2;
                int M = p * g;
                //x c множителем
                int kx = x * k;
                int newX = kx % 100;
                secondMethodList.Add(newX);
                int xxx = newX / M;
                x = xxx;
            }
            string res = null;
            foreach (var mb in secondMethodList)
                res = res + mb.ToString() + ", ";
            MessageBox.Show(@"Результат: " + res);
        }

        public List<double> ThirdMethod()
        {
            int k = 10;
            double count = 10;

            for (var i = 0; i < count; i++)
                thirdMethodRandonList.Add(rnd.Next(1, k + 1));
            for (var i = 0; i < k; i++)
                thirdMethodCountList.Add(0); 
            for (var i = 0; i < k; i++)
                pList.Add(0); 
            
            foreach (var number in thirdMethodRandonList)
            {
                switch (number)
                {
                    case 1:
                        thirdMethodCountList[0] = thirdMethodCountList[0] + 1;
                        break;
                    case 2:
                        thirdMethodCountList[1] = thirdMethodCountList[1] + 1;
                        break;
                    case 3:
                        thirdMethodCountList[2] = thirdMethodCountList[2] + 1;
                        break;
                    case 4:
                        thirdMethodCountList[3] = thirdMethodCountList[3] + 1;
                        break;
                    case 5:
                        thirdMethodCountList[4] = thirdMethodCountList[4] + 1;
                        break;
                    case 6:
                        thirdMethodCountList[5] = thirdMethodCountList[5] + 1;
                        break;
                    case 7:
                        thirdMethodCountList[6] = thirdMethodCountList[6] + 1;
                        break;
                    case 8:
                        thirdMethodCountList[7] = thirdMethodCountList[7] + 1;
                        break;
                    case 9:
                        thirdMethodCountList[8] = thirdMethodCountList[8] + 1;
                        break;
                    case 10:
                        thirdMethodCountList[9] = thirdMethodCountList[9] + 1;
                        break;
                }
            }
            for (int i = 0; i < 10; i++)
                pList[i] = thirdMethodCountList[i] / count * 100;
            string res = null;

            foreach (var mb in pList)
                res = res + mb.ToString() + ", ";
            MessageBox.Show(@"Результат: " + res);
            return pList;
        }
    }
}

