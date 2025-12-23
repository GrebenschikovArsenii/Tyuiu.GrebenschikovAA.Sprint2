using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task3.V6.Lib
{
    public class DataService: ISprint2Task3V6
    {
        public double Calculate(double x)
        {
            if (x > 0) return Math.Round((x + Math.Pow((x -15) / (x - 10), x-3)), (3));
            else if (x == 0) return Math.Round(((x * x - Math.Cos(x * x) +10) / (x * x - Math.Sin(x * x) + 12)), 3);
            else if (x < 0 && x > -10) return Math.Round(Math.Pow(x*x*x*x + (1 / (x * x)), x), 3);
            else if (x < -10) return Math.Round((x + 10 * x - (1/(x))), 3);
            else return 0;
        }
    }
}
