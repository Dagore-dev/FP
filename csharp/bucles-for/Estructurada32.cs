﻿using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada32()
        {
            Console.WriteLine("Calcular el valor máximo de una serie de 10 números introducidos por teclado.");
            Console.WriteLine();

            int current, max;

            Console.WriteLine("Introduce los 10 números debajo de uno en uno, te daré el máximo:");
            current = int.Parse(Console.ReadLine());
            
            max = current;

            for (int i = 1; i < 9; i++)
            {
                current = int.Parse(Console.ReadLine());

                if (current > max)
                {
                    max = current;
                }
            }

            Console.WriteLine(max);

            Console.WriteLine();
        }
    }
}