using System;

class Myclass
{
    static int num = 1;
    
    // Статическое свойство. При каждом считывании получаем новое нечетное число. При
    // присваивании значения свойству, полю присваиваем порядковый номер числа в последовательности
    // нечетных чисел.
    public static int OddNumb
    {
        get
        {
            int n = 2 * num - 1;

            num++;

            return n;
        }
        set
        {
            num = value;
        }
    }

    // Метод для вывода на консоль последовательности нечетных чисел:
    public static void Show(int startNumber, int length)
    {
        OddNumb = startNumber;

        Console.Write($"Последовательность нечетных чисел, начиная с {startNumber}-го числа: ");

        for (int k = 0; k < length; k++)
        {
            Console.Write(OddNumb + " ");
        }
    }
}
class UsingPropsDemo
{
    static void Main()
    {
        Myclass.Show(5, 10);

        Console.ReadKey();
    }
}