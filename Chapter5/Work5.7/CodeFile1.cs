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
    //Метод для перестановки элементов (обратный порядок):
    static char[] ReverseArray(char[] newarray)
    {
        //Вспомогательная переменная для обмена значениями:
        char temp;
        //l - длина массива, m - середина массива
        int l = newarray.Length, m = l/2;
        for (int k = 0; k < m; k++)
        {
            temp = newarray[k];
            l--;
            newarray[k] = newarray[l];
            newarray[l] = temp;
        }
        return newarray;
    }

    static void Main()
    {
        //Исходный символьный массив
        char[] array = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

        Console.WriteLine("Исходный символьный массив: ");
        ShowArray(array);

        Console.WriteLine("Массив в обратном порядке: ");
        ShowArray(ReverseArray(array));

        Console.WriteLine("Проверка: ");
        ShowArray(array);

        Console.ReadKey();
    }
}