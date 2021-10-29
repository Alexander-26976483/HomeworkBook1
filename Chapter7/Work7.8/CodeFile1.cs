using System;

class Myclass
{
    private string txt;

    public Myclass(string txt)
    {
        this.txt = txt;
    }

    // Метод, позволяющий вставить подстроку в текст из текстового поля. Аргументами передается
    // подстрока для вставки в текст и индекс позиции, начиная с которой выполняется вставка.
    public void InsertSubstring(string sub, int index)
    {
        int l = txt.Length;

        string first_sub = txt.Substring(0, (l - (l - index) + 1));

        string last_sub = txt.Substring(index + 1);

        txt = first_sub + sub + last_sub;
    }

    // Переопределение метода ToString() на возвращение значения из текстового поля:
    public override string ToString()
    {
        return txt;
    }
}
class StringDemo
{
    static void Main()
    {
        string txt1 = "В этот текст будет вставлена подстрока.";

        string sub = "кучерявый ";

        int i = 6;

        Console.WriteLine(txt1);

        Myclass A = new Myclass(txt1);

        A.InsertSubstring(sub, i);

        Console.WriteLine(A);

        Console.ReadKey();
    }
}