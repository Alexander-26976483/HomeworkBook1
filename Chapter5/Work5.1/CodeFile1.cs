using System;

class StatMethDemo
{
    static void Show(string txt)
    {
        Console.WriteLine(txt);
    }
    static int DoubleFactorial(int x)
    {
        int s = 1;
        for (int k = x; x % 2 == 0 ? k >= 2 : k >= 1; k--)
        {
            s *= k;
            k--;
        }
        return s;
    }
    static void Main()
    {
        Show("Начинаем вычисления: ");

        int m = 4;

        Show(m + "!! = " + DoubleFactorial(m));

        Console.ReadKey();
    }
}