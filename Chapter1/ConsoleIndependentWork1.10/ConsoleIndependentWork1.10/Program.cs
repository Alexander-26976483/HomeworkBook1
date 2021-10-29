using System;

namespace ConsoleIndependentWork1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1, number_2, sum, difference;

            Console.Title = "Первое число";

            Console.Write("Введите первое число (целое): ");

            number_1 = Int32.Parse(Console.ReadLine());

            Console.Title = "Второе число";

            Console.Write("Введите второе число (целое): ");

            number_2 = Int32.Parse(Console.ReadLine());

            sum = number_1 + number_2;

            difference = number_1 - number_2;

            Console.Title = "Результат";

            Console.WriteLine("Сумма введных чисел равна: {0}, а их разность равна: {1}.", sum, difference);

            Console.ReadLine();
        }
    }
}
