using System;

class ArrayDemo
{
    static void Main()
    {
        int size = 11, p, s, k;
        
        int[] nums = new int[size];

        nums[0] = 1;

        Console.Title = "Массив степеней двойки";
        Console.WriteLine("Массив в прямом порядке:");
        Console.Write("| " + nums[0] + " |");

        for (p = 1, k = 1; p < nums.Length; p++)
        {
            s = k * 2;
            nums[p] = s;
            k = s;
            Console.Write("| " + nums[p] + " |");
        }
        
        Console.WriteLine("");
        Console.WriteLine("Массив в обратном порядке: ");

        for (p = nums.Length-1; p >= 0; p--)
        {
            Console.Write("| " + nums[p] + " |");
        }

        Console.ReadLine();
    }
}