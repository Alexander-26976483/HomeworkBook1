using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Thousand
{
    static void Main()
    {
        int numb, octal;

        numb = Int32.Parse(Interaction.InputBox("Введите целое число", "Ввод числа"));

        octal = numb /8 % 8;

        string txt = "В восьмеричном представлении вторая цифра справа \"" + octal + "\"";

        MessageBox.Show(txt, "Восьмеричное представление");
    }
}