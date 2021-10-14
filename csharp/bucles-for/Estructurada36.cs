using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada36()
        {
            //Escribe un programa que nos escriba los 10 primeros números que no sean múltiplos ni de 2 ni de 3.

            int i = 0, j = 0;

            while (i < 10)
            {
                if ((j % 2 != 0) && (j % 3 != 0))
                {
                    Console.WriteLine(j);
                    i++;
                }

                j++;
            }

            Console.WriteLine("\n");
        }
    }
}