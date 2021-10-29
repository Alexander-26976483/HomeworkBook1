using System;

class StatMethDemo
{
    static void Show(string txt)
    {
        Console.WriteLine(txt);
    }
   
    static int DoubleFactorial(int x)
    {
        int n = 0;
        if (x % 2 == 0)
        {
            n = 1;

        }
        else
        {

        }
    }

    static void Main()
    {
        Show("Начинаем вычисления: ");

        int m = 4;

        Show(m + "!! = " + DoubleFactorial(m));

        Console.ReadKey();
    }
}