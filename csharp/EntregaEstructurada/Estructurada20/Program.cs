using System;

namespace Estructurada20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el valor máximo de una serie de 10 números introducidos por teclado.

            int cont = 0, max;

            Console.WriteLine("Escribe 10 número enteros, te diré el máximo.");
            int current = int.Parse(Console.ReadLine());

            max = current;

            while (cont < 10)
            {
                current = int.Parse(Console.ReadLine());

                if (current > max)
                {
                    max = current;
                }

                cont++;
            }

            Console.WriteLine($"El mayor número de los que has introducido es {max}");
        }
    }
}
