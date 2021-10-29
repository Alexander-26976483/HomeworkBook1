using System;

namespace ConsoleIndependentWork1._8
{
    class Program
    {
        static void Main(string[] args) 
        {
            int first_num, second_num, sum;

            Console.Title = "Первое число";

            Console.Write("Введите первое число: ");

            first_num = Int32.Parse(Console.ReadLine());

            Console.Title = "Второе число";

            Console.Write("Введите второе число: ");

            second_num = Int32.Parse(Console.ReadLine());

            sum = first_num + second_num;

            Console.Title = "Сумма";

            Console.WriteLine("Сумма введенных чисел: " + sum + "");
        }
    }
}
