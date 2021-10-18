using System;

namespace Пример_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, k;
            Console.WriteLine(" Введите а" + "- лeвую границу отрезка.");
            a = int.Parse((Console.ReadLine()));
            Console.WriteLine(" Введите b" + "- правую границу отрезка.");
            b = int.Parse((Console.ReadLine()));
            s = 0;
            k = 0;
            while (a <= b)
            {
                s += a;    // означает s = s + a
                k++;       // означает k = k+1
                a++;       // означает a = a + 1
            }
            Console.WriteLine('\t' + "   РЕЗУЛЬТАТ:" + " s =" + s + " k=" + k + '\n');
        }
    }
}
