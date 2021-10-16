using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada06()
        {
            Console.WriteLine("Determinar el número de cifras de un número entero. El algoritmo debe funcionar para  números de hasta 5 cifras, considerando los negativos.Por ejemplo, si se introduce el número 5342, la respuesta del programa debe ser 4. Si se introduce - 250, la respuesta debe ser 3.");
            Console.WriteLine();

            int number, counter = 0, factor = 1;

            Console.Write("Introduce un número entero: ");

            number = Math.Abs(int.Parse(Console.ReadLine()));

            while (number / factor >= 1)
            {
                factor *= 10;
                counter++;
            }

            Console.WriteLine(counter);

            Console.WriteLine();
        }
    }
}