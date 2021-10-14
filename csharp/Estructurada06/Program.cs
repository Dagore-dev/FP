using System;

namespace Estructurada06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinar el número de cifras de un número entero. El algoritmo debe funcionar para números de hasta 5 cifras, considerando los negativos.Por ejemplo, si se introduce el número 5342, la respuesta del programa debe ser 4.Si se introduce -250, la respuesta debe ser 3.

            string input;
            bool isParsable;
            int result;

            Console.WriteLine("Introduce un número entero.");

            input = Console.ReadLine();

            isParsable = Int32.TryParse(input, out result);

            if (isParsable)
            {
                if(result > 0)
                {
                    result = input.Length;
                }
                else
                {
                    result = input.Length - 1;
                }
                
                Console.WriteLine($"{input} tiene {result} cifras.");
            }
            else
            {
                Console.WriteLine("Introduzca un input válido.");
            }

        }
    }
}
