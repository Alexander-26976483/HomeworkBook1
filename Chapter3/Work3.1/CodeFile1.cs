using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        MessageBox.Show("Проверка деления на 3 и 7", "Начало программы");

        try
        {
            int number, division1, division2;

            number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));

            division1 = number % 3;

            division2 = number % 7;

            if (division1 == 0 && division2 == 0)
            {
                string txt = "Введенное число делиться на 3 и на 7";

                MessageBox.Show(txt, "Результат");
            }

            else
            {
                string txt = "Введенное число не делиться на 3 и на 7";

                MessageBox.Show(txt, "Результат");
            }
        }
        catch 
        {
            MessageBox.Show("Надо было ввести целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        MessageBox.Show("Проверка завершена", "Завершение программы");

    }
}