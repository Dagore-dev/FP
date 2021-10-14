using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada38()
        {
            //Escribe un programa que calcule el máximo común divisor de 2 números.

            int a, b, i;

            Console.Write("Dime un número entero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("");

            Console.Write("Dime otro número entero: ");
            b = int.Parse(Console.ReadLine());

            i = a < b ? a : b;

            while (a % i != 0 || a % i != 0)
            {
                i--;
            }

            Console.WriteLine(i);
        }
    }
}