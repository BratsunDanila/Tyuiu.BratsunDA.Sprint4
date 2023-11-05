using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint4.Task3.V25.Lib;

namespace Tyuiu.BratsunDA.Sprint4.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 1, 3, 0, 2, 4 }, { 2, 4, 6, 1, 3 }, { 4, 3, 2, 3, 0 }, { 2, 4, 6, 1, 3 }, { 4, 3, 2, 3, 0 } };

            int res = ds.Calculate(mas2);
            int wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}
