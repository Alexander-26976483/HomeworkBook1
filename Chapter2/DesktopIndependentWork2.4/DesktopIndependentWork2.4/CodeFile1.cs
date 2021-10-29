using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Range
{
    static void Main()
    {
        int number;

        number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));

        string txt = "Введенное число ";

        txt += (number >= 5 && number <= 10 ? "удовлетворяет заданным условиям!" : "не удовлетворяет заданным условиям!");

        MessageBox.Show(txt, "Результат");
    }
}