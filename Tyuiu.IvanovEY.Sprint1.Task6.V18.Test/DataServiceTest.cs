using Tyuiu.IvanovEY.Sprint1.Task6.V18.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckNumber("122"));
            Assert.IsFalse(ds.CheckNumber("0"));
            Assert.IsFalse(ds.CheckNumber("abc"));
        }
    }
}
