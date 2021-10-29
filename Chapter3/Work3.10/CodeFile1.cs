using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        Console.Title = "Вычисление суммы чисел по условию";

        try
        {
            int number, i = 0, s = 0, c = 0;

            Console.Write("Введите любое целое число: ");
            number = Int32.Parse(Console.ReadLine());

            while(c < number)
            {
                if(i % 5 == 2 || i % 3 == 1)
                {
                    s += i;
                    c++;
                }
                i++;
            }

            string txt = "Сумма чисел: " + s + "";

            Console.Title = "Результат";
            Console.Write(txt);
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