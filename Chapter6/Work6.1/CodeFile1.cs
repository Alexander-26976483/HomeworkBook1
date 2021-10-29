using System;

class MyClass
{
    //Закрытое символьное поле
    private char symb = 'f';
    //Метод, присваиваюищй значение полю
    public void Set(char s)
    {
        symb = s;
        Console.WriteLine(symb);
    }
    //Метод, возвращающий результатом код символа
    public static int CodeSymb(char s)
    {
        return s;
    }
    //Метод, выводящий в консольное окно символ (значение поля) и его код
    public void Show()
    {
        int symb2 = symb;
        Console.WriteLine("Значение поля: \"{0}\", его код: \"{1}\"", symb, symb2);
    }
}
class UsingClass
{
    static void Main()
    {
        char symb1 = 's';

        MyClass obj = new MyClass();

        //Проверка значения закрытого поля
        obj.Show();
        //Присваиваем значение закрытому полю
        obj.Set(symb1);
        //Выводит код символа
        Console.WriteLine(MyClass.CodeSymb(symb1));

        obj.Show();

        Console.ReadKey();
    }
}