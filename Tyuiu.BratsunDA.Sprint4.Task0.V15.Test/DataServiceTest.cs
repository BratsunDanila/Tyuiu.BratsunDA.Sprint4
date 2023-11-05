using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint4.Task0.V15.Lib;

namespace Tyuiu.BratsunDA.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int wait = 138915;
            int res = ds.GetMultOddArrEl(numsArray);
            Assert.AreEqual(wait, res);

        }
    }
}
