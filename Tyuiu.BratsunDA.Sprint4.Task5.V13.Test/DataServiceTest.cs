using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.BratsunDA.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[3, 3] { { 1, -5, 4 }, { -3, 6, 8 }, { -1, -7, -8 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[3, 3] { { 1, 0, 4 }, { 0, 6, 8 }, { 0, 0, 0 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
