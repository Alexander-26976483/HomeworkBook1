using System;

class StringDemo
{
    // Метод, с помощью которого, в текст-аргумент вставляются пробелы:
    static string Space(string txt)
    {
        string text = "";

        for(int k=0; k < txt.Length; k++)
        {
            text += txt[k] + " ";
        }
        return text;
    }

    static void Main()
    {
        string text = "Изначально|тут|не|было|пробелов!";

        Console.WriteLine($"Текст до передачи в метод: \"{text}\"");

        Console.WriteLine(Space(text));

        Console.ReadKey();
    }
}