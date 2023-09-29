using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint1.Task7.V22.Lib;
namespace Tyuiu.VarovaAA.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = Math.Sqrt(3);
            double y = Math.Sqrt(3);
            double wait = 1.726;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
