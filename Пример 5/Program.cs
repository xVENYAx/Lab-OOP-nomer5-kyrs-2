using System;
using System.IO;

namespace Пример_5
{
    class Program
    {
        static void Main(string[] args)
        {
			StreamWriter p = new StreamWriter("rez.txt");
			float a, x, y;
			p.WriteLine("       РЕЗУЛЬТАТЫ РАЗЧЁТА");
			for (a = 1; a <= 2; a += 0.5f)  // Заголовок внешнего цикла по а
			{
				// Начало внешнего цикла по а
				p.WriteLine(" a=" + a);
				for (x = 1; x <= 7; x += 0.25f) // Заголовок внутреннего цикла по х

				{
					// Начало внутренего цикла по х
					y = (float)(a * Math.Cos(x) / Math.Sqrt(1 + a * x * x));
					p.WriteLine("   x= " + x + '\t' + "   y= " + y);
					/* Конец внутреннего цикла по х */
				}
				/* Конец внешнего цикла по а */
			}
			p.Close();
		}
    }
}
