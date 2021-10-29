using System;

class Myclass
{
    private int[] arr;

    // Конструктор для создания и заполнения массива:
    public Myclass(int n)
    {
        arr = new int[n];

        for(int k= 0; k < arr.Length; k++)
        {
            arr[k] = n + k;
        }
    }

    // Свойство только для получения значения:
    public int SumElemsArr
    {
        get
        {
            int sum = 0;

            for(int k=0; k < arr.Length; k++)
            {
                sum += arr[k];
            }
            
            return sum;
        }
    }
}
class UsingPropsDemo
{
    static void Main()
    {
        int m = 6;

        Myclass A = new Myclass(m);

        Console.WriteLine("Значение свойства: " + A.SumElemsArr);
        
        Console.ReadKey();
    }
}