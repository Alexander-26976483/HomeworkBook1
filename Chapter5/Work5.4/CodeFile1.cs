using System;

class StatMethDemo
{
    //Метод для отображения массива
    static void ShowArray(char[] array)
    {
        for (int k = 0; k < array.Length; k++)
        {
            Console.Write("| {0} ", array[k]);
        }

        Console.WriteLine("|");
    }
        static void ShowArray(int[] array)
    {
        for (int k = 0; k < array.Length; k++)
        {
            Console.Write("| {0} ", array[k]);
        }

        Console.WriteLine("|");
    }

    static int[] ArrayBasedArray(char[] array)
    {
        int[] newArray = new int[array.Length];
        for (int k = 0; k < array.Length; k++)
        {
            newArray[k] = array[k];
        }
        return newArray;
    }

    static void Main()
    {
        char[] array = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

        Console.WriteLine("Массив, который будет аргументом: ");
        ShowArray(array);

        Console.WriteLine("Целочиселнный массив, состоящий из кодов символов из массива аргумента: ");
        ShowArray(ArrayBasedArray(array));

        Console.ReadKey();
    }
}