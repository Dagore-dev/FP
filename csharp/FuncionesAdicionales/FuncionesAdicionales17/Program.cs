using System;

namespace FuncionesAdicionales17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01/01/1980");
            Console.WriteLine(FechaCorrecta(1, 1, 1980));

            Console.WriteLine();

            Console.WriteLine("31/12/2100");
            Console.WriteLine(FechaCorrecta(31, 12, 2100));

            Console.WriteLine();

            Console.WriteLine("29/02/2000");
            Console.WriteLine(FechaCorrecta(29, 2, 2000));

            Console.WriteLine();

            Console.WriteLine("29/02/2001");
            Console.WriteLine(FechaCorrecta(29, 2, 2001));
        }
        #region Utils
        static int DiasMes(int month)
        {

            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return monthDays[month - 1];
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
        static int DiasMes2(int month, int year)
        {
            int days;
            if (IsLeapYear(year) && month == 2)
            {
                days = 29;
            }
            else
            {
                days = DiasMes(month);
            }

            return days;
        }
        #endregion
        static bool FechaCorrecta (int day, int month, int year)
        {
            /*
            Escribe la función FechaCorrecta a la que le pasamos tres enteros con el día, el mes y el año y nos devuelve true si la fecha es correcta y false si no lo es. Para que la fecha sea correcta, el año tendrá que estar entre 1980 y 2100, el mes entre 1 y 12 (obviamente) y el día tiene que ser un día válido de ese mes.
            Ej.: FechaCorrecta(31, 4, 2020) daría false porque abril tiene sólo 30 días. 
            */
            bool result = false;

            if (month > 0 && month < 13 && year > 1979 && year < 2101)
            {
                if (day <= DiasMes2(month, year))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
