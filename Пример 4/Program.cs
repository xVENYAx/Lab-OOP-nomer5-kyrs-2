using System;

namespace Пример_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, k;
            Console.WriteLine(" Введите а" + " - левую границу отрезка");
            a = int.Parse((Console.ReadLine()));
            Console.WriteLine(" Введите b" + " - правую границу отрезка");
            b = int.Parse((Console.ReadLine()));
            s = 0;
            k = 0;
            do
            { s += a; k++; a++; }
            while (a <= b);
            Console.WriteLine('\t' + "   РЕЗУЛЬТАТ:" + " s =" + s + " k=" + k + '\n');
        }
    }
}
