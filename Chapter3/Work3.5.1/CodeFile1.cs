using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        MessageBox.Show("Определение порядкового номера дня недели", "Начало программы", MessageBoxButtons.OK, MessageBoxIcon.Information);

        string nameweek, number;

        nameweek = Interaction.InputBox("Введите любое название дня недели", "Ввод названия дня недели");

        if (nameweek == "Понедельник") {
            number = "1-й день недели";
        }
        else if(nameweek == "Вторник")
        {
            number = "2-й день недели";
        }
        else if (nameweek == "Среда")
        {
            number = "3-й день недели";
        }
        else if (nameweek == "Четверг")
        {
            number = "4-й день недели";
        }
        else if (nameweek == "Пятница")
        {
            number = "5-й день недели";
        }
        else if (nameweek == "Суббота")
        {
            number = "6-й день недели";
        }
        else if (nameweek == "Воскресенье")
        {
            number = "7-й день недели";
        }
        else
        {
            number = "Такого названия дня не существует";
        }
        
        MessageBox.Show(number, "День недели");
        MessageBox.Show("Определение порядкового номера дня недели завершено", "Завершение программы");
    }
}