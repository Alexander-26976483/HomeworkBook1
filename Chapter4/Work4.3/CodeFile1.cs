using System;

class ArrayDemo
{
    static void Main()
    {
        int size = 10, k;

        char[] symbs = new char[size];

        Console.Title = "Символьный массив";
        Console.WriteLine("Символьный массив в прямом порядке:");

        for (k = 0; k < symbs.Length; k++)
        {
            if (k > 0)
            {
                symbs[k] = (char)(symbs[k-1]+2);
            }
            else
            {
                symbs[k] = (char)('a');
            }
            Console.Write("| "+symbs[k]+" | ");
        }

        Console.WriteLine("");
        Console.WriteLine("Символьный массив в обратном порядке:");

        for (k = symbs.Length - 1; k >= 0; k--)
        {
            Console.Write("| " + symbs[k] + " | ");
        }

        Console.Read();
    }
}