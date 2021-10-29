using System;

class ArrayDemo
{
    static void Main()
    {
        Random rnd = new Random();

        int size = 10;

        int[] numbs = new int[size];

        Console.Title = "Массив случайных чисел";

        Console.Write("Несортированный массив случайных чисел: ");
        for (int k = 0; k < numbs.Length; k++)
        {
            numbs[k] = rnd.Next(1, 101);
            Console.Write(numbs[k] + " ");
        }
        Console.WriteLine("");

        int temp;
        for (int i = 1; i < numbs.Length; i++)
        {
            for(int j = 0; j < numbs.Length-1; j++)
            {
                if(numbs[j] < numbs[i])
                {
                    temp = numbs[j];
                    numbs[j] = numbs[i];
                    numbs[i] = temp;
                }
            }
        }

        Console.Write("Отсортированный массив случайных чисел: ");
        for (int k = 0; k < numbs.Length; k++)
        {
            Console.Write(numbs[k] + " ");
        }

        Console.Read();
    }
}