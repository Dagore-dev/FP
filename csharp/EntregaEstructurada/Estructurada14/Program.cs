using System;

namespace Estructurada14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que te pida dos números con la condición de que el segundo sea mayor que el primero, en caso contrario te pregunta de nuevo el número hasta que sea correcto.Si los números son correctos, escribe todos los números comprendidos entre el primer y el segundo número(ambos inclusive).
            
            Console.WriteLine("Dame dos números, que el segundo sea mayor que el primero.");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dime el segundo.");
            int b = int.Parse(Console.ReadLine());

            while (a >= b)
            {
                Console.WriteLine($"El segundo debe ser mayor que el primero. Dime de nuevo el segundo número, tu primer número es {a}.");

                b = int.Parse(Console.ReadLine());
            }

            while (a <= b)
            {
                Console.WriteLine(a);

                a++;
            }
        }
    }
}
