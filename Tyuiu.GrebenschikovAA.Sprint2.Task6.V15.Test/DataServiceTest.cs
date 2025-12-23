using Tyuiu.GrebenschikovAA.Sprint2.Task6.V15.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void IsSearchValid()
        {
            DataService ds = new DataService();
            int value = 3;
            Assert.AreEqual("среда", ds.FindDayName(value));
        }
    }
}