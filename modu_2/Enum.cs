using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    class Program
    {
        enum Gradus : int
        {
            min = 0,
            krit = 50,
            max = 100,
        }

        static void Main()
        {
            Gradus minValueGr = Gradus.min;
            Gradus kritValueGr = Gradus.krit;
            Console.WriteLine("минимальная температура = " + (int)minValueGr);
            Console.WriteLine("критическая температура = " + (int)kritValueGr);
            Console.WriteLine("максимальная температура = " + (int)Gradus.max);
            Console.WriteLine(Convert.ToString(kritValueGr));
            Console.WriteLine(kritValueGr);
          int tr;
          for (tr = 0; tr < 250; tr++)
          {
              if (tr < (int)kritValueGr)
                  Console.WriteLine("Процесс разрешен, температура " + tr);
              else
                  break;
          }
          Console.WriteLine("Стоп, температура " + tr);
        }
    }
}
