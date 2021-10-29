using System;

class ArrayDemo
{
    static void Main()
    {
        int size = 10, k;

        char[] symbs = new char[size];

        Console.Title = "Массив согласных";
        Console.WriteLine("Символьный массив согласных букв английского алфавита:");

        for (k = 0; k < symbs.Length; k++)
        {
            if (k > 0)
            {
                symbs[k] = (char)(symbs[k - 1] + 1);
            }
            else
            {
                symbs[k] = (char)('B');
            }

            if (symbs[k] != (char)('E') && symbs[k] != (char)('I') && symbs[k] != (char)('O') && symbs[k] != (char)('U') && symbs[k] != (char)('Y'))
            {
                Console.Write("| " + symbs[k] + " | ");
            }
            else
            {
                symbs[k] = (char)(symbs[k] + 1);
                Console.Write("| " + symbs[k] + " | ");
            }
        }

        Console.Read();
    }
}