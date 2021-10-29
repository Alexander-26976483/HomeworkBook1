using System;

class StatMethDemo
{
    static void Show(string txt)
    {
        Console.WriteLine(txt);
    }

    static int SumOfSquares(int x)
    {
        int sum = 0, t;
        for(int k = 1; k <= x; k++)
        {
            t = k * k;
            sum += t;
        }
        return sum;
    }

    static void Main()
    {
        Show("Сумма квадратов натуральных чисел: ");

        int m = 2;

        Show("" + SumOfSquares(m));

        Console.ReadKey();
    }
}