using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada39()
        {
            Console.WriteLine("Escribe un programa que calcule el mínimo común múltiplo de 2 números.");
            //El mcm es el menor número que se divide por los del par de forma exacta, por tanto necesitamos empezar por el mayor de los introducidos y seguir sumando hasta alcanzar la condición.
            int a, b, i;

            Console.WriteLine("Dime dos números enteros y te calculo el mínimo común múltiplo.");
            Console.WriteLine();
            Console.Write("Dime el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo número: ");
            b = int.Parse(Console.ReadLine());

            i = a > b ? a : b;//i toma el valor del mayor del par.

            while (i % a != 0 || i % b != 0)//El mcm cumple que i % a == 0 && i % b == 0.
            {
                i++;
            }

            Console.WriteLine(i);
        }
    }
}