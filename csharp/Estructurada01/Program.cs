using System;

namespace Estructurada01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leídos dos números por teclado, A y B, calcular la resta del mayor menos el menor. Por ejemplo, si A = 8 y B = 3, el resultado debe ser A – B, es decir, 5. Pero si A = 4 y B = 7, el resultado debe ser B – A, es decir, 3.

            //Declaración de variables.
            string input1, input2;
            bool isNum1Parsable, isNum2Parsable;
            int num1, num2;

            Console.WriteLine("Introduce el primer número.");

            input1 = Console.ReadLine();

            Console.WriteLine("Introduce el segundo número");

            input2 = Console.ReadLine();

            isNum1Parsable = Int32.TryParse(input1, out num1);
            isNum2Parsable = Int32.TryParse(input2, out num2);

            if(isNum1Parsable && isNum2Parsable)
            {
                if(num1 == num2)
                {
                    Console.WriteLine("Los números introducidos son iguales, por tanto el resultado es 0.");
                    return;
                }
                if(num1 < num2)
                {
                    Console.WriteLine($"El resultado de operar {num2} - {num1} es {num2 - num1}");
                }
                else
                {
                    Console.WriteLine($"El resultado de operar {num1} - {num2} es {num1 - num2}");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduzca un input válido.");
            }
        }
    }
}
