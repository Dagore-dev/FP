using System;

namespace Estructurada16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir todos los números impares entre dos números A y B introducidos por teclado. Antes habrá que comprobar cuál de los dos números A y B es mayor.

            Console.WriteLine("Dame el primer número.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo número.");
            int b = int.Parse(Console.ReadLine());

            int little, big;

            if (a < b)
            {
                little = a; big = b;
            }
            else
            {
                little = b; big = a;
            }

            while (little <= big)
            {
                if (little % 2 != 0)
                {
                    Console.WriteLine(little);
                }

                little++;
            }
        }
    }
}
