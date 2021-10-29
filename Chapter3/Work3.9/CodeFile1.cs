using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        try
        {
            int number1, number2, k;

            Console.Title = "Первое число";
            Console.Write("Введите первое целое число: ");
            number1 = Int32.Parse(Console.ReadLine());

            Console.Title = "Второе число";
            Console.Write("Введите второе целое число: ");
            number2 = Int32.Parse(Console.ReadLine());

            if(number1 < number2)
            {
                for (k = number1; k <= number2; k++)
                {
                    Console.Title = "Целые числа в указанном диапазоне";
                    Console.Write("| {0} | ", k);
                }
            }
            else if(number1 > number2)
            {
                for (k = number2; k <= number1; k++)
                {
                    Console.Title = "Целые числа в указанном диапазоне";
                    Console.Write("| {0} | ", k);
                }
            }
            Console.ReadLine();
        }
        catch
        {
            Console.Title = "Неверный ввод";
            Console.Write("Нужно было ввести целое число!");
            Console.ReadLine();
        }
    }
}