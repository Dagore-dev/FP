using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada02()
        {
            Console.WriteLine("Determinar si un año es bisiesto o no (los años bisiestos son múltiplos de 4; utilícese el operador módulo).");
            Console.WriteLine();

            int year;

            Console.WriteLine("Introduce un año para saber si es bisiesto");

            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine($"{year} es un año bisiesto.");
            }
            else
            {
                Console.WriteLine($"{year} no es un año bisiesto.");
            }

            Console.WriteLine();
        }
    }
}