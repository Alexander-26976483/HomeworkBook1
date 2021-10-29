using System;

class ArrayTwo_dimensionalDemo
{
    static void Main()
    {
        int[,] numbs = new int[3, 4];

        Console.Title = "Двумерные массивы";
        Console.WriteLine("Двумерный массив чисел, заполненный змейкой:");
        //значение элемента массива
        int n = 1;
        //для проверки условия последней строки
        int m = 1;
        for(int i = 0; i < numbs.GetLength(0); i++)
        {
            for(int j = 0; j < numbs.GetLength(1); j++)
            {
                numbs[i, j] = n;
                n++;

            }

        }



        //Выводим массив на консоль
        for (int i = 0; i < numbs.GetLength(0); i++)
        {
            for (int j = 0; j < numbs.GetLength(1); j++)
            {
                Console.Write(numbs[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.Read();
    }
}