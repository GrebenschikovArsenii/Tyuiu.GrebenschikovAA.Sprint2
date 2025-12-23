using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task5.V3.Lib
{
    public class DataService: ISprint2Task5V3
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 1:
                    return "понедельник";
                    break;
                case 2:
                    return "вторник";
                    break;
                case 3:
                    return "среда";
                    break;
                case 4:
                    return "четверг";
                    break;
                case 5:
                    return "пятница";
                    break;
                case 6:
                    return "суббота";
                    break;
                case 7:
                    return "воскресенье";
                    break;
                default: return "Дня с таким номером не существует";
            }
        }
    }
}
