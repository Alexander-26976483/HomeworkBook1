using System;

class Myclass
{
    private int[,] nums;

    public Myclass(int line, int column)
    {
        nums = new int[line, column];
    }

    // Двумерный индексатор с двумя целочисленными индексами:
    public int this[int i, int j]
    {
        get
        {
            return nums[i, j];
        }
        set
        {
            nums[i, j] = value;
        }
    }

    // Индексатор с одним целочисленным индексом. Результатом возвращает значение
    // наибольшего элемента в строке двумерного массива, а присваивание значения - 
    // тому элументу в строке, который имеет наибольшее значение:
    public int this[int k]
    {
        get
        {
            int max = nums[k, 0];

            for (int i = 0; i < nums.GetLength(1); i++)
            {
                if (nums[k, i] > max)
                {
                    max = nums[k, i];
                }
            }

            return max;
        }
        set
        {
            for (int i = 0; i < nums.GetLength(1); i++)
            {
                if (nums[k, i] == this[k])
                {
                    nums[k, i] = value;
                    return;
                }
            }
        }
    }

    // Метод для отображения двумерного массива:
    public void Show()
    {
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write("{0, -4}", this[i, j]);
            }
            Console.WriteLine();
        }
    }

    public int Length0 => nums.GetLength(0);
    
    public int Length1 => nums.GetLength(1);
}
class UsingPropsDemo
{
    static void Main()
    {
        Myclass A = new Myclass(5, 6);

        Random rnd = new Random();

        // Заполнение массива случайными числами:
        for (int i = 0; i < A.Length0; i++)
        {
            for (int j = 0; j < A.Length1; j++)
            {
                A[i, j] = i * 10 + rnd.Next(10);
            }
        }

        Console.WriteLine("Начальный двумерный массив: ");
        
        A.Show();

        // Номер строки и присваиваемое значение:
        int line = 1, val = 99;

        Console.WriteLine("Значение наибольшего элемента в строке {0}: {1}", line, A[line]);

        Console.WriteLine("Присваивание значения \"{0}\" наибольшему элементу в строке {1}:", val, line);

        A[line] = val;

        A.Show();

        Console.ReadKey();
    }
}