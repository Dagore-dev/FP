using System;

namespace bucles_for
{
    partial class Program
    {

        private static void Estructurada25()
        {
            Console.WriteLine("Escribe un programa que nos escriba los 10 primeros números pares.");
            Console.WriteLine();

            int counter = 0;

            for (int i = 0; counter < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }

            Console.WriteLine();
        }
    }
}