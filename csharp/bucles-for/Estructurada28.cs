using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada28()
        {
            //Escribe un programa que te pide dos números enteros. Si el primero es menor que el segundo, escribe todos los números comprendidos entre ambos en orden ascendente. Si el primero es mayor que el segundo, escribe todos los números comprendidos entre ambos en orden descendente.

            Console.WriteLine("Dime un número entero.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro número entero.");
            int num2 = int.Parse(Console.ReadLine());

            int min, max;

            if (num1 < num2)
            {
                min = num1; max = num2;
            }
            else
            {
                min = num2; max = num1;
            }

            for (int i = min; i < max + 1; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
        }
    }
}