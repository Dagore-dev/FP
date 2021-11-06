using System;

namespace Funciones01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que te diga si un número es par o no. La función se llamará “Par” y nos devolverá un valor booleano que será “verdadero” si el número es par y “falso” si es impar.
        }
        static bool Par (int number)
        {
            bool result;

            if (number % 2 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
