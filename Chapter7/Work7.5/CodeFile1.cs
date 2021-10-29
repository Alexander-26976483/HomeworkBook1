using System;

class StringDemo
{
    static int[] GetIndex(string txt, char symb)
    {
        int lgth = 0;

        // Цикл, который определяет количество вхождений переданного символа в текст.
        // Это значение и станет длинной возвращаемого массива
        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] == symb)
            {
                lgth++;
            }
        }

        if (lgth != 0)
        {
            // Массив, в который запишутся индексы позиций, на которых символ находится в тексте:
            int[] result = new int[lgth];

            int i = 0;

            for (int k = 0; k < txt.Length; k++)
            {
                if (txt[k] == symb)
                {
                    result[i] = k;
                    i++;
                }
            }

            return result;
        }
        else
        {
            return new int[] { -1 };
        }
    }

    static void ShowArray(int[] array)
    {
        for (int k = 0; k < array.Length; k++)
        {
            Console.Write("| {0} ", array[k]);
        }
        Console.WriteLine("|");
    }

    static void Main()
    {
        string text = "В этом тексте нужно определить позиции символа 'е'.";
        string text2 = "В данном тексте нет символа.";

        char symb = 'е', symb2 = 'Б';

        Console.WriteLine(text);
        ShowArray(GetIndex(text, symb));

        Console.WriteLine(text2);
        ShowArray(GetIndex(text2, symb2));

        Console.ReadKey();
    }
}