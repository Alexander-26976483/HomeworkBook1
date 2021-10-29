using System;

class Myclass
{
    private uint num;

    public Myclass(uint num)
    {
        this.num = num;
    }

    public char this[int k]
    {
        get
        {
            string txt = Convert.ToString(num, 2);

            return txt[k];
        }
    }
}
class UsingPropsDemo
{
    static void Main()
    {
        uint n = 1256;

        int index = 5;
        
        Myclass A = new Myclass(n);

        Console.WriteLine($"Бинарное представление числа {n}: " + Convert.ToString(n, 2));

        Console.WriteLine($"Значение {index}-го бита, при индексировании объекта: " + A[index]);

        Console.ReadKey();
    }
}