using System;

class Myclass
{
    private uint num;

    private string txt;

    public uint setNum
    {
        set
        {
            num = value;

            txt = Convert.ToString(num, 8);
        }
    }

    //public uint setNum
    //{
    //    set
    //    {
    //        num = value;

    //        uint rem = 1, res;

    //        string temp = "";

    //        for (int k = 0; rem != 0; k++)
    //        {
    //            rem = num % 8;
    //            temp += rem;
    //        }
    //        for (int k = temp.Length - 1; k >= 0; k--)
    //        {
    //            txt += temp[k];
    //        }
    //    }
    //}
    public string getTxt
    {
        get
        {
            return txt;
        }
    }
}
class UsingPropsDemo
{
    static void Main()
    {
        Myclass A = new Myclass();

        uint numb = 159878;

        A.setNum = numb;

        Console.WriteLine($"Восьмиричный код числа {numb} --> {A.getTxt}");

        Console.ReadKey();
    }
}