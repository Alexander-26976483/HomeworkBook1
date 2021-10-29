using System;

namespace ConsoleIndependentWork1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, number_1, number_2;

            Console.Title = "Ввод числа";

            Console.Write("Введите любое целое число: ");

            number = Int32.Parse(Console.ReadLine());

            number_1 = number - 1;

            number_2 = number + 1;

            Console.Title = "Результат";

            Console.WriteLine("Полученный результат: {0}, {1}, {2}.", number_1, number, number_2);

            Console.ReadLine();
        }
    }
}
