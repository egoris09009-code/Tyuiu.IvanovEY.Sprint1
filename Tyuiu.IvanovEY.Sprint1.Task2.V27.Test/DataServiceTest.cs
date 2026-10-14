using Tyuiu.IvanovEY.Sprint1.Task2.V27.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            int result = ds.CalculateSquarePerimetr(a);
            Assert.AreEqual(20, result);
        }
    }
}
