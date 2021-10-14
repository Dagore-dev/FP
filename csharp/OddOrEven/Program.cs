using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            bool isParsable;

            Console.WriteLine("Dime un número entero.");

            input = Console.ReadLine();

            isParsable = Int32.TryParse(input, out number);

            if (isParsable)
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine($"El número {number} es par.");
                }
                else
                {
                    Console.WriteLine($"El número {number} es impar.");
                }
            }
            else
            {
                Console.WriteLine("Introduzca un input válido.");
            }
        }
    }
}
