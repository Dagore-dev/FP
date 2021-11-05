using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MillasPorHoraAKilometrosPorHora(1));
            Console.WriteLine(MillasPorHoraAKilometrosPorHora(85));

            Console.WriteLine(KilometrosPorHoraAMillasPorHora(1.609344));
            Console.WriteLine(KilometrosPorHoraAMillasPorHora(137));
        }
        static double MillasPorHoraAKilometrosPorHora (double number)
        {
            double result;

            result = number * 1.609344;

            return result;
        }
        static double KilometrosPorHoraAMillasPorHora (double number)
        {
            double result;

            result = number / 1.609344;

            return result;
        }
    }
}
