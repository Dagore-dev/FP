﻿using System;

namespace Funciones17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “factorial” que nos calcule el factorial de un número entero.

            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(0));

        }

        static int Factorial (int number)
        {
            int result = 1;

            if (result == 0)
            {
                return 1;
            }
            
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}