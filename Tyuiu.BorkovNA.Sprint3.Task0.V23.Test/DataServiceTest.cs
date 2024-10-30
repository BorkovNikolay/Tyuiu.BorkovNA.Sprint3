using Tyuiu.BorkovNA.Sprint3.Task0.V23.Lib;

namespace Tyuiu.BorkovNA.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(0.298, ds.GetSumSeries(1.5, 1, 10));
        }
    }
}