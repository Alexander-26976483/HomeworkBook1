using System;

class ArrayDemo
{
    static void Main()
    {
        Random rnd = new Random();

        int size = 30, index, value;

        int[] numbs = new int[size];

        Console.Title = "Массив случайных чисел";

        for(int k = 0; k < numbs.Length; k++)
        {
            numbs[k] = rnd.Next(1, 21);
            Console.Write(numbs[k] + " ");
        }
                
        index = 0;
        value = numbs[index];
        Console.WriteLine("");
        
        //Перебор элементов:
        for (int k = 1; k < numbs.Length; k++)
        {
            if(numbs[k] < value)
            {
                value = numbs[k];
            }
        }
        Console.WriteLine("Наименьшее значение: " + value);

        Console.Write("Индекс(ы) элемента(ов): ");
        //Перебор элементов и сравнение с наименьшим:
        for (int k = 0; k < numbs.Length; k++)
        {
            if(numbs[k] == value)
            {
                Console.Write(k + " ");
            }
        }
        Console.Read();
    }
}