using System;

namespace Estructurada40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que nos diga si un número es primo o no. Un número primo es aquel que solo es divisible por si mismo y por la unidad.

            int number, counter = 0;

            Console.Write("Introduce un número entero para comprobar si es primo: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                Console.WriteLine($"{number} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{number} no es un número primo.");
            }
        }
    }
}
