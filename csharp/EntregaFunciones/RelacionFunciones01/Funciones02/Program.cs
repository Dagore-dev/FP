using System;

namespace Funciones02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que nos diga si un año es bisiesto o no. La función se llamará “Bisiesto” y nos devolverá “verdadero” si es bisiesto y “falso” si no lo es.
        }
        static bool Bisiesto (int year)
        {
            bool isLeapYear;

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    isLeapYear = false;
                }
                else
                {
                    isLeapYear = true;
                }
            }
            else
            {
                isLeapYear = false;
            }

            return isLeapYear;
        }
    }
}
