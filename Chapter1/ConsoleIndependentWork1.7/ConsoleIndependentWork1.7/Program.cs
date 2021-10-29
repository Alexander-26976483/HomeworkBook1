using System;

namespace ConsoleIndependentWork1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2021, born, age;

            Console.Title = "Возраст";

            Console.Write("Введите Ваш возраст: ");

            age = Int32.Parse(Console.ReadLine());

            born = year - age;
                        
            string txt = "Ваш год рождения " + born + "!";

            Console.Title = "Год рождения";

            Console.WriteLine(txt);

            Console.ReadLine();
        }
    }
}
