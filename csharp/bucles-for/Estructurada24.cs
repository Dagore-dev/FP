using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada24()
        {
            Console.WriteLine("Escribe un programa que nos escriba los números impares comprendidos entre 1 y 10.");
            Console.WriteLine();

            for (int i = 1; i < 11; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
    }
}