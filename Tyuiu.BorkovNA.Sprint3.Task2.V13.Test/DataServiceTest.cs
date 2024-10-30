using Tyuiu.BorkovNA.Sprint3.Task2.V13.Lib;

namespace Tyuiu.BorkovNA.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(2.087, ds.GetSumSeries(0.7, 1, 10));
        }
    }
}