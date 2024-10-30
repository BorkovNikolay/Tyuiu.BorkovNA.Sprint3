using Tyuiu.BorkovNA.Sprint3.Task3.V24.Lib;

namespace Tyuiu.BorkovNA.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string x = "ghghg";
            char y = 'g';
            char z = 'c';
            string r = "chchc";
            Assert.AreEqual(r, ds.ReplaceCharInString(x, y, z));
        }
    }
}