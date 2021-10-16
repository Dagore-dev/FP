using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada17()
        {
            Console.WriteLine("Calcular la suma de todos los números pares entre 1 y 1000. Es decir, 2 + 4 + 6 + ... + 998 + 1000.");
            Console.WriteLine();

            int i = 1, acc = 0;

            while (i < 1001)
            {
                if (i % 2 == 0)
                {
                    acc += i;
                }

                i++;
            }

            Console.WriteLine(acc);
        
            Console.WriteLine();
        }
    }
}