using System;

namespace Horas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1 hora en segundos es: {HoraASegundos(1,0,0)} segundos.");
            Console.WriteLine($"1 hora y media en segundos es: {HoraASegundos(1,30,0)} segundos.");

            Console.WriteLine();

            Console.Write("12 horas, 2 min y 35 segundos: ");
            EscribeHoraBonita(12, 2, 35);
            Console.Write("2 horas, 57 min y 5 segundos: ");
            EscribeHoraBonita(2, 57, 5);

            Console.WriteLine();

            Console.Write("3600 segundos son: ");
            EscribeSegundosBonito(3600);
            Console.Write("5400 segundos son: ");
            EscribeSegundosBonito(5400);
            Console.Write("5402 segundos son: ");
            EscribeSegundosBonito(5402); 
            Console.Write("86399 segundos son: ");
            EscribeSegundosBonito(86399);

            Console.WriteLine();

            Console.WriteLine($"Entre 02:12:15 y 02:12:30 han pasado: {SegundosTranscurridos(2, 12, 15, 2, 12, 30)} segundos.");
            Console.WriteLine($"Entre 02:12:15 y 02:11:00 han pasado: {SegundosTranscurridos(2, 12, 15, 2, 11, 00)} segundos.");

            Console.WriteLine();

            Console.WriteLine($"Desde el 1/1/1980 hasta el 2/1/1980 a las 12:00:00 pasaron: {SegundosTranscurridos1980(2,1,1980,12,0,0)}");
        }
        static int HoraASegundos (int h, int m, int s)
        {
            //Escribe una función “horaASegundos” a la que le pasas 3 parámetros enteros (hora, minutos y segundos) y te devuelve el total de segundos.
            int result = s;

            result += (m * 60) + (h * 3600);

            return result;
        }
        static string Bonito (int number)
        {
            string result = "";
            if(number < 10)
            {
                result = result + "0" + number;
            }
            else
            {
                result += number;
            }

            return result;
        }

        static void EscribeHoraBonita (int h, int m, int s)
        {
            //Escribe una función “escribeHoraBonita” a la que le pasas tres parámetros (hora, minutos y segundos) y te escribe por pantalla la hora en formato “HH: MM: SS”.
            Console.WriteLine($"{Bonito(h)}:{Bonito(m)}:{Bonito(s)}");
        }
        static void EscribeSegundosBonito (int seconds)
        {
            //Escribe una función “escribeSegundosBonito” a la que le pasas un parámetro que corresponde al número de segundos y te escribe por pantalla la hora en formato “HH: MM: SS”.
            int hours, minutes;

            hours = seconds / 3600;
            seconds %= 3600;
            minutes = seconds / 60;
            seconds %= 60;

            EscribeHoraBonita(hours, minutes, seconds);
        }
        static int SegundosTranscurridos (int h1, int m1, int s1, int h2, int m2, int s2)
        {
            //Escribe una función “segundosTranscurridos” a la que le pasas 2 horas (en total, 6 parámetros: hora, minutos y segundos para cada una de las dos horas) y te dice cuántos segundos han transcurrido entre una y otra.
            return Math.Abs(HoraASegundos(h1, m1, s1) - HoraASegundos(h2, m2, s2));
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
        static int SegundosTranscurridos1980 (int day, int month, int year, int h, int m, int s)
        {
            // Escribe una función “segundosTranscurridos1980” a la que le pasas 6 parámetros: día, mes, año, hora, minutos y segundos y te dice cuántos segundos han transcurrido desde el 1 de enero de 1980.
            int days = DiasTranscurridos1980(day, month, year) - 1, todaySeconds, seconds = 0;

            seconds += days * 86400;
            todaySeconds = HoraASegundos(h, m, s);

            return seconds + todaySeconds;
        }
    }
}
