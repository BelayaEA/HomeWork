using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace laba4papka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону c: ");
            int c = int.Parse(Console.ReadLine());
            
            Treugolnik t=new Treugolnik();
           int s= t.Sushchest(a, b, c);
            float per = t.PP(a, b, c);
            double pl = t.Pl(a, b, c);
            Console.WriteLine("Площадь треугольника = " + "{0:##.##}", pl);
            Console.WriteLine("Периметр треугольника = " + per);
            Console.ReadKey();
        }
      
    }
    public class Treugolnik
    {
        public int Sushchest(int a, int b, int c)
        {
            if (a + b > c & a + c > b & b + c > a)
            {
                Console.WriteLine("Треугольник существует");
                return 1;
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
                return 0;
            }
        }

        public float PP(float a, float b, float c)
        {

            return a + b + c;

        }
        public double Pl(float a, float b, float c)
        {
            float k;

            k = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(k), 2);

        }
    }
}
