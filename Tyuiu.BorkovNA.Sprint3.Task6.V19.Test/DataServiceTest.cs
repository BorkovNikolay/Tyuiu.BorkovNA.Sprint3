using Tyuiu.BorkovNA.Sprint3.Task6.V19.Lib;

namespace Tyuiu.BorkovNA.Sprint3.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(16, ds.GetSumTheDivisors(10,15));
        }
    }
}