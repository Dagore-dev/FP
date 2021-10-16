using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada11()
        {
            Console.WriteLine("Escribe un programa que nos escriba los 10 primeros números pares.");
            Console.WriteLine();

            int i = 0, acc = 0;

            while (acc < 10)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    acc++;
                }

                i++;
            }

            Console.WriteLine();
        }
    }
}