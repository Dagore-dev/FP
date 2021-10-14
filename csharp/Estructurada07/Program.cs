using System;

namespace Estructurada07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular las dos soluciones de una ecuación de segundo grado, del tipo ax2 + bx + c = 0. Los coeficientes a, b y c deberá introducirlos el usuario a través del teclado.
            // (-b + sqrt(b^2-4ac)) / 2a y lo mismo con -b - ...

            string inputA, inputB, inputC;
            bool isAParsable, isBParsable, isCParsable;
            double innerSqrt, sqrt, positiveResult, negativeResult;

            Console.WriteLine("Introduce el coeficiente a");

            inputA = Console.ReadLine();

            Console.WriteLine("Introduce el coeficiente b");

            inputB = Console.ReadLine();

            Console.WriteLine("Introduce el coeficiente c");

            inputC = Console.ReadLine();

            isAParsable = Double.TryParse(inputA, out double a);
            isBParsable = Double.TryParse(inputB, out double b);
            isCParsable = Double.TryParse(inputC, out double c);

            if(isAParsable && isBParsable && isCParsable)
            {
                innerSqrt = ((b * b) - (4 * a * c));

                if (innerSqrt >= 0)
                {
                    sqrt = Math.Sqrt(innerSqrt);

                    positiveResult = (-b + sqrt) / (2 * a);
                       
                    if(innerSqrt == 0)
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
            else
            {
                Console.WriteLine("Introduzca un input válido.");
            }
        }
    }
}
