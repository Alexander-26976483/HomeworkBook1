using System;

class ArrayTwo_dimensionalDemo
{
    static void Main()
    {
        Random rnd = new Random();

        int size = 8;
        
        int[] numbers = new int[size];

        for (int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = rnd.Next(1, 101);
            Console.Write(numbers[j] + "\t");
        }
        Console.WriteLine("");

        int n = numbers.Length; // длина массива
        int k = n / 2;          // середина массива
        int temp;               // вспомогательный элемент для обмена значениями
        for (int i = 0; i < k; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[n - i - 1];
            numbers[n - i - 1] = temp;
        }
        foreach (int i in numbers)
        {
            Console.Write($"{i} \t");
        }

        Console.Read();
    }
}