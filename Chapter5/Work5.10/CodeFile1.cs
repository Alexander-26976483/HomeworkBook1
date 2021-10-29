using System;

class StatMethDemo
{
    static string Text(string txt, params char[] symb)
    {
        string res = txt;

        for (int k = 0; k < symb.Length; k++)
        {
            res += symb[k];
        }
        return res;
    }
    static void Main()
    {
        string text = "Первые три буквы английского алфавита: ";

        char A = 'A';
        char B = 'B';
        char C = 'C';

        Console.WriteLine(Text(text, A, B, C));

        Console.ReadKey();
    }
}