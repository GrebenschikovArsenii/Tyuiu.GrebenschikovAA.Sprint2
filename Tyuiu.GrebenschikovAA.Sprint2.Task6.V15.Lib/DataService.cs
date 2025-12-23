using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task6.V15.Lib
{
    public class DataService: ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int day = k % 7 == 0 ? 1 : k % 7;
            switch (day)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                default: return "неизвестный номер дня";
            }
        }
    }
}
