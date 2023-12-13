using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AramaAG.Sprint3.TaskReview.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            //double[] vallueArray;
            //double len = ((stopValue - startValue))/0.1 + 1;
            //int len1 = Convert.ToInt32(len);
            //vallueArray = new double[len1];
            //double y;
            //int count = 0;
            //for (double x = startValue; x <= stopValue; x= x + 0.1)
            //{
            //    if ((3 * x + 1.2) == 0)
            //    {
            //        vallueArray[count] = 0;
            //        count++;
            //    }
            //    else
            //    {
            //        y = Math.Round(((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2, 2);
            //        vallueArray[count] = y;
            //        count++;
            //    }
            //}
            //return vallueArray;

            double[] vallueArray;
            double len = ((stopValue - startValue)) / 0.1 + 1;
            int len1 = Convert.ToInt32(len);
            vallueArray = new double[len1];
            double y;
            int count = 0;
            int r = 0;
            double rr = 0;
            for (double x = startValue; x <= stopValue; x = x + 0.1)
            {
                x = Math.Round(x, 2);
                rr = Math.Round(3 * x + 1.2, 3);
                r = Convert.ToInt32(rr*10);
                //if ((3 * x + 1.2) == 0)
                if (r == 0)
                    {
                    vallueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round(((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2, 2);
                    vallueArray[count] = y;
                    count++;
                }
            }
            return vallueArray;
        }
    }
}
