using System;

namespace Estructurada20
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.WriteLine("Escribe 10 número enteros, te diré el máximo.");
            int current = int.Parse(Console.ReadLine());

            int max = current;

            while (cont < 10)
            {
                current = int.Parse(Console.ReadLine());

                if(current > max)
                {
                    max = current;
                }

                cont++;
            }

            Console.WriteLine($"El mayor número de los que has introducido es {max}");
        }
    }
}
