using System;

namespace Пример_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, p, n;
            s = 0;
            p = 1;
            for (n = 1; n <= 10; n++) // или n += 1
            {
                s = s + n;
                p = p * n;
                Console.WriteLine("n=" + n + " s=" + s + " p=" + p);
            }
        }
    }
}
