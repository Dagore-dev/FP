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
            
            string inputA, inputB, inputC;
            bool isAParsable, isBParsable, isCParsable;

            Console.WriteLine("Introduzca el entero A.");
            inputA = Console.ReadLine();
            Console.WriteLine("Introduzca el entero B.");
            inputB = Console.ReadLine();
            Console.WriteLine("Introduzca el entero C.");
            inputC = Console.ReadLine();

            isAParsable = Int32.TryParse(inputA, out int a);
            isBParsable = Int32.TryParse(inputB, out int b);
            isCParsable = Int32.TryParse(inputC, out int c);

            if(isAParsable && isBParsable && isCParsable)
            {
                if(a < b)
                {
                    if(a < c)
                    {
                        if(c < b)
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
                        if(c < a)
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
            else
            {
                Console.WriteLine("Por favor, introduzca un input válido.");
            }
        }
    }
}
