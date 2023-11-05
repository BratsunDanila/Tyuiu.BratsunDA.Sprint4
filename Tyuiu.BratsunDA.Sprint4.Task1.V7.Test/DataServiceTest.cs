using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint4.Task1.V7.Lib;

namespace Tyuiu.BratsunDA.Sprint4.Task1.V7.Test
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
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
