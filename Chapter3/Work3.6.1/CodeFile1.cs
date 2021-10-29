using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        int n = 5, k = 1, s = 0, c;

        c = 2 * n;
               
        while (k <= n)
        {
            s += 2 * k;
            k++;
        }

        string txt;

        txt = "Сумма 2 + 4 + 6 + ... + " + c + " = " + s + "";

        MessageBox.Show(txt, "Сумма четных чисел");
    }
}