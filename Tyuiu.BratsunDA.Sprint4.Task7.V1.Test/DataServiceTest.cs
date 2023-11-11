﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint4.Task7.V1.Lib;

namespace Tyuiu.BratsunDA.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 3;
            int m = 3;
            int[,] matrix = new int[n, m];
            string str = "135792468";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
