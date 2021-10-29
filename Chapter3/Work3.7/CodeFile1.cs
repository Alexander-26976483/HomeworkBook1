using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        int n = 5, k = 1, s = 0;

        Console.Write("Сумма 1^2 + 2^2 + 3^2 + ... + {0} = ", n * n);

        do
        {
            s += k * k;
            k++;
        }

        while (k <= n);

        Console.WriteLine(s);
        Console.ReadLine();
    }
}