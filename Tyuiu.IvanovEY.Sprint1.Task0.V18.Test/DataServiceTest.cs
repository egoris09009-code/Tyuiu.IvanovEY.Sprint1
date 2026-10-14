using Tyuiu.IvanovEY.Sprint1.Task0.V18.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double expected = 3;
            double actual = ds.Calculate();
            Assert.AreEqual(expected, actual);
        }
    }
}
