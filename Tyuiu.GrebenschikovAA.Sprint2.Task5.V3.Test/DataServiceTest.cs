using Tyuiu.GrebenschikovAA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidIfDayNumber()
        {
            int value = 1;
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(value));
        }
        [TestMethod]
        public void ValidIfNotDayNumber()
        {
            int value = 8;
            DataService ds = new DataService();
            Assert.AreEqual("Дня с таким номером не существует", ds.FindDayName(value));
        }
    }
}