using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6._4
{
    class MyClass
    {
        //Закрытые поля класса
        private char symb;
        private int num;
        //Конструктор с двумя аргументами
        public MyClass(int n, char s)
        {
            num = n;
            symb = s;
        }
        //Конструктор с дробным аргументом
        public MyClass(double n)
        {
            symb = (char)n; //явное приведение аргумента к символьному типу

            num = (int)(n % Convert.ToInt32(n) * 100);
        }

        //Открытый метод для отображения значений полей
        public void Show()
        {
            Console.WriteLine("Символьное поле: {0}; целочисленное поле: {1}", symb, num);
        }
    }
}
