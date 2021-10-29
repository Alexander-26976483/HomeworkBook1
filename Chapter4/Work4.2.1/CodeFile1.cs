using System;

class ArrayDemo
{
    static void Main()
    {
        int size = 11, p;

        int[] nums = new int[size];

        Console.Title = "Массив степеней двойки";
        Console.WriteLine("Массив в прямом порядке:");

        for (p = 0; p < nums.Length; p++)
        {
            if (p > 0)
            {
                nums[p] = nums[p-1] * 2;
            }
            else
            {
                nums[p] = 1;
            }
            Console.Write("| " + nums[p] + " |");
        }

        Console.WriteLine("");
        Console.WriteLine("Массив в обратном порядке: ");

        for (p = nums.Length - 1; p >= 0; p--)
        {
            Console.Write("| " + nums[p] + " |");
        }

        Console.ReadLine();
    }
}