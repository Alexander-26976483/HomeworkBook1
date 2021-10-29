using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OperatorDemo {

    static void Main() {

        MessageBox.Show("Вычисление суммы чисел", "Начало программы", MessageBoxButtons.OK, MessageBoxIcon.Information);

        try
        {
            int sum=0, number2;

            do {
                number2 = Int32.Parse(Interaction.InputBox("Введите число", "Следующее число"));

                sum += number2;
            }

            while (number2 != 0);

            string txt = "Сумма введенных чисел: "+sum+"";

            MessageBox.Show(txt, "Результат");
        }

        catch {
            MessageBox.Show("Надо было ввести число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        MessageBox.Show("Суммирование завершено", "Завершение программы");
    }
}