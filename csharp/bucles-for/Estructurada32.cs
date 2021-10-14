using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada32()
        {
            //Calcular el valor máximo de una serie de 10 números introducidos por teclado.
            Console.WriteLine("Introduce una serie de 10 número enteros de uno en uno, te daré el máximo");
            int current = int.Parse(Console.ReadLine());
            int max = current;


            for (int i = 1; i < 10; i++)
            {
                current = int.Parse(Console.ReadLine());

                if (current > max)
                {
                    max = current;
                }
            }

            Console.WriteLine(max);

            Console.WriteLine("\n");
        }
    }
}