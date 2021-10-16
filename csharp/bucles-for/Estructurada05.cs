using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada05()
        {
            Console.WriteLine("Leer tres números por teclado, X, Y y Z. Averigua si los números son consecutivos.");
            Console.WriteLine();

            int num1, num2, num3;

            Console.Write("Introduce el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 + 1 == num2) && (num2 + 1 == num3))
            {
                Console.WriteLine($"{num1}, {num2} y {num3} son consecutivos");
            }
            else
            {
                Console.WriteLine($"{num1}, {num2} y {num3} no son consecutivos");
            }

            Console.WriteLine();
        }
    }
}