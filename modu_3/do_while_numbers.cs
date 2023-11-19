using System;

namespace demo1411
{
    class Program
    {
        /// <summary>
        /// Ввести	последовательность	натуральных	чисел, закончив ее нулем. 
        /// Проверить упорядоченность этой последовательности по возрастанию.
        /// </summary>
        static void Main()
        {
            var rand = new Random();
            var condition = rand.NextDouble() > 0.5;

            int? x = condition ? 12 : null;
            Console.WriteLine(x);

            int next = 0; 
            bool ok = true;

            Console.Write("start = ");
            int prev = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("x = ");
                next = int.Parse(Console.ReadLine()); 
                if (next != 0)
                    ok = next >= prev; 
                prev = next;
            }
            while (ok && (next != 0)); 
            
            if (ok)
                Console.WriteLine("Последовательность упорядочена");
            else
                Console.WriteLine("Последовательность не упорядочена"); 
            Console.ReadKey();
        }
    }
}
