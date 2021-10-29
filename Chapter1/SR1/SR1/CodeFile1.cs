using Microsoft.VisualBasic;
using System.Windows.Forms;
    class DialogNameSurname
{
    static void Main()
    {
        string name, surname, txt;
        name = Interaction.InputBox("Какое у Вас Имя?", "Имя");
        surname = Interaction.InputBox("Какая у Вас Фамилия?", "Фамилия");
        txt = "Очень приятно, " + name + " " + surname + "!";
        MessageBox.Show(txt, "Вот и познакомились...");
    } 
}