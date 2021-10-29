using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Born
{
    static void Main()
    {
        string res, txt;

        int year = 2021, born, age;

        res = Interaction.InputBox("Введите Ваш возраст", "Год рождения пользователя");

        age = Int32.Parse(res);

        born = year - age;

        txt = "Ваш год рождения " + born + "";

        MessageBox.Show(txt, "Год рождения");
    }
}