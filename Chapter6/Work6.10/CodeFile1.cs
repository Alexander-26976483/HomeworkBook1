using System;

class MyClass
{
    //Закрытое статическое поле (граница суммы):
    private static int N = 100;

    //Статический метод для вычисления косинуса:
    public static double Cosine(double x)
    {
        double s = 0, q = 1;

        for (int k = 0; k <= N; k++)
        {
            s += q;
            q *= (-1) * x * x / (2 * k + 2) / (2 * k + 1);
        }
        return s;
    }
    //Статический метод для вычисления гиперболического синуса:
    public static double Sinush(double x)
    {
        double s = 0, q = x;

        for (int k = 0; k <= N; k++)
        {
            s += q;
            q *= x * x / (2 * k + 3) / (2 * k + 2);
        }
        return s;
    }
    //Статический метод для вычисления гиперболического косинуса:
    public static double Cosineh(double x)
    {
        double s = 0, q = 1;

        for (int k = 0; k <= N; k++)
        {
            s += q;
            q *= x * x / (2 * k + 2) / (2 * k + 1);
        }
        return s;
    }
}
class UsingClass
{
    static void Main()
    {
        double z = 0.5, z1 = 1, z2 = 0.5;

        Console.WriteLine($"cos({z})={MyClass.Cosine(z)}");

        Console.WriteLine($"Контрольное значение: {Math.Cos(z)}");

        Console.WriteLine($"sinh({z1})={MyClass.Sinush(z1)}");

        Console.WriteLine($"Контрольное значение: {Math.Sinh(z1)}");

        Console.WriteLine($"cosh({z2})={MyClass.Cosineh(z2)}");

        Console.WriteLine($"Контрольное значение: {Math.Cosh(z2)}");

        Console.ReadKey();
    }
}