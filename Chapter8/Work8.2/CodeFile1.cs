using System;

class Myclass
{
    private int[] arr;

    public Myclass(int size)
    {
        arr = new int[size];
    }

    // Операторный метод возвращает результатом текстовую строку
    // со значениями элементов массива:
    public static string operator ~(Myclass obj)
    {
        string txt = "";

        for (int k = 0; k < obj.arr.Length; k++)
        {
            txt += "[" + obj.arr[k] + "]";
        }

        return txt;
    }

    // Операторный метод добавляет в массив новый элемент с нулевым значением
    // и возвращает результатом ссылку на объект-операнд:
    public static Myclass operator ++(Myclass obj)
    {
        int[] tmp = new int[obj.arr.Length + 1];

        for (int k = 0; k < obj.arr.Length; k++)
        {
            tmp[k] = obj.arr[k];
        }

        obj.arr = tmp;

        return obj;
    }

    // Операторный метод удаляет из массива один элемент (последний)
    // и возвращает результатом ссылку на объект-операнд:
    public static Myclass operator --(Myclass obj)
    {
        int[] tmp = new int[obj.arr.Length - 1];

        for (int k = 0; k < tmp.Length; k++)
        {
            tmp[k] = obj.arr[k];
        }

        obj.arr = tmp;

        return obj;
    }

    // Операторный метод вычисляет сумму двух объектов (объединение массивов)
    // и возвращает результатом ссылку на новый объект:
    public static Myclass operator +(Myclass obj1, Myclass obj2)
    {
        int[] tmp = new int[obj1.arr.Length + obj2.arr.Length];

        for (int k = 0; k < obj1.arr.Length; k++)
        {
            tmp[k] = obj1.arr[k];
        }

        for (int k = obj1.arr.Length - 1; k < obj2.arr.Length; k++)
        {
            tmp[k] = obj2.arr[k];
        }

        return new Myclass(tmp.Length) { arr = tmp };
    }

    // Операторный метод вычисляет сумму объекта и числа (добавление нового элемента в конец массива)
    // и возвращает результатом ссылку на новый объект:
    public static Myclass operator +(Myclass obj, int n)
    {
        int[] tmp = new int[obj.arr.Length + 1];

        for (int k = 0; k < obj.arr.Length; k++)
        {
            tmp[k] = obj.arr[k];
        }

        tmp[tmp.Length - 1] = n;

        return new Myclass(tmp.Length) { arr = tmp };
    }

    // Операторный метод вычисляет сумму числа и объекта (добавление нового элемента в начало массива)
    // и возвращает результатом ссылку на новый объект:
    public static Myclass operator +(int n, Myclass obj)
    {
        int[] tmp = new int[obj.arr.Length + 1];

        tmp[0] = n;

        for (int k = 1; k < obj.arr.Length; k++)
        {
            tmp[k] = obj.arr[k];
        }

        return new Myclass(tmp.Length) { arr = tmp };
    }
}
class OperatorOverloading
{
    static void Main()
    {
        int size = 5;

        Myclass A = new Myclass(size);
        Myclass B = new Myclass(size);

        Console.WriteLine("Проверка объекта \"A\": " + ~A);
        Console.WriteLine("Проверка объекта \"B\": " + ~B);

        A++;
        B--;

        Console.WriteLine("Проверка объекта \"A\" после применения оператора инкремента: " + ~A);
        Console.WriteLine("Проверка объекта \"B\" после применения оператора декремента: " + ~B);

        int num = 9;

        Myclass C = A + B;

        Console.WriteLine("Проверка суммы двух объектов \"A\" и \"B\": " + ~C);

        B = B + num;

        Console.WriteLine($"Проверка суммы объекта \"B\" и числа {num}: " + ~B);

        A = num + A;

        Console.WriteLine($"Проверка суммы числа {num} и объекта \"A\": " + ~A);

        Console.ReadKey();
    }
}