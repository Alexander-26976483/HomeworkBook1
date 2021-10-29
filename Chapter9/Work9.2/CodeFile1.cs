using System;

class Myclass
{
    private int[] arr;
    private int index = 0;

    public Myclass(int s)
    {
        arr = new int[s];

        for (int k = 0; k < s; k++)
        {
            arr[k] = k + 1;
        }
    }

    public int Arr
    {
        get
        {
            if (index >= arr.Length)
            {
                index = 0;
            }
            return arr[index++];
        }
        set
        {
            if (value >= 0 && value <= arr.Length)
            {
                arr[index] = value;
            }
            index = 0;
        }
    }
}
class UsingPropsDemo
{
    static void Main()
    {
        int size = 6;

        Myclass A = new Myclass(size);

        for (int k = 0; k < size + 3; k++)
        {
            Console.Write(A.Arr);
        }

        Console.WriteLine();

        A.Arr = 5;

        for (int k = 0; k < size; k++)
        {
            Console.Write(A.Arr);
        }

        Console.ReadKey();
    }
}