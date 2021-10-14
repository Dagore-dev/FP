using System;

namespace Estructurada04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer tres números por teclado, X, Y y Z, y decidir si están ordenados de menor a mayor.

            string input1, input2, input3;
            bool is1Parsable, is2Parsable, is3Parsable;
            int num1, num2, num3;

            Console.WriteLine("Introduce el primer número.");

            input1 = Console.ReadLine();

            Console.WriteLine("Introduce el segundo número.");

            input2 = Console.ReadLine();

            Console.WriteLine("Introduce el tercer número.");

            input3 = Console.ReadLine();

            is1Parsable = Int32.TryParse(input1, out num1);
            is2Parsable = Int32.TryParse(input2, out num2);
            is3Parsable = Int32.TryParse(input3, out num3);

            if(is1Parsable && is2Parsable && is3Parsable)
            {
                if(num1 < num2 && num2 < num3)
                {
                    Console.WriteLine("Los números están ordenados de menor a mayor.");
                }
                else
                {
                    Console.WriteLine("Los números no están ordenados de menor a mayor.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce números reales.");
            }
        }
    }
}
