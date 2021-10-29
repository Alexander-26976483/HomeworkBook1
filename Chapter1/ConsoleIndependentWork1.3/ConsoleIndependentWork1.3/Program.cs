using System;

namespace ConsoleIndependentWork1._3
{
    class Date
    {
        static void Main()
        {
            string day_of_week, month, date;
            
            Console.Title = "Узнаем сегодняшний день...";
            
            Console.Write("Введите название текущей недели: ");

            day_of_week = Console.ReadLine();

            Console.Write("Введите название текущего месяца: ");

            month = Console.ReadLine();

            Console.Write("Введите текущую дату: ");

            date = Console.ReadLine();

            Console.Title = "Cегодняшний день";

            Console.WriteLine("День недели: {0}, Дата: {1}, Месяц: {2}", day_of_week, date, month);

            Console.ReadLine();
        }
    }
}
