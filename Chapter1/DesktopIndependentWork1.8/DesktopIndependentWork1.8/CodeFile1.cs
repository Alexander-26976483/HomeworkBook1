using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Sum
{
    static void Main()
    {
        string input_1, input_2, txt;

        int firs_num, second_num, sum;

        input_1 = Interaction.InputBox("Введите первое число", "Первое число");

        firs_num = Int32.Parse(input_1);

        input_2 = Interaction.InputBox("Введите второе число", "Второе число");

        second_num = Int32.Parse(input_2);

        sum = firs_num + second_num;

        txt = "Сумма введеных чисел " + sum + "";

        MessageBox.Show(txt, "Сумма");
    }
}