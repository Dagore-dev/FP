using System;

namespace FuncionesAdicionales07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                https://www.codespeedy.com/print-calendar-for-a-specific-year-in-cpp/
                
                Escribe la función calendarioGrafico a la que le pasas dos parámetros: el mes y el año. La función nos escribirá por pantalla un calendario del mes indicado.
                
                Ej.: 11/2012
                 L  M  X  J  V  S  D
                          1  2  3  4
                 5  6  7  8  9 10 11
                12 13 14 15 16 17 18
                19 20 21 22 23 24 25
                26 7 28 29 30
            */

            CalendarioGrafico(10, 2021);
        }
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
        static int DiasTranscurridos(int day, int month, int year)
        {
            int acc = 0;

            for (int i = 1; i < month; i++)
            {
                acc += DiasMes2(i, year);
            }

            return acc + day;
        }
        static int DiasTranscurridos1980(int day, int month, int year)
        {
            int acc = 0;

            for (int i = 1980; i < year - 1; i++)
            {
                acc += DiasTranscurridos(31, 12, i);
            }

            return acc + DiasTranscurridos(day, month, year);
        }
        static int DiaSemanaFecha(int day, int month, int year)
        {
            int weekDay = 2, numberOfDays = DiasTranscurridos1980(day, month, year);

            for (int i = 0; i <= numberOfDays; i++)
            {
                weekDay++;

                if (weekDay > 7)
                {
                    weekDay = 1;
                }
            }

            return weekDay;
        }
        static void CalendarioGrafico (int month, int year)
        {
            int rows = 5, cols = 20, monthDays = DiasMes2(month, year), startingWeekday = DiaSemanaFecha(1, month, year);
            
            Console.WriteLine(" L  M  X  J  V  S  D");
            FirstCalendarRow(startingWeekday, cols);
        }
        static void FirstCalendarRow (int startingWeekday, int cols)
        {
            int[] startingCols = { 0, 1, 4, 7, 10, 13, 16, 19};

            string whitespaces = new String(' ', startingCols[startingWeekday]);

            Console.WriteLine(whitespaces + "*");
        }
    }
}
