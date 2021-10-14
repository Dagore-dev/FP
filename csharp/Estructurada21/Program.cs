using System;

namespace Estructurada21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce 10 números. Te daré máximo, mínimo y media aritmética.");
            double current = double.Parse(Console.ReadLine());

            int counter = 0;
            double acumulator = 0;
            double max = current;
            double min = current;

            while (counter < 10)
            {
                current = double.Parse(Console.ReadLine());

                if(current > max)
                {
                    max = current;
                }
                if(current < min)
                {
                    min = current;
                }

                acumulator += current;

                counter++;
            }

            Console.WriteLine($"El máximo es {max}, el mínimo {min} y la media se corresponde con {acumulator / counter}");
        }
    }
}
