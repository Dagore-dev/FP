using System;

namespace Estructurada27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que te da la tabla de multiplicar del número que le introduzcas por teclado.

            int num;

            Console.Write("Dame un número entero y te digo su tabla de multiplicar: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
