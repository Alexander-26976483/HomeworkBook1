using System;

class StatMethDemo
{
    static void Show(string txt)
    {
        Console.WriteLine(txt);
    }

    static int SumOfSquares(int x)
    {
        if (x == 1)
            return 1;
        else return x * x + SumOfSquares(x - 1);
    }

    static void Main()
    {
        Show("Сумма квадратов натуральных чисел: ");

        int m = 7;

        Show("" + SumOfSquares(m));

        Console.ReadKey();
    }
}