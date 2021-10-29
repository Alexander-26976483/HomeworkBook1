using System;

class Myclass
{
    private int[] arr;

    public Myclass(int range, int size)
    {
        arr = new int[size];
    }

    public int this[int n]
    {
        get
        {
            return arr[n];
        }
        set
        {

        }
    }


}
class UsingPropsDemo
{
    static void Main()
    {

        
        
        Console.ReadKey();
    }
}