using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Division_with_remainder
{
    static void Main()
    {
        int number, remainder_5, remainder_7;

        number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));

        remainder_5 = number % 5;

        remainder_7= number % 7;

        string txt = "Введенное число ";

        txt += (remainder_5 == 2 && remainder_7 == 1 ? "удовлетворяет заданным условиям!" : "не удовлетворяет заданным условиям!");

        MessageBox.Show(txt, "Результат");
    }
}