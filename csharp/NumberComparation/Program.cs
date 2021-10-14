using System;

namespace NumberComparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2;
            bool isNum1Parsable, isNum2Parsable;
            double num1, num2;

            Console.WriteLine("Introduce el primer número a comparar.");

            input1 = Console.ReadLine();

            Console.WriteLine("Introduce el segundo número.");

            input2 = Console.ReadLine();

            isNum1Parsable = Double.TryParse(input1, out num1);
            isNum2Parsable = Double.TryParse(input2, out num2);

            if (isNum1Parsable && isNum2Parsable)
            {
                if( num1 == num2)
                {
                    Console.WriteLine("Los números son iguales");
                    return;
                }
                if(num1 < num2)
                {
                    Console.WriteLine($"{num1} es menor que {num2}");
                }
                else
                {
                    Console.WriteLine($"{num1} es mayor qye {num2}");
                }
            }
            else
            {
                Console.WriteLine("Introduzca un input válido. Recuerda que la configuración regional te obliga a usar la coma decimal en lugar de punto.");
            }
        }
    }
}
