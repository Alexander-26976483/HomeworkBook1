using System;

class Myclass
{
    private int[] numbs = new int[20];

    public Myclass()
    {
        Random rnd = new Random();

        for (int k = 0; k < numbs.Length; k++)
        {
            numbs[k] = rnd.Next(0, 101);
        }
    }

    public override string ToString()
    {
        int sum = 0;

        string txt = "";

        for (int k = 0; k < numbs.Length; k++)
        {
            txt += numbs[k] + " ";
            sum += numbs[k];
        }

        txt += "\nКоличество элементов: " + numbs.Length;

        txt += "\nСреднее значение для элементов: " + sum / numbs.Length;

        return txt;
    }

}

class StringDemo
{
    static void Main()
    {
        Myclass A = new Myclass();

        Console.WriteLine(A);

        Console.ReadKey();
    }
}