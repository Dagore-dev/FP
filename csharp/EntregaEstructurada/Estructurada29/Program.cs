using System;

namespace Estructurada29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir todos los números impares entre dos números enteros A y B introducidos por teclado. Antes habrá que comprobar cuál de los dos números A y B es mayor.

            int num1, num2, min, max;

            Console.Write("Dime un número entero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Dime otro número entero: ");
            num2 = int.Parse(Console.ReadLine());

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
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
