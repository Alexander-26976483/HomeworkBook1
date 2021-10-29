using System;

class StringDemo
{
    static char[] GetAlphabet(string text)
    {
        // Переменная, которая станет длиной целочисленного массива:
        int lgth = 0;

        // Счетчик символов русского алфавита:
        foreach (int i in text)
        {
            if (i >= 1040 && i <= 1103)
            {
                lgth++;
            }
        }

        // Целочисленный массив, который будет состоять из значений символов русского алфавита
        // (без учета пробелов и знаков препинания):
        int[] temp = new int[lgth];

        // Цикл, который заполняет целочисленный массив на основе переданного текста:
        for (int k = 0, i = 0; k < text.Length; k++)
        {
            if (text[k] >= 1040 && text[k] <= 1103)
            {
                temp[i] = text[k];
                i++;
            }
        }

        int tmp;
        // Сортировка массива:
        for (int i = 1; i < temp.Length; i++)
        {
            for (int j = 0; j < temp.Length - i; j++)
            {
                if (temp[j] > temp[j + 1])
                {
                    tmp = temp[j + 1];
                    temp[j + 1] = temp[j];
                    temp[j] = tmp;
                }
            }
        }

        int s = 0;
        
        // Цикл, в котором дублирующие элементы приравниваются нулю и плюс счетчик
        // дублирующих элементов:
        for (int k = 0; k < temp.Length; k++)
        {
            if (temp[k] != 0)
            {
                tmp = temp[k];
                for (int j = k + 1; j < temp.Length; j++)
                {
                    if (tmp == temp[j])
                    {
                        temp[j] = 0;
                        s++;
                    }
                }
            }
        }

        // Символьный массив, который будет результатом:
        char[] result = new char[temp.Length - s];

        int a = 0;

        // Цикл, который заполняет итоговый символьный массив:
        for (int k = 0; k < temp.Length; k++)
        {
            if (temp[k] != 0)
            {
                result[a] = (char)temp[k];
                a++;
            }
         
        }

        return result;
    }

    static void Show(char[] symb)
    {
        for(int k = 0; k < symb.Length; k++)
        {
            Console.Write(symb[k]);
        }
    }

    static void Main()
    {
        string text = "Этот текст будет представлен в символьном виде в алфавитном порядке!";

        //string text = "ННбо льшой";

        Console.WriteLine(text);

        Show(GetAlphabet(text));

        Console.ReadKey();
    }
}