using System;

namespace ConsoleIndependentWork1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string month, day;

            Console.Title = "Ввод месяца и дней в нем";

            Console.Write("Введите название текущего месяца: ");

            month = Console.ReadLine();

            Console.Write("Введите количество дней в текущем месяце: ");

            day = Console.ReadLine();

            Console.Title = "Текущий месяц и количество дней в нем";

            Console.WriteLine("В месяце {0} {1} дней", month, day);

            Console.ReadLine();
        }
    }
}
