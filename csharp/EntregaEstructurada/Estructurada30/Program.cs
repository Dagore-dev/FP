using System;

namespace Estructurada30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular la suma de todos los números pares entre 1 y 1000. Es decir, 2 + 4 + 6 + ... + 998 + 1000.

            int sum = 0;

            for (int i = 0; i < 1001; i += 2)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
