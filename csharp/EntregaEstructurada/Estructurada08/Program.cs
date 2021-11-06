using System;

namespace Estructurada08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados tres números enteros, A, B, C, determinar cuál es el mayor, cuál el menor y cuál el mediano. Usa solo bloques if/else.

            /*
                a b c
                a c b
                b a c
                b c a
                c a b
                c b a
            */

            int a, b, c;

            Console.WriteLine("Introduzca el entero A.");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el entero B.");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el entero C.");
            c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                if (a < c)
                {
                    if (c < b)
                    {
                        Console.WriteLine($"{a} es el menor, {c} es el mediano y {b} el mayor.");
                    }
                    else
                    {
                        Console.WriteLine($"{a} es el menor, {b} es el mediano y {c} el mayor.");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} es el menor, {a} es el mediano y {b} el mayor.");
                }
            }
            else
            {
                if (b < c)
                {
                    if (c < a)
                    {
                        Console.WriteLine($"{b} es el menor, {c} es el mediano y {a} el mayor.");
                    }
                    else
                    {
                        Console.WriteLine($"{b} es el menor, {a} es el mediano y {c} el mayor.");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} es el menor, {b} es el mediano y {a} el mayor.");
                }
            }
        }
    }
}
