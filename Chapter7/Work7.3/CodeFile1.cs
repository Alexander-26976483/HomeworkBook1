using System;

class StringDemo
{
    static bool CmpStr(string txt1, string txt2)
    {
        int temp = 0;
        
        // Если строки разной длины:
        if (txt1.Length != txt2.Length)
        {
            return false;
        }
        
        // Если строки одинаковой длины:
        for (int k = 0; k < txt1.Length; k++)
        {
            temp = txt1[k] - txt2[k];

            // Если коды символов отличаются больше чем на единицу:
            if (Math.Abs(temp) > 1)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        string str1 = "Абонент", str2 = "Баннжоу";

        Console.WriteLine($"Результат сравнения строк \"{str1}\" и \"{str2}\": {CmpStr(str1, str2)}");

        Console.WriteLine($"Результат сравнения строк \"{str1}\" и \"{"Абсолют"}\": {CmpStr(str1, "Абсолют")}");

        Console.ReadKey();
    }
}