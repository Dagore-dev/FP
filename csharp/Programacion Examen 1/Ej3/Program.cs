using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumeroCifras(458457));
            Console.WriteLine(NumeroCifras(-458457));
            Console.WriteLine(NumeroCifras(0));
            Console.WriteLine(NumeroCifras(10));
            Console.WriteLine(NumeroCifras(-10));
        }
        static int NumeroCifras (int num1)
        {
            int result = 0;

            if (num1 == 0)
            {
                result++;
            }
            else
            {
                num1 = Math.Abs(num1);

                while (num1 > 0)
                {
                    num1 /= 10;
                    result++;
                }
            }

            return result;
        }
    }
}
