using System;

class MyClass
{
    private int numb = 2;

    public MyClass(int numb2)
    {
        if (numb2 <= 100)
        {
            numb = numb2;
        }
        else numb = 100;
    }
    //Конструктор без аргументов
    public MyClass()
    {
        numb = 0;
    }
    public void Method(int numb1 = 0)
    {
        if (numb1 <= 100)
        {
            numb = numb1;
        }
        else numb = 100;
    }
    //public void Method()
    //{
    //    numb = 0;
    //}
    public void Show()
    {
        Console.WriteLine("Целочисленное поле: {0}", numb);
    }
}
class UsingClass
{
    static void Main()
    {
        //В данном случае вызывается конструктор без аргументов
        MyClass A = new MyClass();
        //Проверка целочисленного поля
        A.Show();
        
        //Вызов метода с целочисленным аргументом
        A.Method(56);
        //Проверка
        A.Show();
        
        //Вызов метода с целочисленным аргументом больше 100
        A.Method(156);
        //Проверка
        A.Show();
        
        //Вызов метода без аргументов
        A.Method();
        //Проверка
        A.Show();
        
        Console.WriteLine("Проверка конструкторов класса: ");
        //Вызов конструктора с целочисленным аргументом
        MyClass C = new MyClass(99);
        C.Show();
        
        //Вызов конструктора с целочисленным аргументом больше 100
        MyClass D = new MyClass(156);
        D.Show();

        Console.ReadKey();
    }
}