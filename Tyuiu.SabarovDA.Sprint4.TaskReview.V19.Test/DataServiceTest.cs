using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint4.TaskReview.V19.Lib;
namespace Tyuiu.SabarovDA.Sprint4.TaskReview.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string value = "90817264";
            int res = ds.Calculate(n, m, value);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
