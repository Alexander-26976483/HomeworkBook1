using System;

class Myclass
{
    private string[] arr;

    public Myclass()
    {
        arr = new string[] { "Alpha", "Bravo", "Charlie" };
    }

    // Одномерный индексатор с циклической перестановкой индексов:
    public string this[int k]
    {
        get
        {
            return arr[k % arr.Length];
        }
        set
        {
            arr[k % arr.Length] = value;
        }
    }

    // Двумерный индексатор с циклической перестановкой индексов:
    public char this[int i, int s]
    {
        get
        {
            return this[i][s % this[i].Length];
        }
    }

    // Метод для отображения массива:
    public void Show()
    {
        for (int k = 0; k < arr.Length; k++)
        {
            Console.Write("| " + "{0} ", this[k]);
        }
        Console.WriteLine("|");
    }

    public int ArrLength => arr.Length;
}
class UsingPropsDemo
{
    static void Main()
    {
        Myclass A = new Myclass();

        Console.Write("Текстовый массив: ");
        
        A.Show();

        int element = 5, index = 9;

        element %= A.ArrLength;

        index %= A[element].Length;
                
        Console.WriteLine("{0}-й символ из {1}-го элемента текстового массива: \'{2}\'", index + 1, element + 1, A[element, index]);

        Console.ReadKey();
    }
}