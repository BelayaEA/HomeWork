using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6papka
{
    interface IConvertible  // определяем интерфейс
    {
        string ConvertToCSharp(string vh);  //методы интерфейса
        string ConvertToVB(string vh);
    }
    interface ICodeChecker  // определяем интерфейс
    {
        bool CheckCodeSyntax(string vh, string vih);  //методы интерфейса
    }
    class ProgramConverter : IConvertible  // родительский класс, реализующий интерфейс
    {
        string IConvertible.ConvertToCSharp(string vh)
        {
            return vh;
        }
        string IConvertible.ConvertToVB(string vh)
        {
            return vh;
        }
    }
    class ProgramHelper : ProgramConverter,  ICodeChecker  //дочерний класс, реализующий интерфейс
{
  
   bool ICodeChecker.CheckCodeSyntax(string vh, string vih)
   {
       if (vh == vih)
           return true;
       else
           return false;
   }
    static void Main()
   {
       bool sr;
       string sss1, sss2;


        // массив объектов
        ProgramConverter[] masobj = new ProgramConverter[5];
        for (int i = 0; i < 5; i++)
        {
            if ((i%2)==0)
            {
                masobj[i] = new ProgramConverter();
             }
            else
            {
                   masobj[i] = new ProgramHelper();
             }
        }
        Console.WriteLine("Работа с массивом объектов: ");
        int ii=1;
        foreach(ProgramConverter t in masobj) // цикл по массиву объектов
        {
            Console.WriteLine("Объект: "+ii);
            ICodeChecker Iobj2 = t as ICodeChecker;
            if (Iobj2!=null) // проверка на реализацию интерфейса
            {
                Console.WriteLine("Метод CheckCodeSyntax: ");
                 sr = Iobj2.CheckCodeSyntax("VB", "CSharp");
                  if (sr)
                    Console.WriteLine("Строка для проверки написана на языке VB"); 
                 else
                     Console.WriteLine("Строка для проверки написана на языке CSharp"); 
            }
            else 
            {   IConvertible Iobj3 = t as IConvertible;
                Console.WriteLine("Метод ConvertToCSharp: ");
                sss1 = Iobj3.ConvertToCSharp("Преобразование строки VB в CSarp");
               Console.WriteLine(sss1);
                Console.WriteLine("Метод ConvertToVB: ");
                sss2 = Iobj3.ConvertToVB("Преобразование строки CSarp в VB");
                Console.WriteLine(sss2);
            }
            ii++;
        }
        Console.ReadKey();
   }
}

}
