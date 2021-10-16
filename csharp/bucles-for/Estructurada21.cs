using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada21()
        {
            Console.WriteLine("Calcular en el mismo bucle el valor máximo, el valor mínimo y la media aritmética de una serie de 10 números introducidos por teclado.");
            Console.WriteLine();

            int counter = 0;
            double current, acumulator = 0, max, min;
            
            Console.WriteLine("Introduce los 10 números debajo. Te daré máximo, mínimo y media aritmética:");
            current = double.Parse(Console.ReadLine());

            max = current;
            min = current;

            while (counter < 10)
            {
                current = double.Parse(Console.ReadLine());

                if (current > max)
                {
                    max = current;
                }
                if (current < min)
                {
                    min = current;
                }

                acumulator += current;

                counter++;
            }

            Console.WriteLine($"El máximo es {max}, el mínimo {min} y la media se corresponde con {acumulator / counter}");

            Console.WriteLine();
        }
    }
}