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
    //Метод для отображения символьного массива
    static void ShowArray(char[] newArray)
    {
        for (int k = 0; k < newArray.Length; k++)
        {
            Console.Write("| {0} ", newArray[k]);
        }

        Console.WriteLine("|");
    }
    //Если аргументом методу передается два целых числа, то результат - массив натуральных чисел,
    //где первое и последнее число это аргументы метода
    static int[] OverloadedMeth(int num1, int num2)
    {
        int[] iarray = new int[(num2 - num1) + 1];

        for (int k = 0; k < iarray.Length; k++)
        {
                iarray[k] = num1;
                num1++;
        }
        return iarray;
    }
    //Если аргументом методу передается два символьных значения, то результат - символьный массив,
    //где первый и последний символ это аргументы метода
    static char[] OverloadedMeth(char symb1, char symb2)
    {
        char[] iarray = new char[(symb2 - symb1) + 1];

        for (int k = 0; k < iarray.Length; k++)
        {
                iarray[k] = symb1;
                symb1++;
        }
        return iarray;
    }

    static void Main()
    {
        int x1 = 4, x2 = 7;

        char y1 = 'B', y2 = 'H';

        Console.WriteLine("Массив, состоящий из натуральных чисел: ");
        ShowArray(OverloadedMeth(x1, x2));

        Console.WriteLine("Массив, состоящий из символов: ");
        ShowArray(OverloadedMeth(y1, y2));

        Console.ReadKey();
    }
}