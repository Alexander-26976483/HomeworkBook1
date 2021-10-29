using System;

class MyClass
{
    public static void Arbitrary(params int[] a)
    {
        int max = a[0], min = a[0], average, sum = a[0];
        //Цикл для вычисления наибольшего, наименьшего значения и суммирования значений
        for (int k = 1; k < a.Length; k++)
        {
            if (a[k] > max)
            {
                max = a[k];
            }
            if (a[k] < min)
            {
                min = a[k];
            }
            sum += a[k];
        }
        //Вычисление среднего значения
        average = sum / a.Length;

        Console.WriteLine($"Наибольшее значение: {max}; наименьшее значение: {min}; среднее значение: {average}");
    }

    public static void setArray(int[] array)
    {
        int max = array[0], min = array[0], average, sum = array[0];
        //Цикл для вычисления наибольшего, наименьшего значения и суммирования значений
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] > max)
            {
                max = array[k];
            }
            if (array[k] < min)
            {
                min = array[k];
            }
            sum += array[k];
        }
        //Вычисление среднего значения
        average = sum / array.Length;

        Console.WriteLine($"Наибольшее значение: {max}; наименьшее значение: {min}; среднее значение: {average}");
    }
}
class UsingClass
{
    static void Main()
    {
        MyClass.Arbitrary(2, 3, 5, 120, 15, 20, 31, 46);

        MyClass.setArray(new int[] { 4, 5, 6, 7 });

        Console.ReadKey();
    }
}