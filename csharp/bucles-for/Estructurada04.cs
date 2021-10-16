using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada04()
        {
            Console.WriteLine("Leer tres números por teclado, X, Y y Z, y decidir si están ordenados de menor a mayor.");
            Console.WriteLine();

            int num1, num2, num3;

            Console.WriteLine("Introduce el primer número.");

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número.");

            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número.");

            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Los números están ordenados de menor a mayor.");
            }
            else
            {
                Console.WriteLine("Los números no están ordenados de menor a mayor.");
            }

            Console.WriteLine();
        }
    }
}