using System;

class Myclass
{
    private char symb;

    public Myclass(char s)
    {
        symb = s;
    }

    // Операторный метод для увеличения значения символьного поля объекта:
    public static Myclass operator ++(Myclass obj)
    {
        obj.symb++;
        return obj;
    }

    // Операторный метод для уменьшения значения символьного поля объекта:
    public static Myclass operator --(Myclass obj)
    {
        obj.symb--;
        return obj;
    }

    // Операторный метод для вычисления суммы объекта и целого числа:
    public static Myclass operator +(Myclass obj, int n)
    {
        return new Myclass((char)(obj.symb + n));
    }

    // Операторный метод для вычисления суммы целого числа и объекта:
    public static Myclass operator +(int n, Myclass obj)
    {
        return new Myclass((char)(n + obj.symb));
    }

    // Операторный метод для вычисления разности объектов:
    public static int operator -(Myclass obj1, Myclass obj2)
    {
        int n = obj1.symb - obj2.symb;
        return n;
    }

    // Переопределение метода ToString() на возвращение значения из символьного поля:
    public override string ToString()
    {
        string txt = "Символьное поле: \'" + symb + "\'";

        return txt;
    }
}

class OperatorOverloading
{
    static void Main()
    {
        Myclass A = new Myclass('G');

        Myclass B = new Myclass('t');
        
        // Применение оператора инкремента:
        Console.WriteLine(A++);

        // Применение оператора декремента:
        Console.WriteLine(B--);

        Myclass C;

        C = A + 10;

        Console.WriteLine(C);

        C = 3 + B;

        Console.WriteLine(C);

        int c = B - A;

        Console.WriteLine(c);

        Console.ReadKey();
    }
}