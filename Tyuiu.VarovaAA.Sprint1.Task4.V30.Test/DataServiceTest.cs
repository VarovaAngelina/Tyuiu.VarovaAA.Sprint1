using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint1.Task4.V30.Lib;
namespace Tyuiu.VarovaAA.Sprint1.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1.856;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
