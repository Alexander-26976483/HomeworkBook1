using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo
{
    static void Main()
    {
        MessageBox.Show("Проверка целых чисел между собой", "Начало программы", MessageBoxButtons.OK, MessageBoxIcon.Information);

        try
        {
            int number1, number2;

            number1 = Int32.Parse(Interaction.InputBox("Введите первое целое число", "Первое число"));

            number2 = Int32.Parse(Interaction.InputBox("Введите второе целое число", "Второе число"));

            if (number1 == number2)
            {
                MessageBox.Show("Первое число равно второму числу", "Результат проверки");
            }

            else if (number1 > number2)
            {
                MessageBox.Show("Первое число больше второго числа", "Результат проверки");
            }

            else if (number2 > number1)
            {
                MessageBox.Show("Второе число больше первого числа", "Результат проверки");
            }

        }
        catch
        {
            MessageBox.Show("Надо было ввести целое число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        MessageBox.Show("Проверка завершена", "Завершение программы");
    }
}