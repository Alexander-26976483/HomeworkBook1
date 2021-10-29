using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Date
{
    static void Main()
    {
        string day_of_week, month, date, txt;

        day_of_week = Interaction.InputBox("Введите название текущей недели", "Название недели");

        month = Interaction.InputBox("Введите название текущего месяца", "Название месяца");

        date = Interaction.InputBox("Введите текущую дату", "Дата");

        txt = "Сегодня "+ day_of_week + ", "+date+", "+month+"";

        MessageBox.Show(txt, "Сегодняшний день");
    }
}