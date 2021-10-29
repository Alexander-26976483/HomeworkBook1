using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Division_and_less 
{
    static void Main() 
    {
        int number, remainder;

        number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));

        remainder = number % 4;

        string txt = "Введенное число ";

        txt += (remainder == 0 && number > 10 ? "удовлетворяет заданным условиям!" : "не удовлетворяет заданным условиям!");

        MessageBox.Show(txt, "Результат");
    }
}