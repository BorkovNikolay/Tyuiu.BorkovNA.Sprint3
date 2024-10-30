using Tyuiu.BorkovNA.Sprint3.Task1.V24.Lib;

namespace Tyuiu.BorkovNA.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(0.186, ds.GetSumSeries(5, 1, 12));
        }
    }
}