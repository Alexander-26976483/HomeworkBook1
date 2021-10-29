using System;

class MyClass
{
    private static int value = 0;

    public static void Show()
    {
        Console.WriteLine($"Текущее значение поля: {value}");
        value++;
        Console.WriteLine($"Значение поля, после увеличения на единицу: {value}");
    }
}
class UsingClass
{
    static void Main()
    {
        MyClass.Show();

        Console.ReadKey();
    }
}