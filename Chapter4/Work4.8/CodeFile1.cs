using System;

class ArrayTwo_dimensionalDemo
{
    static void Main()
    {
        Random rnd = new Random();

        int rows = 5, columns = 3;

        int[,] numbs = new int[rows, columns];

        Console.Title = "Двумерные массивы";
        Console.WriteLine("Двумерный массив случайных чисел:");
        for(int i = 0; i < numbs.GetLength(0); i++)
        {
            for(int j = 0; j < numbs.GetLength(1); j++)
            {
                numbs[i, j] = rnd.Next(1, 101);
                Console.Write(numbs[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int[,] tmp = new int[columns, rows];

        Console.WriteLine("Двумерный массив случайных чисел (столбцы и строки поменяны местами):");
        for (int i = 0; i < tmp.GetLength(0); i++)
        {
            for (int j = 0; j < tmp.GetLength(1); j++)
            {
                tmp[i, j] = numbs[j, i];
                Console.Write(tmp[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.Read();
    }
}