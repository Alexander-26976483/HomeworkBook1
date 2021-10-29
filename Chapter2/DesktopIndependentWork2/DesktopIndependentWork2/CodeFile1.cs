using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class InputNameAge
{
    static void Main()
    {
        string name, age, txt;
       
        name = Interaction.InputBox("Введите Ваше имя", "Имя");

        age = Interaction.InputBox("Введите Ваш возраст", "Возраст");

        txt = "Ваше имя " + name + " и Ваш возраст " + age + "";

        MessageBox.Show(txt, "Имя и возраст");

    }
}