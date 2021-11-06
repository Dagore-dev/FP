using System;

namespace FuncionesAdicionales02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función centigradosAFahrenheit que nos convierta una temperatura que está en grados centígrados a grados Fahrenheit. La función tendrá un parámetro, que será un número real, y devolverá otro número real. La fórmula es: Temp.(F) = 1,8 * Temp.(C°) + 32.

            Console.WriteLine(CentimetrosAFahrenheit(0));//32 farenheit
            Console.WriteLine(CentimetrosAFahrenheit(100));//212 farenheit
            Console.WriteLine(CentimetrosAFahrenheit(-35));//-31 farenheit

            Console.WriteLine();

            //Escribe una función fahrenheitACentigrados que nos convierta una temperatura que está en grados Fahrenheit a grados centígrados.La función tendrá un parámetro, que será un número real, y devolverá otro número real.La fórmula es: Temp.(C) = (Temp.(F) - 32) / 1,8.

            Console.WriteLine(FahrenheitACentimetros(32));//0º
            Console.WriteLine(FahrenheitACentimetros(212));//100º
            Console.WriteLine(FahrenheitACentimetros(-31));//-35º

        }
        static int CentimetrosAFahrenheit (int number)
        {
            double result = 1.8 * number + 32;

            return (int) Math.Round(result);
        }

        static int FahrenheitACentimetros (int number)
        {
            double result = (number - 32) / 1.8;

            return (int) Math.Round(result);
        }
    }
}
