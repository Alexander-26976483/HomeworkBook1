using System;

class StringDemo
{
    static bool CmpStr(string str1, string str2, char[] kit1, char[] kit2)
    {
        for(int k = 0; k < str1.Length; k++)
        {

        }
        
        return true;
    }
    static void Main()
    {
        string str1 = "Бульвар разбитых фонарей", str2 = "Технический осмотр автомобиля";

        char[] kit1 = { 'б', 'в', 'р' };
        char[] kit2 = { 'т', 'с', 'о' };

        Console.WriteLine($"Результат сравнения строк \"{str1}\" и \"{str2}\": {CmpStr(str1, str2)}");

        Console.ReadKey();
    }
}