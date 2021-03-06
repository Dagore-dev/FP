using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada03()
        {
            Console.WriteLine("Leer un número real y un tipo de moneda, que puede ser \"euro\" o \"peseta\". Convertir la cantidad al tipo de moneda indicado, suponiendo que está expresada en la otra.Por ejemplo, si la cantidad es 15 y la moneda es \"peseta\", se supondrá que se trata de 15 € y que hay que convertirlos a pesetas y, por lo tanto, el resultado debe ser 2495.");
            Console.WriteLine();

            string inputCoin;
            double num1, num2;

            Console.WriteLine("Introduce el dinero.");

            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué moneda es? (euro / peseta).");

            inputCoin = Console.ReadLine();

            if (inputCoin == "euro")
            {
                num2 = num1 * 166.3860;

                Console.WriteLine($"{num1} euro(s) en pesetas es {num2}.");
            }
            else if (inputCoin == "peseta")
            {
                num2 = num1 / 166.3860;

                Console.WriteLine($"{num1} peseta(s) en euros es {num2}.");
            }
            else
            {
                Console.WriteLine("No he entendido la conversión que quieres hacer.");
            }

            Console.WriteLine();
        }
    }
}