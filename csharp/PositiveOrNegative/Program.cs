using System;

namespace PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isParsable;
            double number;

            Console.WriteLine("Dime un número entero.");

            input = Console.ReadLine();

            isParsable = Double.TryParse(input, out number);

            if (isParsable)
            {
                if(number == 0)
                {
                    Console.WriteLine("El número es 0.");
                    return;
                }
                if(number > 0)
                {
                    Console.WriteLine($"El número {number} es positivo.");
                }
                else
                {
                    Console.WriteLine($"El número {number} es negativo.");
                }
            }
            else
            {
                Console.WriteLine("Introduce un input válido.");
            }
        }
    }
}
