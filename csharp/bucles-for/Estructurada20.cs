using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada20()
        {
            Console.WriteLine("Calcular el valor máximo de una serie de 10 números introducidos por teclado.");
            Console.WriteLine();

            int cont = 0, current, max;

            Console.WriteLine("Escribe 10 número enteros debajo, te diré el máximo:");
            current = int.Parse(Console.ReadLine());

            max = current;

            while (cont < 10)
            {
                current = int.Parse(Console.ReadLine());

                if (current > max)
                {
                    max = current;
                }

                cont++;
            }

            Console.WriteLine($"El mayor número de los que has introducido es {max}");

            Console.WriteLine();
        }
    }
}