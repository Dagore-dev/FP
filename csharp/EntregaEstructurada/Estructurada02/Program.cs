using System;

namespace Estructurada02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinar si un año es bisiesto o no (los años bisiestos son múltiplos de 4; utilícese el operador módulo).

            int year;

            Console.Write("Introduce un año para saber si es bisiesto: ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine($"{year} es un año bisiesto.");
            }
            else
            {
                Console.WriteLine($"{year} no es un año bisiesto.");
            }
        }
    }
}
