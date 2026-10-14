using Tyuiu.IvanovEY.Sprint1.Task7.V12.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(333, result);
        }
    }
}
