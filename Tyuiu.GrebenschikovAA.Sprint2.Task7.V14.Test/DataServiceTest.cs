using Tyuiu.GrebenschikovAA.Sprint2.Task7.V14.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidIfInCheckedArea()
        {
            double x = 0, y = 0.5;
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
        [TestMethod]
        public void ValidIfNotInCheckedArea()
        {
            double x = 1, y = 0;
            DataService ds = new DataService();
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }
    }
}