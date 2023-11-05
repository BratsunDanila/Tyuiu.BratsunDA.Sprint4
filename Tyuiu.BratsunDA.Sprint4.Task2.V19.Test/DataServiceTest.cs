using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.BratsunDA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 3, 4, 5, 6 };

            int res = ds.Calculate(numsArray);
            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}
