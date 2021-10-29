using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{

    static void Main()
    {

        MessageBox.Show("Определение дня недели", "Начало программы", MessageBoxButtons.OK, MessageBoxIcon.Information);

        try
        {
            int number;

            string week;

            number = Int32.Parse(Interaction.InputBox("Введите целое число в диапазоне от 1 до 7", "Ввод числа"));

            switch (number)
            {
                case 1:
                    week = "Понедельник";
                    break;

                case 2:
                    week = "Вторник";
                    break;

                case 3:
                    week = "Среда";
                    break;

                case 4:
                    week = "Четверг";
                    break;

                case 5:
                    week = "Пятница";
                    break;

                case 6:
                    week = "Суббота";
                    break;

                case 7:
                    week = "Воскресенье";
                    break;

                default:
                    week = "Введенное число не входит в указанный диапазон";
                    break;

            }

            MessageBox.Show(week, "День недели");
        }

        catch
        {
            MessageBox.Show("Надо было ввести число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        MessageBox.Show("Определение дня недели завершено", "Завершение программы");
    }
}