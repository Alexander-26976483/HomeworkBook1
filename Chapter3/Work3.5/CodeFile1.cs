using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{

    static void Main()
    {

        MessageBox.Show("Определение порядкового номера дня недели", "Начало программы", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string nameweek, number = "";

            nameweek = Interaction.InputBox("Введите любое название дня недели", "Ввод названия дня недели");

            switch (nameweek)
            {
                case "Понедельник":
                    number = "1-й день недели";
                    break;

                case "Вторник":
                    number = "2-й день недели";
                    break;

                case "Среда":
                    number = "3-й день недели";
                    break;

                case "Четверг":
                    number = "4-й день недели";
                    break;

                case "Пятница":
                    number = "5-й день недели";
                    break;

                case "Суббота":
                    number = "6-й день недели";
                    break;

                case "Воскресенье":
                    number = "7-й день недели";
                    break;

                default:
                    number = "Такого названия дня не существует";
                    break;
            }

            MessageBox.Show(number, "День недели");

        MessageBox.Show("Определение порядкового номера дня недели завершено", "Завершение программы");
    }
}