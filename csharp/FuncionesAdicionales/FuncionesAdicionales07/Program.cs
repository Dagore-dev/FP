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
            Console.WriteLine("Octubre 2021");
            CalendarioGrafico(10, 2021);

            Console.WriteLine();

            Console.WriteLine("Enero 2021");
            CalendarioGrafico(1,2021);

            Console.WriteLine();

            Console.WriteLine("Enero 2020");
            CalendarioGrafico(1,2020);
        }
        static int DiasMes(int month)
        {
            //Escribe una función “diasMes”, a la que le pasamos un mes (en formato numérico 1 = Enero, 2 = Febrero, etc.) y nos dice el número de días que tiene ese mes.

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
            //Debido a que en los años bisiestos el mes de Febrero tiene 29 días en lugar de 28, necesitaremos también dar el año para conseguir el resultado correcto. Escribe la función “diasMes2” a la que le pasas un mes y un año(ambos enteros) y te dice cuántos días tiene ese mes, teniendo en cuenta si el año es bisiesto o no (NOTA: Podéis usar la función “Bisiesto” que hicimos con anterioridad).
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
            // Escribe una función “diasTranscurridos” a la que le pasamos tres enteros, el día, el mes y el año, y nos dice cuántos días han pasado desde el inicio del año hasta ese día. Así, el 1 de enero será el día 1 y el 31 de diciembre será el 365 ó 366 dependiendo de si el año es bisiesto o no.
            int acc = 0;

            for (int i = 1; i < month; i++)
            {
                acc += DiasMes2(i, year);
            }

            return acc + day;
        }
        static int DiasTranscurridos1980(int day, int month, int year)
        {
            //Escribe una función “diasTranscurridos1980” a la que le pasamos un día, mes y año y nos diga cuántos días han transcurrido desde el 01 / 01 / 1980 hasta ese día.
            int acc = 0;

            for (int i = 1980; i < year; i++)
            {
                if (IsLeapYear(i))
                {
                    acc += 366;
                }
                else
                {
                    acc += 365;
                }
            }

            return acc + DiasTranscurridos(day, month, year);
        }
        static int DiaSemanaFecha(int day, int month, int year)
        {
            //Teniendo en cuenta que el 01/01/1980 era martes, haz una función “diaSemanaFecha” que nos devuelva qué día de la semana corresponde a la fecha(día, mes y año) que le pasamos en 3 parámetros.Nos devolverá un entero que corresponderá al día de la semana(1 = lunes, 2 = martes, etc.).
            int weekDay = 2, numberOfDays = DiasTranscurridos1980(day, month, year);

            return weekDay + (numberOfDays % 7) - 1;//Sumamos lo que sobra de coger semanas enteras y se resta uno porque los días transcurridos cuantan el primer día y el actual.
        }
        static void CalendarioGrafico(int month, int year)
        {
            int startingWeekday = DiaSemanaFecha(1, month, year), lastWeekday;

            Console.WriteLine(" L  M  X  J  V  S  D");
            
            lastWeekday = FirstCalendarRow(startingWeekday);

            EndCalendar(lastWeekday, month, year);
        }
        static int FirstCalendarRow(int startingWeekday)
        {
            int lastWeekDay = 7 - startingWeekday + 1;
            int[] startingCols = { 0, 1, 4, 7, 10, 13, 16, 19 };
            string whitespaces = new string(' ', startingCols[startingWeekday] - 2);

            for (int i = 1; i <= lastWeekDay; i++)
            {
                whitespaces += $"  {i}";
            }

            Console.WriteLine(whitespaces);

            return lastWeekDay;
        }
        static void EndCalendar (int lastWeekday, int month, int year)
        {
            int j = 0, rows = 5, monthDays = DiasMes2(month, year);

            for (int i = 1; i < rows; i++)
            {
                lastWeekday++;
                Console.Write(DayContent(lastWeekday));

                while (lastWeekday < monthDays && j < 6)
                {
                    lastWeekday++;
                    Console.Write(" " + DayContent(lastWeekday));
                    j++;
                }

                j = 0;
                Console.WriteLine();
            }
        }
        static string DayContent (int number)
        {
            string result = "";

            if (number < 10)
            {
                result = " " + number;
            }
            else
            {
                result += number;
            }

            return result;
        }
    }
}
