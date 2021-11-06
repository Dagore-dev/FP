using System;

namespace Estructurada05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como el anterior, pero para averiguar si los números son consecutivos.

            int num1, num2, num3;

            Console.WriteLine("Introduce el primer número.");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número.");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número.");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 + 1 == num2) && (num2 + 1 == num3))
            {
                Console.WriteLine($"{num1}, {num2} y {num3} son consecutivos");
            }
            else
            {
                Console.WriteLine($"{num1}, {num2} y {num3} no son consecutivos");
            }
        }
    }
}
