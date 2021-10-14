using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada29()
        {
            // Escribir todos los números impares entre dos números enteros A y B introducidos por teclado. Antes habrá que comprobar cuál de los dos números A y B es mayor.
            Console.WriteLine("Dime un número entero.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro número entero.");
            int num2 = int.Parse(Console.ReadLine());

            int min, max;

            if (num1 < num2)
            {
                min = num1; max = num2;
            }
            else
            {
                min = num2; max = num1;
            }

            for (int i = min; i < max + 1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\n");
        }
    }
}