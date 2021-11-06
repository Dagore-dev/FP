using System;

namespace Funciones17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “Factorial” que nos calcule el factorial de un número entero positivo.
        }
        static int Factorial (int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number *= Factorial(number - 1);
        }
    }
}
