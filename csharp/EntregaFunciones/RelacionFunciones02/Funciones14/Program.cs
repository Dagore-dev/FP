using System;

namespace Funciones14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “leeNatural” que nos lea un número natural desde el teclado.La función nos pondrá un texto en el que se nos indica que introduzcamos un número y después nos leerá el número del teclado. Si el número introducido es 0 o negativo, nos volverá a pedir otro número.
        }
        static int LeeNatural ()
        {
            int number;

            Console.Write("Introduce un número natural: ");
            number = int.Parse(Console.ReadLine());

            while (number <= 0)
            {
                Console.WriteLine("Los números naturales son los enteros positivos sin el cero.");
                Console.Write("Introduce un número natural: ");

                number = int.Parse(Console.ReadLine());
            }

            return number;
        }
    }
}
