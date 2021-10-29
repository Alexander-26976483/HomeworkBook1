using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        int n = 7, k = 1, s = 0;

        Console.Write("Сумма 2 + 4 + 6 + ... + {0} = ", 2 * n);

        while (k <= n)
        {
            s += 2 * k;
            k++;
        }

        Console.WriteLine(s);
        Console.ReadLine();
    }
}