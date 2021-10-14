using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada27()
        {
            //Escribe un programa que te escribe la tabla de multiplicar del número que le introduzcas por teclado.
            Console.WriteLine("Dame un número entero y te digo su tabla de multiplicar.");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            Console.WriteLine("\n");
        }
    }
}