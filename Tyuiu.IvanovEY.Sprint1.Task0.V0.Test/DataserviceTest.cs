using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IvanovEY.Sprint1.Task0.V0.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int expected = 3;
            int actual = ds.CalculateExpression();
            Assert.AreEqual(expected, actual);
        }
    }
}