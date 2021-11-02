using System;

namespace FuncionesRelacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Febrero tiene {DiasMes(2)} días");
            Console.WriteLine($"Febrero de 2020 tuvo {DiasMes2(2, 2020)} días");
            Console.WriteLine($"Febrero de 2020 tuvo {DiasMes2(2, 2021)} días");
            Console.WriteLine($"Desde el principio del año hasta 2/2/2020 han pasado {DiasTranscurridos(2, 2, 2020)} días");
            Console.WriteLine($"Desde el principio del año hasta 2/3/2020 han pasado {DiasTranscurridos(2, 3, 2020)} días");
            Console.WriteLine($"Desde el principio del año hasta 31/12/2020 han pasado {DiasTranscurridos(2, 3, 2020)} días");
            Console.WriteLine($"Desde 1980 hasta el 28/10/2021 han pasado {DiasTranscurridos1980(28, 10, 2021)} días");
            Console.WriteLine($"Entre el 8/10/2021 y el 28/10/2021 han pasado {DiasEntreFechas(8, 10, 2021, 28, 10, 2021)} días");
            Console.WriteLine($"El 1/1/2021 es {Semana(1, 1, 2021)}");
            Console.WriteLine($"El 28/10/2021 es {Semana(28, 10, 2021)}");
            Console.WriteLine($"El 25/10/2021 es {Semana(25, 10, 2021)}");
            Console.WriteLine($"El 1/10/2021 es {Semana(1, 10, 2021)}");
        }

        static int DiasMes (int month)
        {
            //Escribe una función “diasMes”, a la que le pasamos un mes (en formato numérico 1 = Enero, 2 = Febrero, etc.) y nos dice el número de días que tiene ese mes.

            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            return monthDays[month - 1];
        }
        
        static bool IsLeapYear (int year)
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
        static int DiasMes2 (int month, int year)
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

        static int DiasTranscurridos (int day, int month, int year)
        {
            // Escribe una función “diasTranscurridos” a la que le pasamos tres enteros, el día, el mes y el año, y nos dice cuántos días han pasado desde el inicio del año hasta ese día. Así, el 1 de enero será el día 1 y el 31 de diciembre será el 365 ó 366 dependiendo de si el año es bisiesto o no.
            int acc = 0;
            
            for (int i = 1; i < month; i++)
            {
                acc += DiasMes2(i, year);
            }

            return acc + day;
        }

        static int DiasTranscurridos1980 (int day, int month, int year)
        {
            //Escribe una función “diasTranscurridos1980” a la que le pasamos un día, mes y año y nos diga cuántos días han transcurrido desde el 01 / 01 / 1980 hasta ese día.
            int acc = 0;

            for (int i = 1980; i < year; i++)
            {
                if(IsLeapYear(i))
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
        static int DiasEntreFechas (int day1, int month1, int year1, int day2, int month2, int year2)
        {
            return Math.Abs(DiasTranscurridos1980(day1, month1, year1) - DiasTranscurridos1980(day2, month2, year2));
        }
        static int DiaSemanaFecha (int day, int month, int year)
        {
            //Teniendo en cuenta que el 01/01/1980 era martes, haz una función “diaSemanaFecha” que nos devuelva qué día de la semana corresponde a la fecha(día, mes y año) que le pasamos en 3 parámetros.Nos devolverá un entero que corresponderá al día de la semana(1 = lunes, 2 = martes, etc.).
            int weekDay = 2, numberOfDays = DiasTranscurridos1980(day, month, year);

            return weekDay + (numberOfDays % 7) - 1;//Sumamos lo que sobra de coger semanas enteras y se resta uno porque los días transcurridos cuantan el primer día y el actual.
        }
        static string Semana (int day, int month, int year)
        {
            string[] weekDays = { "", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"};

            return weekDays[DiaSemanaFecha(day, month, year)];
        }
    }
}
