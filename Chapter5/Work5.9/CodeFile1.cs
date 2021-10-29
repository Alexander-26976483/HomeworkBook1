using System;

class StatMethDemo
{
    //Метод для отображения целочисленного массива
    static void ShowArray(int[] newArray)
    {
        for (int k = 0; k < newArray.Length; k++)
        {
            Console.Write("| {0} ", newArray[k]);
        }

        Console.WriteLine("|");
    }
    //Метод возвращает наибольшее и наименьшее значение (в виде целочисленного массива) среди аргументов, переданных методу
    static int[] HLvalue(params int[] a)
    {
        //Массив, в который запишутся max и min значения
        int[] result = new int[2];

        //Индекс первого элемента в массиве
        int first = 0;
        //Переменные минимального и максимального значения
        int min = a[first], max = a[first];
        //Перебор массива (произвольные аргументы)
        for (int k = 1; k < a.Length; k++)
        {
            if (a[k] < min)
            {
                min = a[k];
                result[0] = min;
            }
            if (a[k] > max)
            {
                max = a[k];
                result[1] = max;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Наибольшее и наименьшее число: ");
        ShowArray(HLvalue(2, 5, 8, 45, 16, 78, 125, 1, 3));
        
        Console.ReadKey();
    }
}
