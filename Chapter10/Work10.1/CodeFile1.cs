using System;

// Базовый класс:
class Base
{
    protected string txt;

    public Base(string txt)
    {
        this.txt = txt;
    }

    public override string ToString()
    {
        string t = "Класс Base. Поле: " + "\"" + txt + "\"";

        return t;
    }
}

// Производный класс:
class Myclass : Base
{
    protected string text;

    public Myclass(string t) : base(t)
    {
        text = t;
    }

    public Myclass(string txt1, string txt2) : base(txt1)
    {
        text = txt1 + ", " + txt2;
    }

    public override string ToString()
    {
        string t = "Класс Myclass. Поле класса Myclass: " + "\"" + text + "\""
            + "\nПоле класса Base: " + "\"" + txt + "\"";

        return t;
    }
}

// Класс с главным методом:
class InheritDemo
{
    static void Main()
    {
        
        // Создание объекта базового класса:
        Base A = new Base("Alpha");

        Console.WriteLine(A + "\n");

        // Создание объекта производного класса
        // (конструктор с одним аргументом):
        Myclass B = new Myclass("Bravo");

        Console.WriteLine(B + "\n");

        // Создание объекта производного класса
        // (конструктор с двумя аргументами):
        Myclass C = new Myclass("Charlie", "Delta");

        Console.WriteLine(C + "\n");

        Console.ReadKey();
    }
}