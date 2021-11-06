using System;

namespace Estructurada04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer tres números por teclado, X, Y y Z, y decidir si están ordenados de menor a mayor.

            int num1, num2, num3;

            Console.Write("Introduce el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Los números están ordenados de menor a mayor.");
            }
            else
            {
                Console.WriteLine("Los números no están ordenados de menor a mayor.");
            }
        }
    }
}
