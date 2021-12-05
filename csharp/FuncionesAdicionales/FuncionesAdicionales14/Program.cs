using System;

namespace FuncionesAdicionales14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"El número 1 se corresponde con el mes de: {MesEnTexto(1)}");
            Console.WriteLine($"El número 3 se corresponde con el mes de: {MesEnTexto(3)}");
            Console.WriteLine($"El número 12 se corresponde con el mes de: {MesEnTexto(12)}");

            Console.WriteLine();

            Console.WriteLine("31/11/1990");
            EscribeFechaBonita(31, 11, 1990);
            
            Console.WriteLine();

            Console.WriteLine("29/02/2000");
            EscribeFechaBonita(29, 2, 2000);
            
            Console.WriteLine();

            Console.WriteLine("29/02/2001");
            EscribeFechaBonita(29, 2, 2001);
        }
        /*
        Escribe dos funciones:
            • Escribe la función MesEnTexto a la que le pasaremos un entero correspondiente a un mes y nos devolverá un string con ese mes escrito en texto. Por ejemplo: si le pasamos un 10 nos devolverá “octubre”.
            • Escribe la función EscribeFechaBonita. La función recibirá tres enteros por parámetro: el día, el mes y el año y nos escribirá la fecha por pantalla en el formato siguiente: “dia de mes de año” (ej.: 31/11/1980 = “31 de noviembre de 1980”). La función no devuelve nada porque escribe el resultado por pantalla. En esta función tendremos que usar la función anterior. Si la fecha que introducimos no es válida, nos escribirá “Fecha no válida” por pantalla en lugar de la fecha.
         */
        static string MesEnTexto (int month)
        {
            string result;
            string[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            if (month > 0 && month < 13)
            {
                result = months[month - 1];
            }
            else
            {
                result = "ERROR";
            }

            return result;
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
        static bool IsValidDate (int day, int month, int year)
        {
            bool isValidDate = true;

            if (day <= DiasMes2(month, year))
            {
                isValidDate = false;
            }

            return isValidDate;
        }
        static void EscribeFechaBonita (int day, int month, int year)
        {
            if (IsValidDate(day, month, year))
            {
                Console.WriteLine($"{day} de {MesEnTexto(month)} de {year}.");
            }
            else
            {
                Console.WriteLine("Fecha no válida.");
            }
        }
    }
}
