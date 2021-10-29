using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class SumAndDifference
{
    static void Main()
    {
        string input_1, input_2, txt;

        int number_1, number_2, sum, difference;

        input_1 = Interaction.InputBox("Введите первое число", "Первое число");

        number_1 = Int32.Parse(input_1);

        input_2 = Interaction.InputBox("Введите второе число", "Второе число");
        
        number_2 = Int32.Parse(input_2);

        sum = number_1 + number_2;

        difference = number_1 - number_2;

        txt = "Сумма и разность введенных чисел: " + sum + ", " + difference + "";

        MessageBox.Show(txt);
    }
}