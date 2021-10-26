using System;
using System.IO;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, S, a, ch, zn;
            int k;
        m1: Console.WriteLine(" Введите значение х");
            Console.WriteLine(" 1/√3 = 0,57735026919." + '\n'+ " -1/√3 = -0,57735026919.");
            x = double.Parse((Console.ReadLine()));
            Console.WriteLine('\t' + "Промежуточные результати " + '\n');
            k = 0;
            S = 0; zn = 1;
            a = x;
            ch = x;
            while (Math.Abs(a) >= 0.000001)
            {
                S += a;
                k++;
                zn += 2;
                ch = ch * x * x * (-1);
                a = ch / zn;
                Console.WriteLine('\t' + " Итерация №" + k + '\n' + " a = " + a + " S = "
               + S + "\n");
            }
            y = Math.Atan(x);
            Console.WriteLine('\t' + " Результаты:" + '\n' + " Заданый х = " + x +
           '\n' + " Вычеслиная сумма ряда S = " + S + '\n' + " Количество членов ряда " +
           k + '\n' + " Функция Arctgx = " + y + '\n');
            Console.WriteLine('\n' + "Для повторного ввода" + " Набрать любую клавишу." + '\n' + " Для завершения программы нажмите Enter.");
            string rep = Console.ReadLine();
            if (rep != "") goto m1;
        }
    }
}
