using Tyuiu.GrebenschikovAA.Sprint2.Task3.V6.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidIfXIsTwo()
        {
            double x = 2;
            DataService ds = new DataService();
            Assert.AreEqual(-7, ds.Calculate(x));
        }
        [TestMethod]
        public void ValidIfXIsZero()
        {
            double x = 0;
            DataService ds = new DataService();
            Assert.AreEqual(-0.083, ds.Calculate(x));
        }
        [TestMethod]
        public void ValidIfXIsMinusTwo()
        {
            double x = -2;
            DataService ds = new DataService();
            Assert.AreEqual(0.020, ds.Calculate(x));
        }
        [TestMethod]
        public void ValidIfXIsMinusTen()
        {
            double x = -10;
            DataService ds = new DataService();
            Assert.AreEqual(-1100.01, ds.Calculate(x));
        }
        [TestMethod]
        public void ValidIfXIsMinusNine()
        {
            double x = -9;
            DataService ds = new DataService();
            Assert.AreEqual(0, ds.Calculate(x));
        }
    }
}