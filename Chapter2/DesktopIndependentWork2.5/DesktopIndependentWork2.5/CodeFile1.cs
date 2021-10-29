using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Thousand
{
    static void Main()
    {
        int numb, thousand;

        numb = Int32.Parse(Interaction.InputBox("Введите целое число", "Количество тысяч"));

        thousand = numb / 1000 % 10;

        string txt = "В числе \""+ numb + "\" " + thousand+" тысяч";

        MessageBox.Show(txt, "Тысячи");
    }
}