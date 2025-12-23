using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task0.V14.Lib
{
    public class DataService: ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = [(y - x) == -(x - y), (y - x) != -(x - y), y < x, y > x, y <= x, y >= x];
            foreach (bool b in res)
            {
                Console.WriteLine(b);
            }
            return res;
        }
    }
}
