using System;

class StringDemo
{
    // Статический метод, эмулирующий работу метода Substring():
    static string MySubstring(string text, int startIndex, int length)
    {
        string result = "";

        for (int k = 0; k < length; k++)
        {
            result += text[startIndex + k];
        }

        return result;
    }

    static void Main()
    {
        string txt = "Из этого текста будет извлекаться подстрока.";

        Console.WriteLine(MySubstring(txt, 4, 10));

        Console.WriteLine("Проверка: " + txt.Substring(4, 10));

        Console.ReadKey();
    }
}