using System;

namespace Estructurada32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el valor máximo de una serie de 10 números introducidos por teclado.

            int current, max;

            Console.WriteLine("Introduce los 10 números debajo de uno en uno, te daré el máximo:");
            current = int.Parse(Console.ReadLine());

            max = current;

            for (int i = 1; i < 9; i++)
            {
                current = int.Parse(Console.ReadLine());

                if (current > max)
                {
                    max = current;
                }
            }

            Console.WriteLine(max);
        }
    }
}
