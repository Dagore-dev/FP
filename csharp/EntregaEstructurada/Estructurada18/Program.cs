using System;

namespace Estructurada18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular  el  valor  medio  de  una  serie  de  valores  enteros  positivos  introducidos  por teclado. Para terminar  de introducir  valores,  el usuario  debe teclear  un número negativo.

            double acc = 0;
            double cont = 0;

            Console.WriteLine("Introduce una serie de números enteros positivos para hacerles la media.");
            double num = double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                acc += num;
                cont++;

                num = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La media es {acc / cont}");
        }
    }
}
