using System;

class MyClass
{
    private int max = 100, min = 3;
    //Конструктор с одним аргументом
    public MyClass(int a)
    {
        if (a > max)
        {
            max = a;
        }
        else if (a < min)
        {
            min = a;
        }
    }
    //Конструктор с двумя аргументами
    public MyClass(int b, int c)
    {
        if (b > c)
        {
            if (b > max)
            {
                max = b;
            }
            if (c < min)
            {
                min = c;
            }
        }
        else
        {
            if (c > max)
            {
                max = c;
            }
            if (b < min)
            {
                min = b;
            }
        }
    }
    //Версия конструктора без аргументов
    public MyClass()
    {

    }
    public void Method(int a)
    {
        if (a > max)
        {
            max = a;
        }
        else if (a < min)
        {
            min = a;
        }
    }
    public void Method(int b, int c)
    {
        if (b > c)
        {
            if (b > max)
            {
                max = b;
            }
            if (c < min)
            {
                min = c;
            }
        }
        else
        {
            if (c > max)
            {
                max = c;
            }
            if (b < min)
            {
                min = b;
            }
        }
    }
    public void Show()
    {
        Console.WriteLine("Поле max: {0}; поле min: {1}", max, min);
    }
}
class UsingClass
{
    static void Main()
    {
        MyClass A = new MyClass();

        Console.WriteLine("Проверка значений полей: ");
        A.Show();

        int x = 150, y = 2;
        A.Method(x, y);
        Console.WriteLine($"Проверка значений полей после передачи аргументов {x} и {y}: ");
        A.Show();

        MyClass B = new MyClass();
        B.Method(x);
        Console.WriteLine($"Проверка значений полей после передачи аргумента {x}: ");
        B.Show();

        MyClass C = new MyClass(2);
        Console.WriteLine("Проверка значений полей после передачи конструктору одного аргумента: ");
        C.Show();

        MyClass D = new MyClass(300, 1);
        Console.WriteLine("Проверка значений полей после передачи конструктору двух аргументов: ");
        D.Show();

        Console.ReadKey();
    }
}