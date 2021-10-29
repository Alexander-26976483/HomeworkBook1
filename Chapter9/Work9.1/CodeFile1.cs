using System;

class Myclass
{
    private char symb;

    public char Symbs
    {
        get { return symb; }
        set
        {
            if (value >= 'A' && value <= 'Z')
                symb = value;
        }
    }

}
class UsingPropsDemo
{
    static void Main()
    {
        Myclass A = new Myclass();

        Console.WriteLine("Проверка свойства: \'" + A.Symbs + "\'");

        A.Symbs = 'Z';

        Console.WriteLine("Проверка свойства: \'" + A.Symbs + "\'");

        A.Symbs = 'h';

        Console.WriteLine("Проверка свойства: \'" + A.Symbs + "\'");

        Console.ReadKey();
    }
}