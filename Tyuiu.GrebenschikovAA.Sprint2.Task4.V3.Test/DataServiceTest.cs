using Tyuiu.GrebenschikovAA.Sprint2.Task4.V3.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidIfXMoreThanYPlusThree()
        {
            double x = 5, y = 1;
            DataService ds = new DataService();
            Assert.AreEqual(11, ds.Calculate(x, y));
        }
        [TestMethod]
        public void ValidIfXLessThanYPlusThree()
        {
            double x = 1, y = 1;
            DataService ds = new DataService();
            Assert.AreEqual(2, ds.Calculate(x, y));
        }
    }
}