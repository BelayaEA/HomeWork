using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5papka1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый вектор: ");
            Console.WriteLine("Введите координату Х: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Z: ");
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Второй вектор: ");
            Console.WriteLine("Введите координату Х: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Z: ");
            double z2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            double r = double.Parse(Console.ReadLine());
            Vector v1 = new Vector(x1,y1,z1);
            Vector v2 = new Vector(x2, y2, z2);
           double dl = v1.Dlina();
           Vector v3 = v1 + v2;
           Vector v4 = v1 - v2;
           Vector v5 = v1*r;
           double  v6 = v1 * v2;
           Console.WriteLine("Длина вектора: "+ dl);
           Console.WriteLine("Сумма векторов: ");
           Console.WriteLine("X="+ v3.X);
           Console.WriteLine("Y=" + v3.Y);
           Console.WriteLine("Z=" + v3.Z);
           Console.WriteLine("Разность векторов: ");
           Console.WriteLine("X=" + v4.X);
           Console.WriteLine("Y=" + v4.Y);
           Console.WriteLine("Z=" + v4.Z);
           Console.WriteLine("Уножение вектора на число: ");
           Console.WriteLine("X=" + v5.X);
           Console.WriteLine("Y=" + v5.Y);
           Console.WriteLine("Z=" + v5.Z);
           Console.WriteLine("Скалярное произведение= "+v6);
           Console.ReadKey();
        }
    }
    public class Vector
    {
        public Vector(double x, double y, double z) //конструктор
        {   X = x;
            Y = y;
            Z = z; }
        public double x, y, z;
        public double X
        {  get;
            set;  }
        public double Y
        {   get;
            set;  }
        public double Z
        {  get;
            set; }

        public double Dlina()
        {

            return Math.Round(Math.Sqrt(X * X + Y * Y + Z * Z), 2);
           
        }
        public static Vector operator +(Vector l, Vector r) //сложение
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
        public static Vector operator -(Vector l, Vector r) //вычитание
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }
        public static Vector operator *(Vector v, double r) // умножение на число
        {
            return new Vector(v.X * r, v.Y * r, v.Z * r);
        }
        public static double operator *(Vector l, Vector r) //скалярное произведение
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }

    }

}
