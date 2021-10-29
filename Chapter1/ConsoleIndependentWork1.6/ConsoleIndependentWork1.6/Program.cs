using System;

namespace ConsoleIndependentWork1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, txt;

            int year = 2021, born, age;

            Console.Title = "Узнаем Имя";

            Console.Write("Введите Ваше имя: ");

            name = Console.ReadLine();

            Console.Title = "Узнаем дату Вашего рождения";

            Console.Write("Введите дату Вашего рождения: ");

            born = Int32.Parse(Console.ReadLine());

            age = year - born;

            Console.Title = "Имя и возраст";

            Console.WriteLine($"{name}, Ваш возраст {age} лет!");

            Console.ReadLine();
        }
    }
}
