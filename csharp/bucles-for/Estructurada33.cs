using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada33()
        {
            Console.WriteLine("Calcular en el mismo bucle el valor máximo, el valor mínimo y la media aritmética de una serie de 10 números enteros introducidos por teclado.");
            Console.WriteLine();

            int current, max, min;
            double sum;
            
            Console.WriteLine("Introduce una serie de 10 número enteros de uno en uno, te daré el máximo, el mínimo y la media aritmética:");
            current = int.Parse(Console.ReadLine());
            
            max = current;
            min = current;
            sum = current;

            for (int i = 1; i < 10; i++)
            {
                current = int.Parse(Console.ReadLine());

                sum += current;

                if (current > max)
                {
                    max = current;
                }

                if (current < min)
                {
                    min = current;
                }
            }

            Console.WriteLine($"El valor máximo es {max}, el mínimo {min} y la media aritmética {sum / 10}");

            Console.WriteLine();
        }
    }
}