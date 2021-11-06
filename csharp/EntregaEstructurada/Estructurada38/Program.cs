using System;

namespace Estructurada38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que calcule el máximo común divisor de 2 números. El MCD es el primer número que divide al par de manera exacta, entonces empezamos por el número más bajo del par y vamos bajando y comprobando la condición.

            int a, b, i;

            Console.Write("Dime un número entero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Dime otro número entero: ");
            b = int.Parse(Console.ReadLine());

            i = a < b ? a : b;//i toma el valor del menor del par.

            while (a % i != 0 || b % i != 0)//El MCD cumple que a % i == 0 && b % i == 0.
            {
                i--;
            }

            Console.WriteLine(i);
        }
    }
}
