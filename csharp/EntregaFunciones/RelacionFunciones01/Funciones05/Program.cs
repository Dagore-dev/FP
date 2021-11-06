using System;

namespace Funciones05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “Signo” a la que le pasemos un número y nos devuelva “1” si es positivo, “0” si es cero y “-1” si es negativo.
        }
        static int Signo (int number)
        {
            int result;

            if (number > 0)
            {
                result = 1;
            }
            else
            {
                if (number == 0)
                {
                    result = 0;
                }
                else
                {
                    result = -1;
                }
            }

            return result;
        }
    }
}
