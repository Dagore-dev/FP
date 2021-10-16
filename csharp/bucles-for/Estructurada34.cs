using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada34()
        {
            Console.WriteLine("Calcular el factorial de un número entero N. Recuerda que el factorial de un número es el producto de ese número por todos los enteros menores que él. Por ejemplo, el factorial de 5(simbolizado 5!) se calcula como: 5! = 5 x 4 x 3 x 2 x 1.");
            Console.WriteLine();

            int num, acc = 1;
            
            Console.Write("Introduce un entero distinto de cero (0! = 1), te calculo su factorial: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                acc *= i;
            }

            Console.WriteLine(acc);

            Console.WriteLine();
        }
    }
}