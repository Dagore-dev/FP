using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada15()
        {
            Console.WriteLine("Escribe un programa que te pide dos números. Si el primero es menor que el segundo, escribe  todos  los  números  comprendidos  entre  ambos  en  orden  ascendente.Si  el primero  es  mayor  que  el  segundo, escribe  todos  los  números  comprendidos  entre ambos en orden descendente.");
            Console.WriteLine();

            int a, b;

            Console.Write("Dame el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dame el segundo número: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                int cont = a;

                while (cont <= b)
                {
                    Console.WriteLine(cont);
                    cont++;
                }
            }
            if (a > b)
            {
                int cont = a;
                while (cont >= b)
                {
                    Console.WriteLine(cont);
                    cont--;
                }
            }

            Console.WriteLine();
        }
    }
}