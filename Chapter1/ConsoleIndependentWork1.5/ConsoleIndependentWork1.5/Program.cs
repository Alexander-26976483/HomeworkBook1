using System;

namespace ConsoleIndependentWork1._5
{
    class Program
    {
        static void Main()
        {
            int year = 2021, age, born;

            Console.Title = "Узнаем год рождения...";

            Console.Write("Введите Ваш год рождения: ");

            born = Int32.Parse(Console.ReadLine());

            age = year - born;

            Console.WriteLine($"Ваш возраст: {age}");

            Console.ReadLine();
        }
    }
}
