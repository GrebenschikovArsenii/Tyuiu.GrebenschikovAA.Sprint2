using Tyuiu.GrebenschikovAA.Sprint2.Task1.V25.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void OperationsValid()
        {
            DataService ds = new DataService();
            int a = 247, b = 155, c = 325, d = 857;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual([true, false, true, false, true, false], res);
        }
    }
}