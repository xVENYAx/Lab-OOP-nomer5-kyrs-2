using System;
using System.IO;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
			StreamWriter p = new StreamWriter("rezy.txt");
			float a, x;
			p.WriteLine("       РЕЗУЛЬТАТЫ РАЗЧЁТА");
			for (a = 1; a <= 4; a += 1)  // Заголовок внешнего цикла по а
			{
				// Начало внешнего цикла по а
				p.WriteLine(" a=" + a);
				for (x = -4; x <= 4.2; x += 0.2f) // Заголовок внутреннего цикла по х

				{
                    if (x > -0.1)
                    {
						if(a==1)
                        {
							if (x == 0)
							{
								float m, k;
								float z = x + a;
								float b = a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(b, n);
								float g = -k;
								float l = m - g;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if(x>0 && x<1)
                            {
								float m, k;
								float z = x + a;
								float b = x - a;
								float n = 2 / 3f;
								double o = -b;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(o, n);
								float r = -k;
								float l = m - r;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x>1)
                            {
								float m, k;
								float z = x + a;
								float b = x - a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(b, n);
								float l = m - k;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
                        }
						if (a == 2)
						{
							if (x == 0)
							{
								float m, k;
								float z = x + a;
								float b = a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(b, n);
								float g = -k;
								float l = m - g;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x > 0 && x < 2)
							{
								float m, k;
								float z = x + a;
								float b = x - a;
								float n = 2 / 3f;
								double o = -b;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(o, n);
								float r = -k;
								float l = m - r;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x > 2)
							{
								float m, k;
								float z = x + a;
								float b = x - a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(b, n);
								float l = m - k;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
						}
						if(a==3)
                        {
							if (x == 0)
							{
								float m, k;
								float z = x + a;
								float b = a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(b, n);
								float g = -k;
								float l = m - g;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x > 0 && x < 3)
							{
								float m, k;
								float z = x + a;
								float b = x - a;
								float n = 2 / 3f;
								double o = -b;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(o, n);
								float r = -k;
								float l = m - r;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if(x==3)
                            {
								float m;
								float z = x + a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								float l = m;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x > 3 && x < 4.2)
							{
								float m, k;
								float z = x + a;
								float b = x - a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(b, n);
								float l = m - k;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}

						}
						if (a == 4)
						{
							if (x == 0)
							{
								float m, k;
								float z = x + a;
								float b = a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(b, n);
								float q = -k;
								float l = m - q;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x > 0 && x < 4)
							{
								float m, k;
								float z = x + a;
								float b = x - a;
								float n = 2 / 3f;
								double o = -b;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(o, n);
								float r = -k;
								float l = m - r;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x == 4)
							{
								float m;
								float z = x + a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								Console.WriteLine("m=" + m);
								float l = m;
								Console.WriteLine("l=" + l);
								float y = l / a;
								Console.WriteLine("y=" + y);
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x > 4)
							{
								float m;
								float z = x + a;
								float n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								Console.WriteLine("m=" + m);
								float l = m;
								Console.WriteLine("l=" + l);
								float y = l / a;
								Console.WriteLine("y=" + y);
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
						}
					}
					else
                    {
						if(a==1)
                        {
							if(x <-1 && x>-4.2)
							{
								float m, k;
								double z = x + a;
								double b = x - a;
								double o = -b;
								double u = -z;
								float n = 2 / 3f;
								m = (float)Math.Pow(u, n);
								k = (float)Math.Pow(o, n);
								float i = -k;
								float t = -m;
								float l = t - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x == -1)
							{
								float k;
								float r = 0;
								double b = x - a;
								double o = -b;
								double n = 2 / 3f;
								k = (float)Math.Pow(o, n);
								float i = -k;
								float l = r - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x < 0 && x > -1)
								{
									float m, k;
									double z = x + a;
									double b = x - a;
									double o = -b;
									double n = 2 / 3f;
									m = (float)Math.Pow(z, n);
									k = (float)Math.Pow(o, n);
									float i = -k;
									float l = m - i;
									float y = l / a;
									p.WriteLine("   x= " + x + '\t' + "   y= " + y);
								}
						}
						if(a==2)
                        {
							if (x < -2 && x > -4.2)
							{
								float m, k;
								double z = x + a;
								double b = x - a;
								double o = -b;
								double u = -z;
								float n = 2 / 3f;
								m = (float)Math.Pow(u, n);
								k = (float)Math.Pow(o, n);
								float i = -k;
								float t = -m;
								float l = t - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x == -2)
							{
								float k;
								float r = 0;
								double b = x - a;
								double o = -b;
								double n = 2 / 3f;
								k = (float)Math.Pow(o, n);
								float i = -k;
								float l = r - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x < 0 && x > -2)
							{
								float m, k;
								double z = x + a;
								double b = x - a;
								double o = -b;
								double n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(o, n);
								float i = -k;
								float l = m - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
						}
						if(a==3)
                        {
							if (x < -3 && x > -4.2)
							{
								float m, k;
								double z = x + a;
								double b = x - a;
								double o = -b;
								double u = -z;
								float n = 2 / 3f;
								m = (float)Math.Pow(u, n);
								k = (float)Math.Pow(o, n);
								float i = -k;
								float t = -m;
								float l = t - i;
								float y = l / a;
								Console.WriteLine("y=" + y);
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x == -3)
							{
								float k;
								float r = 0;
								double b = x - a;
								double o = -b;
								double n = 2 / 3f;
								k = (float)Math.Pow(o, n);
								float i = -k;
								float l = r - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x < 0 && x > -3)
							{
								float m, k;
								double z = x + a;
								double b = x - a;
								double o = -b;
								double n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(o, n);
								float i = -k;
								float l = m - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
						}
						if (a == 4)
						{
							if (x < 0 && x>-4)
							{
								float m, k;
								double z = x + a;
								double b = x - a;
								double o = -b;
								double n = 2 / 3f;
								m = (float)Math.Pow(z, n);
								k = (float)Math.Pow(o, n);
								float i = -k;
								float l = m - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
							if (x == -4)
							{
								float k;
								float r = 0;
								double b = x - a;
								double o = -b;
								double n = 2 / 3f;
								k = (float)Math.Pow(o, n);
								float i = -k;
								float l = r - i;
								float y = l / a;
								p.WriteLine("   x= " + x + '\t' + "   y= " + y);
							}
						}
					}
				}	
			}
			p.Close();
		}
    }
}
