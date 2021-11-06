using System;

namespace Funciones16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “Elevado” a la que le pasas dos números enteros (a y b) y te devuelve el valor de “a” elevado a “b” (sin usar la función Math.pow) (o sea, multiplicando un número muchas veces).
        }
        static double Elevado (int a, int b)
        {
            double result = 1.0, aa = a;

            if (b < 0)
            {
                b *= -1;

                aa = 1.0 / a;
            }

            for (int i = 0; i < b; i++)
            {
                result *= aa;
            }

            return result;
        }

    }
}
