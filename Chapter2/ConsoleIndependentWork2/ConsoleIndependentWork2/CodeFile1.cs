using System;

class InputNameAge
{
    static void Main()
    {
        string name, age;
        Console.Title = "Время знакомства...";

        Console.Write("Введите Ваше Имя: ");

        name = Console.ReadLine();

        Console.Write("Введите Ваш возраст: ");

        age = Console.ReadLine();

        string txt = "Получается Ваше Имя " + name + " и Вам " + age + " лет";

        Console.Title = "Вот и все узнали...";

        Console.WriteLine(txt);

        Console.ReadLine();
    }

}