﻿using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Shift
{
    static void Main()
    {
        int number, binary;

        number = Int32.Parse(Interaction.InputBox("Введите целое число", "Обычное число"));

        binary = number / 2 / 2 % 2;

        string txt = "В двоичном представлении числа третий бит справа \"" + binary + "\"";

        MessageBox.Show(txt, "Двоичное представление");
    }
}