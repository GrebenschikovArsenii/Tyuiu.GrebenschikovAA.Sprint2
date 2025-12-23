using Tyuiu.GrebenschikovAA.Sprint2.Task2.V6.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MethodValidInCheckedArea()
        {
            DataService ds = new DataService();
            int x = 8, y = 8;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void MethodValidInUncheckedArea()
        {
            DataService ds = new DataService();
            int x = 12, y = 12;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);
        }
    }
}