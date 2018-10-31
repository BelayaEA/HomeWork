using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_1zad
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            string sx = Console.ReadLine();
            float x = float.Parse(sx); //преобразование строки в число
            Console.WriteLine("Введите степень корня: ");
            string sn = Console.ReadLine();
            float n = float.Parse(sn); //преобразование строки в число
            Console.WriteLine("Введите точность: ");
            string st = Console.ReadLine();
            float t = float.Parse(st); //преобразование строки в число

            double res1 = SqrtN(n, x, t);

            Console.WriteLine("Результат метода Ньютона: " + res1);

            float nn = 1 / n;
            double res2 = Math.Pow(x, nn);
            Console.WriteLine("Результат методра Math.Pow: " + res2);

            double otkl = res1 - res2;
            Console.WriteLine("Отклонение:" + "{0:####.##############}", otkl);

            Console.ReadKey();
        }

        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }

        static double SqrtN(double n, double A, double eps)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
            }

            return x1;
        }
    }
}

