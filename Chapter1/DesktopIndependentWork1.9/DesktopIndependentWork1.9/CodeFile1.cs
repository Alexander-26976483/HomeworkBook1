using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Sequence
{
    static void Main()
    {
        string input, txt;

        int number, number_1, number_2;

        input = Interaction.InputBox("Введите любое целое число", "Ввод числа");

        number = Int32.Parse(input);

        number_1 = number - 1;

        number_2 = number + 1;

        txt = "Полученный результат: " + number_1 + ", " + number + ", " + number_2 + "";

        MessageBox.Show(txt, "Результат");
    }
}