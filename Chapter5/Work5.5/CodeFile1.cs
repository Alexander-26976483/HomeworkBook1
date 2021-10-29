using System;

class StatMethDemo
{
    //Метод для отображения массива
    static void ShowArray(int[] newArray)
    {
        for (int k = 0; k < newArray.Length; k++)
        {
            Console.Write("| {0} ", newArray[k]);
        }

        Console.WriteLine("|");
    }

    static double MeanBasedArray(int[] array)
    {
        double sum = 0;
        double divider = array.Length;
        for (int k = 0; k < array.Length; k++)
        {
            sum += array[k];
        }
        return sum / divider;
    }

    static void Main()
    {
        int[] array = { 2, 13, 12, 56, 11, 12, 14 };

        Console.WriteLine("Исходный массив: ");
        ShowArray(array);

        Console.WriteLine("Среднее значение для элементов массива: ");
        Console.WriteLine(MeanBasedArray(array));

        Console.ReadKey();
    }
}