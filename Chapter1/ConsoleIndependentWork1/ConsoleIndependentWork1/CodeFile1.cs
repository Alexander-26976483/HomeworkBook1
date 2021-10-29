using System;
class InputNameSurname
{
    static void Main()
    {
        string name, surname;

        Console.Title = "Время знакомства...";

        Console.Write("Какое у Вас имя? ");

        name = Console.ReadLine();

        Console.Write("Какая у Вас Фамилия? ");

        surname = Console.ReadLine();

        string txt = "Очень приятно, " + name + " " + surname + "!";

        Console.Title = "Вот и познакомились...";

        Console.WriteLine(txt);

        Console.ReadLine();
    }
}