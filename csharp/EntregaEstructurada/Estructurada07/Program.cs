using System;

namespace Estructurada07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular las dos soluciones de una ecuación de segundo grado, del tipo ax2 + bx + c = 0. Los coeficientes a, b y c deberá introducirlos el usuario a través del teclado.
            // (-b + sqrt(b^2-4ac)) / 2a y lo mismo con -b - ...

            double a, b, c, innerSqrt, sqrt, positiveResult, negativeResult;

            Console.Write("Introduce el coeficiente a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Introduce el coeficiente b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Introduce el coeficiente c: ");
            c = double.Parse(Console.ReadLine());

            innerSqrt = ((b * b) - (4 * a * c));

            if (innerSqrt >= 0)
            {
                sqrt = Math.Sqrt(innerSqrt);

                positiveResult = (-b + sqrt) / (2 * a);

                if (innerSqrt == 0)
                {
                    Console.WriteLine($"La ecuación introducida tiene un única solución: {positiveResult}");

                }
                else
                {
                    negativeResult = (-b - sqrt) / (2 * a);

                    Console.WriteLine($"La ecuación introducida tiene dos soluciones: {positiveResult} y {negativeResult}");
                }

            }
            else
            {
                Console.WriteLine("Esta ecuación no tiene solución real.");
            }
        }
    }
}
