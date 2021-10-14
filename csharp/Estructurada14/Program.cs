using System;

namespace Estructurada14
{
    class Program
    {
        static void Main(string[] args)
        {
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
