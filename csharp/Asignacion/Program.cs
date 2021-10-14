using System;

namespace Asignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isParsable;
            int n, doble;

            Console.WriteLine("Dime un número.");

            input = Console.ReadLine();

            isParsable = Int32.TryParse(input, out n);

            if(isParsable)
            {
                if( n == 5)
                {
                    Console.WriteLine("Por el culo te la hinco.");
                }
                else
                {
                    doble = n * 2;
                    Console.WriteLine($"El doble de ese número es {doble}");
                }
            }
            else
            {
                Console.WriteLine("Introduzca un input válido.");
            }
        }
    }
}
