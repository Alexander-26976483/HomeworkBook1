using System;

class Base
{
    protected string txt;

    public Base(string txt)
    {
        this.txt = txt;
    }

    public void SetField()
    {
        txt = "Метод без аргументов класса Base";
    }

    public void SetField(string t)
    {
        txt = t;
    }

    private int GetTxtLenght => txt.Length;

    private char this[int k] => txt[k];

    public void Show()
    {
        for(int k= 0; k < GetTxtLenght; k++)
        {
            Console.Write(this[k]);
        }
        Console.WriteLine("\n");
    }
}

class Alpha : Base
{
    public int num;

    public Alpha(int n, string t) : base(t)
    {
        num = n;
    }

    new public void SetField()
    {
        num = 10;
        txt = "Метод без аргументов класса Alpha, поле класса: " + num;
    }

    new public void SetField(string t)
    {
        num = 15;
        txt = t;
    }

    public void SetField(int n)
    {
        num = n;
        txt = "Метод с целочисленным аргументом класса Alpha";
    }

    public void SetField(string t, int n)
    {
        num = n;
        txt = t;
    }

    public string GetField
    {
        get
        {
            string text = "Целочисленное поле производного класса: " + num +
                "\nТекстовое поле базового класса: " + "\"" + txt + "\"" + "\n";
            
            return text;
        }
    }
}

class InheritDemo
{
    static void Main()
    {
        Base A = new Base("Создание объекта базовго класса");
        
        // Проверка текстового поля:
        A.Show();

        // Вызов метода без аргументов базовго класса:
        A.SetField();

        // Проверка текстового поля:
        A.Show();

        // Вызов метода с текстовым аргументом базовго класса:
        A.SetField("Текст для вызова метода с текстовым аргументом базовго класса");

        // Проверка текстового поля:
        A.Show();

        Alpha B = new Alpha(99, "Создание объекта производного класса");

        // Проверка полей:
        Console.WriteLine(B.GetField);

        // Вызов метода без аргументов производного класса:
        B.SetField();

        // Проверка полей через наследуемый метод:
        B.Show();

        // Вызов метода с текстовым аргументом производного класса:
        B.SetField("Метод с текстовым аргументом класса Alpha");

        // Проверка полей:
        Console.WriteLine(B.GetField);

        // Вызов метода с целочисленным аргументом производного класса:
        B.SetField(200);

        // Проверка полей:
        Console.WriteLine(B.GetField);

        // Вызов метода с целочисленным и текстовым аргументом производного класса:
        B.SetField("Метод с целочисленным и текстовым аргументом класса Alpha", 300);

        // Проверка полей:
        Console.WriteLine(B.GetField);

        Console.ReadKey();
    }
}