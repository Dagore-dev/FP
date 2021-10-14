using System;

namespace Estructurada18
{
    class Program
    {
        static void Main(string[] args)
        {
            double acc = 0;
            double cont = 0;

            Console.WriteLine("Introduce una serie de números enteros positivos para hacerles la media.");
            double num = Double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                acc += num;
                cont++;

                num = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La media es {acc / cont}");
        }
    }
}
