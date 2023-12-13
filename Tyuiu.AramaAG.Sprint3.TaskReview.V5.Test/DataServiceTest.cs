using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint3.TaskReview.V5.Lib;

namespace Tyuiu.AramaAG.Sprint3.TaskReview.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService data = new DataService();
            int startValue = -1;
            int stopValue = 1;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 70.14;
            valueWaitArray[1] = 55.21;
            valueWaitArray[2] = 41.05;
            valueWaitArray[3] = 27.96;
            valueWaitArray[4] = 15.48;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = -13.06;
            valueWaitArray[7] = -28.16;
            valueWaitArray[8] = -42.96;
            valueWaitArray[9] = -56.77;
            valueWaitArray[10] = -69.83;
            double[] res = new double[len];
            res = data.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
