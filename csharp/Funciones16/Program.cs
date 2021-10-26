using System;

namespace Funciones16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “elevado” a la que le pasas dos números enteros (a y b) y te devuelve el valor de “a” elevado a “b” (sin usar la función Math.pow) (o sea, multiplicando un número muchas veces).
            
            Console.WriteLine($"2^2 = {Elevado(2, 2)}");
            Console.WriteLine($"-2^2 = {Elevado(-2, 2)}");
            Console.WriteLine($"2^3 = {Elevado(2, 3)}");
            Console.WriteLine($"2^0 = {Elevado(2, 0)}");
        }
        static int Elevado (int a, int b)
        {
            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}
