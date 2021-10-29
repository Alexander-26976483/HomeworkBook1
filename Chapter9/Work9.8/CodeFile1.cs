using System;

class Myclass
{
    private uint num;

    public Myclass(uint num)
    {
        this.num = num;
    }

    //public uint this[int k]
    //{
    //    set
    //    {
    //        // Локальная переменная:
    //        uint n = num;
            
    //        // "Последняя цифра" присваиваемого значения:
    //        uint rem = value % 10;

    //        // Счетчик и частное от деления ("отбрасывание" цифр из младших разрядов):
    //        uint counter = 0, priv = n;

    //        // Цикл для определения размера массива (по счетчику):
    //        do
    //        {
    //            priv /= 10;
    //            counter++;
    //        }
    //        while (priv != 0);

    //        // Массив для записи числа из n "поразрядно":
    //        uint[] nums = new uint[counter];

    //        // Цикл для записи в массив числа в обратном порядке из n
    //        // с учетом индекса k (определяет разряд в числовом значении поля,
    //        // в который записывается цифра):
    //        for (uint i = 0; i < nums.Length; i++)
    //        {
    //            if (i == k)
    //            {
    //                nums[i] = rem;
    //                n /= 10;
    //            }
    //            else
    //            {
    //                nums[i] = n % 10;
    //                n /= 10;
    //            }
    //        }

    //        n = 0;
            
    //        // Цикл для записи массива (поразрядного представления числа) в переменную n
    //        // с учетом разрядности каждой цифры:
    //        for(uint i = 0; i < nums.Length; i++)
    //        {
    //            n += nums[i] * (uint)Math.Pow(10,i);
    //        }

    //        num = n;          
    //    }
    //}

    public uint this[int k]
    {
        set
        {
            string rem = (value % 10).ToString();

            string txt = Convert.ToString(num);

            string res = txt.Replace(txt[txt.Length-1-k], Char.Parse(rem));

            num = (uint)Int32.Parse(res);
        }
    }

    public uint Num => num;
}
class UsingPropsDemo
{
    static void Main()
    {
        Myclass A = new Myclass(123456);

        Console.WriteLine("Поле \"num\" до индексирования объекта: " + A.Num);

        A[2] = 789;

        Console.WriteLine("Поле \"num\" после индексирования объекта: " + A.Num);

        Console.ReadKey();
    }
}