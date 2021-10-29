using System;

namespace Work6._4
{
    class UsingClass
    {
        static void Main()
        {
            MyClass A = new MyClass(15, 'G');
            A.Show();

            MyClass B = new MyClass(75.4967);
            B.Show();

            Console.ReadKey();
        }
    }
}
