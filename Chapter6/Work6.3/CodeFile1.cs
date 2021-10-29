using System;

class MyClass
{
    //Два закрытых целочисленных поля
    private int value1, value2;
    //Конструктор без аргументов
    public MyClass()
    {
        value1 = 50;
        value2 = 200;
    }
    //Конструктор с одним аргументом
    public MyClass(int a)
    {
        value1 = a;
        value2 = 300;
    }
    //Конструктор с двумя аргументами
    public MyClass(int b, int c)
    {
        value1 = b;
        value2 = c;
    }
    //Открытый метод для отображения значений полей
    public void Show()
    {
        Console.WriteLine("Поле 1 = {0}; поле 2 = {1}", value1, value2);
    }
}
class UsingClass
{
    static void Main()
    {
        MyClass A = new MyClass();
        A.Show();

        MyClass B = new MyClass(100);
        B.Show();

        MyClass C = new MyClass(300, 500);
        C.Show();

        Console.ReadKey();
    }
}