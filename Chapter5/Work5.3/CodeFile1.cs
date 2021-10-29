using System;

class StatMethDemo
{
    //Метод для отображения массива
    static void ShowArray(int[] newArray)
    {
        for(int k=0; k < newArray.Length; k++)
        {
            Console.Write("| {0} ", newArray[k]);
        }
        
        Console.WriteLine("|");
    }

    //Метод для создания ссылки на новый массив на основе исходного
    static int[] ArrayBasedArray(int[] array, int x)
    {
        if (x <= array.Length)
        {
            int[] newArray = new int[x];
            for (int k = 0; k < x; k++)
            {
                newArray[k] = array[k];
            }
            return newArray;
        }
        else
        {
            return array;
        }
    }

    static void Main()
    {
        int[] array = { 2, 4, 6, 8, 10, 12, 14 };

        int m = 5;

        Console.WriteLine("Исходный массив: ");
        ShowArray(array);

        Console.WriteLine("Массив на основе исходного с количеством элементов: {0} ", m);

        ShowArray(ArrayBasedArray(array, m));

        Console.ReadKey();
    }
}