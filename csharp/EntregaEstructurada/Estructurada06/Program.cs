using System;

namespace Estructurada06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinar el número de cifras de un número entero. El algoritmo debe funcionar para números de hasta 5 cifras, considerando los negativos.Por ejemplo, si se introduce el número 5342, la respuesta del programa debe ser 4.Si se introduce -250, la respuesta debe ser 3.

            int number, result = 0;

            Console.WriteLine("Introduce un número entero.");
            number = Math.Abs(int.Parse(Console.ReadLine()));

            if (number != 0)
            {
                while (number > 0)
                {
                    number /= 10;
                    result++;
                }
            }
            else
            {
                result = 1;
            }

            Console.WriteLine($"Tiene {result} cifras.");
        }
    }
}
