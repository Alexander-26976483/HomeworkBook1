using System;

class MyClass
{
    public char symb1, symb2;

    public void Show()
    {
        for(char k = symb1; k <= symb2; k++)
        {
            Console.Write(k + " ");
        }
    }
}
class UsingClass
{
    static void Main()
    {
        MyClass obj = new MyClass();

        obj.symb1 = 'T';
        obj.symb2 = 'h';
        
        obj.Show();

        Console.ReadKey();
    }
}