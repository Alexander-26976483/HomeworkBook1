using System;

class MyClass
{
    public static void Arbitrary(params int[] a)
    {
        Method(a);
    }

    public static void setArray(int[] array)
    {
        Method(array);
    }
    private static void Method(int[] array)
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
        MyClass.Arbitrary(2, 3, 5, 500, 15, 20, 31, 46);

        MyClass.setArray(new int[] { 4, 5, 6, 7 });

        Console.ReadKey();
    }
}