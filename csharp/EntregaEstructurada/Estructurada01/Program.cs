using System;

namespace Estructurada01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leídos dos números por teclado, A y B, calcular la resta del mayor menos el menor. Por ejemplo, si A = 8 y B = 3, el resultado debe ser A – B, es decir, 5. Pero si A = 4 y B = 7, el resultado debe ser B – A, es decir, 3.

            int num1, num2;

            Console.Write("Introduce el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = int.Parse(Console.ReadLine());


            if (num1 < num2)
            {
                Console.WriteLine($"El resultado de operar {num2} - {num1} es {num2 - num1}");
            }
            else
            {
                Console.WriteLine($"El resultado de operar {num1} - {num2} es {num1 - num2}");
            }

        }
    }
}
