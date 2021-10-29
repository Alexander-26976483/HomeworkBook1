using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class NameBorn
{
    static void Main()
    {
        string name, res, txt;

        int year = 2021, born, age;

        name = Interaction.InputBox("Введите Ваше Имя", "Имя пользователя");

        res = Interaction.InputBox("Введите Ваш год рождения", "Год рождения пользователя");

        born = Int32.Parse(res);

        age = year - born;

        txt = "" + name + ", Вам " + age + " лет.";

        MessageBox.Show(txt, "Имя пользователя и возраст");
    }
}