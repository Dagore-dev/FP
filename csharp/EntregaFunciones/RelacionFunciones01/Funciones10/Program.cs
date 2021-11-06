using System;

namespace Funciones10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “Primo” que nos devuelva “verdadero” si el número que le pasamos por parámetro es primo y “falso” en caso contrario.
        }
        static bool Primo (int number)
        {
            bool result;
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
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
