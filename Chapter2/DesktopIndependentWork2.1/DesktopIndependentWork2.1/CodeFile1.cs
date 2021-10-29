using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Division_by_3
{
    static void Main()
    {
        int number, check;

        number = Int32.Parse(Interaction.InputBox("Введите целое число", "Ввод данных"));

        check = number % 3;

        string txt="Введенное число ";

        txt += (check == 0 ? "делится на 3!":"не делится на 3!");

        MessageBox.Show(txt, "Результат");
    }
}