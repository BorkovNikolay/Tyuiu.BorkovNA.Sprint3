using Tyuiu.BorkovNA.Sprint3.Task7.V11.Lib;

namespace Tyuiu.BorkovNA.Sprint3.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] res = { 20.36, 15.42, 10.99, 7.43, 4.33, 1, 0, -8.87, -13.03, -16.53, -19.6};
            DataService ds = new();
            Assert.AreEqual(res, ds.GetMassFunction(-5, 5));
          
        }
    }
}