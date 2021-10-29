using System;

class ArrayDemo
{
    static void Main()
    {
        try
        {
            int number;

            Console.Title = "Размер массива";
            Console.Write("Введите любое натуральное число: ");
            number = Int32.Parse(Console.ReadLine());

            if (number <= 0) //создание ошибки на случай, если введен ноль или меньше
            {
                number = -1;
            }

            int[] nums = new int[number];

            for (int k = 0, i = 0; k < nums.Length;)
            {
                if (i % 5 == 2)
                {
                    nums[k] += i;
                    Console.Write("| " + nums[k] + " ");
                    k++;
                }
                i++;
            }
            Console.Title = "Массив";
            Console.WriteLine("|");
            Console.ReadLine();
        }
        catch
        {
            Console.Title = "Неверный ввод";
            Console.Write("Нужно было ввести натуральное число!");
            Console.ReadLine();
        }
    }
}