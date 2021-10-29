using System;

class StatMethDemo
{
    //Метод для отображения двумерного массива
    static void ShowArray(int[,] two_di_array)
    {
        for (int i = 0; i < two_di_array.GetLength(0); i++)
        {
            for (int j = 0; j < two_di_array.GetLength(1); j++)
            {
                Console.Write(two_di_array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int Two_dimensionalArray(int[,] array, out int index0, out int index1)
    {
        //Начальные значения неинициализированных аргументов:
        index0 = 0;
        index1 = 0;
        //Перебор элементов массива:
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                //Если значение элемента в массиве больше текущего минимального значения
                if(array[i, j] > array[index0, index1])
                {
                    index0 = i;
                    index1 = j;
                }
            }
        }
        return array[index0, index1];
    }

    static void Main()
    {
        // Исходный двумерный массив
        int[,] twoarray = { { 200, 2, 3 }, { 4, 86, 6 }, { 7, 8, 150 }, { 10, 160, 161 } };

        Console.WriteLine("Исходный двумерный массив: ");
        ShowArray(twoarray);

        //Неинициализированные аргументы:
        int a, b;

        Console.WriteLine("Наибольший элемент в массиве: ");
        Console.WriteLine(Two_dimensionalArray(twoarray, out a, out b));
        Console.WriteLine("Индекс строки: {0}", a);
        Console.WriteLine("Индекс столбца: {0}", b);

        Console.ReadKey();
    }
}