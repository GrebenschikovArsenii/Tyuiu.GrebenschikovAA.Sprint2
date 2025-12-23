using Tyuiu.GrebenschikovAA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint2.Task5.V3
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
            Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Составить программу, которая в зависимости от порядкового номера        *");
            Console.WriteLine("* дня недели (1, 2, …, 7) выводит на экран его название                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер дня недели: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write(ds.FindDayName(x));
            Console.ReadLine();
        }
    }
}
