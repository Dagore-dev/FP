using System;

namespace Estructurada22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un número entero positivo para que obtenga su factorial.");
            int num = int.Parse(Console.ReadLine());
            
            int acumulator = 1;

            while (num > 0)
            {
                acumulator *= num;

                num--;
            }

            Console.WriteLine($"El factorial resulta {acumulator}.");
        }
    }
}
