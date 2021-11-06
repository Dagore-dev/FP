using System;

namespace Estructurada13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa que te escribe la tabla de multiplicar del número que le introduzcas por teclado. 

            Console.WriteLine("Dime un número para que te diga su tabla de multiplicar.");
            int input = int.Parse(Console.ReadLine());

            int i = 0;

            while (i < 11)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
                i++;
            }
        }
    }
}
