using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task2.V6.Lib
{
    public class DataService: ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x >= 3 && x <= 5 && (y >= 3 && y <= 7 || y == 11)) return true;
            else if ((x == 6 && y >= 5 && y <= 11) || (x <= 8 && x >= 7 && y <= 12 && y >= 5)) return true;
            else if (x == 9 && (y >= 3 && y <= 12)) return true;
            else if (x == 10 && (y >= 5 && y <= 7 || y >= 11 && y <= 12)) return true;
            else if (x >= 11 && x <= 12 && (y == 11)) return true;
            else return false;
        }
    }
}
