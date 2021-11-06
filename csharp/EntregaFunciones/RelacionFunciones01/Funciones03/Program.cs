using System;

namespace Funciones03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “TablaMultiplicar” a la que le pases un entero y nos escriba la tabla de multiplicar de ese número.
        }
        static void TablaMultiplicar (int number)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
