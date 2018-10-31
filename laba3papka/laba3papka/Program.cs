using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace laba3papka
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NOD del=new NOD();
            float r=1;
            float s = 1;
            Console.WriteLine("Введите количество чисел: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 1: ");
           int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите чило 2: ");
           int b = int.Parse(Console.ReadLine());
           int c=1;
           int d=1;
           int e=1;
            switch (k)
            {
                case 3:
                    Console.WriteLine("Введите число 3: ");
                    c = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Введите число 3: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число 4: ");
                   d = int.Parse(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Введите число 3: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число 4: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число 5: ");
                   e = int.Parse(Console.ReadLine());
                    break;

            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
           switch (k)
           {case 2:
                    r = del.ras_NOD(a, b);
                   break;
               case 3:
                   r = del.ras_NOD(a, b, c);
                   break;
               case 4:
                   r = del.ras_NOD(a, b, c,d);
                   break;
               case 5:
                    r = del.ras_NOD(a, b, c, d,e);
                   break;

           }
           stopWatch.Stop();
         
           TimeSpan ts = stopWatch.Elapsed;
           stopWatch.Start();
           s = del.ras_NOD_Stan(a, b);
           stopWatch.Stop();

           TimeSpan tss = stopWatch.Elapsed;
           Console.WriteLine("НОД по методу Евклида: " + r);
           Console.WriteLine("Время выполнения: " + ts);
            Console.WriteLine("НОД по методу Стейна: "+s);
            Console.WriteLine("Время выполнения: " + tss);
            Console.ReadKey();
    
        }

    }
   public class NOD
    {
         public int  ras_NOD(int a, int b)
       {
             while (a != 0 & b != 0)
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
           return a+b;
       }
           public int ras_NOD(int a, int b, int c)
           {
               int m = ras_NOD(a, b);
               m = ras_NOD(m, c);
               return m;
           }
           public int ras_NOD(int a, int b, int c, int d)
           {
               int m = ras_NOD(a, b,c);
               m = ras_NOD(m, d);
               return m;
           }
           public int ras_NOD(int a, int b, int c, int d,int e)
           {
               int m = ras_NOD(a, b, c,d);
               m = ras_NOD(m, e);
               return m;
           }
           public int ras_NOD_Stan(int a, int b)
           {
              
               if (a == 0)
                  return b;                               // НОД(0, b) = b

               if (b == 0)
            return a;                            // НОД(a, 0) = a
               if (a == b)

                   return a;                      // НОД(a, a) = a
               if (a == 1 || b == 1)
                   return 1;
               if (a % 2 == 0 & b % 2 == 0)
                   return 2 * ras_NOD_Stan(a / 2, b / 2);   //Если a, b чётные, то НОД(a, b) = 2*НОД(a/2, b/2)
              if (a % 2 == 0 & b % 2 == 1)
                  return ras_NOD_Stan(a / 2, b);     //Если a чётное, b нечётное, то НОД(a, b) = НОД(a/2, b)
               if (a % 2 == 1 & b % 2 == 0)
                   return ras_NOD_Stan(a, b / 2);    // Если b чётное, a нечётное, то НОД(a, b) = НОД(a, b/2)
               if (a % 2 == 1 & b % 2 == 1 )
                   return ras_NOD_Stan(a, Math.Abs((b - a) / 2));   //  Если a, b нечётные и b > a, то НОД(a, b) = НОД(a, (b-a)/2)
               return 1;
           }
          
    }

}
