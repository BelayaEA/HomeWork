using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_2zad
{
    class Program
    {
        static void Main(string[] args)
        { {
            string r;
          
            Console.WriteLine("Введите десятичное число: ");
            string sn = Console.ReadLine();
            double x = double.Parse(sn);
            int xx = int.Parse(sn);
            r = Convert.ToString(xx, 2);
            Console.WriteLine("Результат стандартной функции: " + r);
            r = "";
            while (x != 0)
            {
                if ((x % 2) == 0)
                {
                    x = x / 2;
                    r = "0"+r;
                }
                else
                {
                    x = x / 2;
                    x = Math.Floor(x);
                    r = "1"+r;
                }
            }
            Console.WriteLine("Результат собственного алгоритма: " + r);

             Console.ReadKey();
        }
    }
        }
    }

