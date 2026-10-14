using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.IvanovEY.Sprint1.Task0.V18.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int expected = 3;
            double actual = ds.Calculate();
            Assert.AreEqual(expected, actual);  
        }
    }
}