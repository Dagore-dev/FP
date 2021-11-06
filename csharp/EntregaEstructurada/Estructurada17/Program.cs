using System;

namespace Estructurada17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular la suma de todos los números pares entre 1 y 1000. Es decir, 2 + 4 + 6 + ... + 998 +1000.

            int i = 1;
            int acc = 0;

            while (i < 1001)
            {
                if (i % 2 == 0)
                {
                    acc += i;
                }

                i++;
            }

            Console.WriteLine(acc);
        }
    }
}
