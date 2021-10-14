using System;

namespace Estructurada02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinar si un año es bisiesto o no (los años bisiestos son múltiplos de 4; utilícese el operador módulo).

            string input;
            bool isParsable;
            int year;

            Console.WriteLine("Introduce un año para saber si es bisiesto");

            input = Console.ReadLine();
            
            isParsable = Int32.TryParse(input, out year);

            if (isParsable)
            {
                if(year % 4 == 0)
                {
                    Console.WriteLine($"{year} es un año bisiesto.");
                }
                else
                {
                    Console.WriteLine($"{year} no es un año bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("Introduzca un input válido.");
            }
        }
    }
}
