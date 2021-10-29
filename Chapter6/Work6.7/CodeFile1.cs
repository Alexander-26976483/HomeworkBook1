using System;

class MyClass
{
    private char symb;
    private string str;

    public void Change(char symb)
    {
        this.symb = symb;
    }
    public void Change(string str)
    {
        this.str = str;
    }
    public void Change(char[] symb)
    {
        if(symb.Length == 1)
        {
            this.symb = symb[0];
        }
        else
        {
            for (int k = 0; k < symb.Length; k++)
            {
                str += symb[k];
            }
        }
    }
    public void Show()
    {
        Console.WriteLine($"Символьное поле: '{symb}', текстовое поле: \"{str}\"");
    }
}
class UsingClass
{
    static void Main()
    {
        MyClass A = new MyClass();

        //Вызов метода с одним символьным аргументом
        A.Change('B');
        A.Show();

        //Вызов метода с текстовым аргументом
        A.Change("Добрый день коллеги!");
        A.Show();

        MyClass B = new MyClass();
        //Вызов метода с символьным массивом (более одного элемента)
        B.Change(new char[] { 'Я', 'з', 'ы', 'к', ' ', 'C', '#' });
        B.Show();

        //Вызов метода с символьным массивом (массив из одного элемента)
        B.Change(new char[] { 'V' });
        B.Show();

        Console.ReadKey();
    }
}