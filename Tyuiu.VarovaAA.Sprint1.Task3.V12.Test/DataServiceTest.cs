using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint1.Task3.V12.Lib;
namespace Tyuiu.VarovaAA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            double wait = 10;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
