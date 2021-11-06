using System;

namespace Estructurada21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular en el mismo bucle el valor máximo, el valor mínimo y la media aritmética de una serie de 10 números introducidos por teclado. 

            int counter = 0;
            double acumulator = 0, current, max, min;

            Console.WriteLine("Introduce 10 números. Te daré máximo, mínimo y media aritmética.");
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
        }
    }
}
