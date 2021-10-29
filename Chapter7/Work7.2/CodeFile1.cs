using System;

class StringDemo
{
    static string Reversed(string txt)
    {
        string text = "";

        string[] words = txt.Split();

        for (int k = words.Length - 1; k >= 0; k--)
        {
            text += words[k] + " ";
        }

        return text;
    }

    static void Main()
    {
        string txt = "Слова в обычном порядке";

        Console.WriteLine($"Проверка текстовой переменной: \"{txt}\"");

        Console.WriteLine("После вызова метода: " + "\"" + Reversed(txt) + "\"");

        Console.ReadKey();
    }
}