using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada13()
        {
            Console.WriteLine("Escribe un programa que te escribe la tabla de multiplicar del número que le introduzcas por teclado.");
            Console.WriteLine();

            int input, i = 0;
            
            Console.Write("Dime un número para que te diga su tabla de multiplicar: ");
            input = int.Parse(Console.ReadLine());

            while (i < 11)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
                i++;
            }

            Console.WriteLine();
        }
    }
}