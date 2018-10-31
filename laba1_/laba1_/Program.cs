using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х: ");
            string sx = Console.ReadLine();
            float x = float.Parse(sx);
            Console.WriteLine("Введите координату Y: ");
            string sy = Console.ReadLine();
            float y = float.Parse(sy);
            Console.WriteLine("X:{0:####.###}", x);
            Console.WriteLine("Y:{0:####.###}", y);


            System.Console.WriteLine("----------------------------------------------");
            string line;
            string line1 = "";

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Lena\Documents\Visual Studio 2012\Projects\laba1_\laba1.txt");
            System.IO.StreamWriter file_w = new System.IO.StreamWriter("C:\\Users\\Lena\\Documents\\Visual Studio 2012\\Projects\\laba1_\\laba1w.txt", true, Encoding.ASCII);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine("Строка в файле: " + line);
                System.Console.WriteLine("Результат: ");
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        x = float.Parse(line1); //преобразование строки в число
                        Console.WriteLine("X:{0:##.###}", x);
                        file_w.Write("X:{0:##.###}", x);
                        line1 = "";
                    }
                    else
                    {
                        line1 += line[i];
                    }
                }
                y = float.Parse(line1);
                Console.WriteLine("Y:{0:##.###}", y);
                file_w.Write("\n Y:{0:##.###}", y);
                line1 = "";
            }

            file.Close();
            file_w.Close();

            System.Console.ReadLine();
            Console.ReadKey();
        }

    }
}