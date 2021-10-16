using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada10()
        {
            Console.WriteLine(" Escribe un programa que nos escriba los números impares comprendidos entre 1 y 10.");
            Console.WriteLine();

            int i = 1;

            while (i < 11)
            {
                Console.WriteLine(i);
                i += 2;
            }

            Console.WriteLine();
        }
    }
}