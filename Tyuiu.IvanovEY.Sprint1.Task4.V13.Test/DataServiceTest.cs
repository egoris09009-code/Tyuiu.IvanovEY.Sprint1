using Tyuiu.IvanovEY.Sprint1.Task4.V13.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(0, result);
        }
    }
}
