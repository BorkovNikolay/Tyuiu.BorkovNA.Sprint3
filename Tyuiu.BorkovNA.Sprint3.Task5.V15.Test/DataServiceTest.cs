using Tyuiu.BorkovNA.Sprint3.Task5.V15.Lib;

namespace Tyuiu.BorkovNA.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(548.732, ds.GetSumSumSeries(5, 1 ,1 ,3 ,10));
        }
    }
}