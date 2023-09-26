using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint1.Task5.V7.Lib;
namespace Tyuiu.VarovaAA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 30;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(Math.Floor(res));

            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
