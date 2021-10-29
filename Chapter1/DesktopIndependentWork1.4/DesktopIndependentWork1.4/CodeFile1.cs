using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class MonthDay
{
    static void Main()
    {
        string month, day, txt;

        month = Interaction.InputBox("Введите название текущего месяца", "Месяц");

        day = Interaction.InputBox("Введите количество дней в текущем месяце", "Количество дней");

        txt = "Месяц " + month + " содержит " + day + " дней";

        MessageBox.Show(txt, "Месяц и количество дней");
    }
}