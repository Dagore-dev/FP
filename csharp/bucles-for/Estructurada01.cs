using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada01()
        {
            Console.WriteLine("Leídos dos números por teclado, A y B, calcular la resta del mayor menos el menor. Por ejemplo, si A = 8 y B = 3, el resultado debe ser A – B, es decir, 5.Pero si A = 4 y B = 7, el resultado debe ser B – A, es decir, 3.");
            Console.WriteLine();

            int num1, num2;

            Console.Write("Introduce el primer número: ");

            num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");

            num2 = int.Parse(Console.ReadLine());


            if (num1 == num2)
            {
                Console.WriteLine("Los números introducidos son iguales, por tanto el resultado es 0.");
                return;
            }
            if (num1 < num2)
            {
                Console.WriteLine($"El resultado de operar {num2} - {num1} es {num2 - num1}");
            }
            else
            {
                Console.WriteLine($"El resultado de operar {num1} - {num2} es {num1 - num2}");
            }

            Console.WriteLine();
        }
    }
}