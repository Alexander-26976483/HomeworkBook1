using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        int n = 6, k, s=0;

        Console.Write("Сумма 2 + 4 + 6 + ... + {0} = ", 2 * n);

        for(k=1; k <= n; k++)
        {
            s += 2 * k;
        }

        Console.WriteLine(s);
        Console.ReadLine();
    }
}