using System;

class Myclass
{
    private string txt;

    private char symb;

    private string[] txt_result;

    public Myclass(string txt, char symb)
    {
        this.txt = txt;
        this.symb = symb;
    }

    public string[] SplitDemo()
    {
        // Переменная, в которую записываем количество вхождений символа:

        int i = 0;

        // Счетчик вхождений символа из поля symb в тексте из поля txt:

        for (int k = 0; k < txt.Length; k++)
        {
            if (txt[k] == symb)
            {
                i++;
            }
        }

        // Массив из текстовых строк, в который будут записываться подстроки в результате разбиения:

        string[] result = new string[i + 1];

        int index, // Переменная для индекса первого вхождения символа-индикатора
            c = 0; // Вспомогательная переменная

        index = txt.IndexOf(symb);
        result[0] = txt.Substring(c, index);

        for (int k = 1; k <= i; k++)
        {
            c = index;
            index = txt.IndexOf(symb, c + 1);
            if (index != -1)
            {
                result[k] = txt.Substring(c + 1, index - c - 1);
            }
            else
            {
                result[k] = txt.Substring(c + 1);
            }
        }

        txt_result = result;

        return txt_result;
    }

    // Переопределение метода ToString() на возвращение значения из текстового поля:
    public override string ToString()
    {
        string txt1 = "Текстовое поле: " + txt + "\n";

        txt1 += "Символьное поле: " + symb + "\n";

        for (int k = 0; k < txt_result.Length; k++)
        {
            txt1 += txt_result[k] + "\n";
        }

        return txt1;
    }
}

class StringDemo
{
    static void Main()
    {
        string text = "Самое большое препятствие — страх. Самая большая ошибка — пасть духом.";

        char indicator = ' ';

        Myclass A = new Myclass(text, indicator);

        A.SplitDemo();

        Console.WriteLine(A);

        Console.ReadKey();
    }
}