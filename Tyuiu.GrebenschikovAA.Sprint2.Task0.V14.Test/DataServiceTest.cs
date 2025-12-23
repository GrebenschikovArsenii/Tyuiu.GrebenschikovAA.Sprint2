using Tyuiu.GrebenschikovAA.Sprint2.Task0.V14.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void OperationsValid()
        {
            int x = 1075, y = 754;
            DataService ds = new DataService();
            bool[] wait = [true, false, true, false, true, false];
            Assert.AreEqual(wait, ds.GetCompareOperations(x, y));
        }
    }
}