using Tyuiu.GrebenschikovAA.Sprint2.Task3.V6.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Гребенщиков А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Гребенщиков Арсений | ИБКСб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if-else,                            *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.             *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (x > 0 && x <= 1 || x == 9) Console.WriteLine("Функции для такого значения X не существует");
            else
            {
                Console.Write("Значение функции Y при данном значении X: ");
                double res = ds.Calculate(x);
            }
            Console.ReadLine();
        }
    }
}
