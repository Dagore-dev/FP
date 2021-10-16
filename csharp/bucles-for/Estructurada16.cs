using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada16()
        {
            Console.WriteLine("  Escribir todos los números impares entre dos números A y B introducidos por teclado. Antes habrá que comprobar cuál de los dos números A y B es mayor.");
            Console.WriteLine();

            int a, b, min, max;

            Console.Write("Dame el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dame el segundo número: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                min = a; max = b;
            }
            else
            {
                min = b; max = a;
            }

            while (min <= max)
            {
                if (min % 2 != 0)
                {
                    Console.WriteLine(min);
                }

                min++;
            }

            Console.WriteLine();
        }
    }
}