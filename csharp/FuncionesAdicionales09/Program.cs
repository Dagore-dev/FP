using System;

namespace FuncionesAdicionales09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe una función BisiestosXXI que nos escriba por pantalla todos los años bisiestos del siglo XXI.
            BisiestosXXI();
        }
        static void BisiestosXXI ()
        {
            for (int year = 2000; year <= 2999; year++)
            {
                if (IsLeapYear(year))
                {
                    Console.Write(year + " ");
                }
            }
        }
        static bool IsLeapYear(int year)
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
