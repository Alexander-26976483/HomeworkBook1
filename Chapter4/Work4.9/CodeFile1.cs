using System;

class ArrayTwo_dimensionalDemo
{
    static void Main()
    {
        int[,] numbs = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        Console.Title = "Двумерные массивы";
        Console.WriteLine("Двумерный числовой массив:");

        for (int i = 0; i < numbs.GetLength(0); i++)
        {
            for (int j = 0; j < numbs.GetLength(1); j++)
            {
                Console.Write(numbs[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Random rnd = new Random();
        // Индексы удаляемых строк и столбца
        int i_rows, i_columns;
        i_rows = rnd.Next(numbs.GetLength(0));
        i_columns = rnd.Next(numbs.GetLength(1));
        Console.WriteLine($"Удаляется {i_rows + 1}-я строка и {i_columns + 1}-й столбец.");

        int[,] new_numbs = new int[numbs.GetLength(0) - 1, numbs.GetLength(1) - 1];

        //// индексатор для строк в новом массиве
        //int new_i = 0;
        //for (int i = 0; i < numbs.GetLength(0); i++)
        //{
        //    // если индекс в массиве равен удаляемому, то пропускаем итерацию
        //    // при этом i станет больше на 1, а new_i не увеличится
        //    if (i == i_rows)
        //        continue;
        //    // индексатор для столбцов в новом массиве
        //    int new_j = 0;
        //    for (int j = 0; j < numbs.GetLength(1); j++)
        //    {
        //        // тоже самое , что и со строкой
        //        if (j == i_columns)
        //            continue;

        //        new_numbs[new_i, new_j] = numbs[i, j];
        //        new_j++;
        //    }
        //    new_i++;
        //}

        int a = 0;
        for (int i = 0; i < numbs.GetLength(0); i++)
        {
            if (i != i_rows)
            {
                int b = 0;
                for (int j = 0; j < numbs.GetLength(1); j++)
                {
                    if (j != i_columns)
                    {
                        new_numbs[a, b] = numbs[i, j];
                        b++;
                    }
                }
                a++;
            }
        }

        numbs = new_numbs;

        Console.WriteLine("Новый массив: ");
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