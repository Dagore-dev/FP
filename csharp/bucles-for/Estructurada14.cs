using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada14()
        {
            Console.WriteLine("Escribe un programa que te pida dos números con la condición de que el segundo sea mayor que el primero, en caso contrario te pregunta de nuevo el número hasta que sea correcto.Si los números son correctos, escribe todos los números comprendidos entre el primer y el segundo número(ambos inclusive).");
            Console.WriteLine();

            int a, b;

            Console.Write("Dame dos números, que el segundo sea mayor que el primero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo: ");
            b = int.Parse(Console.ReadLine());

            while (a >= b)
            {
                Console.Write($"El segundo debe ser mayor que el primero. Dime de nuevo el segundo número, tu primer número es {a}: ");

                b = int.Parse(Console.ReadLine());
            }

            while (a <= b)
            {
                Console.WriteLine(a);

                a++;
            }

            Console.WriteLine();
        }
    }
}