using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task1.V25.Lib
{
    public class DataService: ISprint2Task1V25
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = [(a != b) | (d < c), (a == b) & (a != b), (a <= b) || (a != b), (a == b) && (c <= d), !(b > a), (a == b) ^ (c > d)];
            return res;
        }
    }
}
