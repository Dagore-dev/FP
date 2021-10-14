using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada39()
        {
            //Escribe un programa que calcule el mínimo común múltiplo de 2 números.

            int a, b, i;

            Console.WriteLine("Dime dos números enteros y te calculo el mínimo común múltiplo.");
            Console.Write("Dime el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo número: ");
            b = int.Parse(Console.ReadLine());

            i = a > b ? a : b;

            while (i % a != 0 || i % b != 0)
            {
                i++;
            }

            Console.WriteLine(i);
        }
    }
}