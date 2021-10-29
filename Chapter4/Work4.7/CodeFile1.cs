using System;

class ArraySymbsDemo
{
    static void Main()
    {
        Random rnd = new Random();

        int size = 5;

        char[] symbs = new char[size];

        Console.Title = "Символьный массив";

        Console.Write("Cимвольный массив: ");
        for (int k = 0; k < symbs.Length; k++)
        {
            symbs[k] = (char)rnd.Next(65, 91);
            Console.Write(symbs[k] + " ");
        }
        Console.WriteLine("");
        
        Console.Write("Символьный массив c обратным порядком элементов: ");

        // l - длина массива, m - середина массива, temp - вспомогательная переменная для обмена значениями

        int l = symbs.Length, m = l / 2;

        for (int temp, i = 0; i < m; i++)
        {
            temp = symbs[i];
            symbs[i] = symbs[l - i - 1];
            symbs[l - i - 1] = (char)temp;
        }

        for (int k = 0; k < symbs.Length; k++)
        {
            Console.Write(symbs[k] + " ");
        }

        Console.Read();
    }
}