using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        int number, number1 = 1, number2 = 1, s, k;

        Console.Title = "Количество чисел в последовательности Фибоначчи";
        Console.Write("Введите любое целое число: ");

        number = Int32.Parse(Console.ReadLine());

        Console.Title = "Последовательность Фибоначчи";

        Console.Write("| {0} | ", number1);

        for (k = 2; k <= number; k++)
        {
            s = number1 + number2;
            number1 = number2;
            number2 = s;
            Console.Write("| {0} | ", number1);
        }
        
        Console.ReadLine();
    }
}