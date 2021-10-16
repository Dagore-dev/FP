using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada18()
        {
            Console.WriteLine("Calcular  el  valor  medio  de  una  serie  de  valores  enteros  positivos  introducidos  por teclado. Para  terminar  de  introducir  valores, el  usuario  debe  teclear  un  número negativo.");
            Console.WriteLine();

            double num, acc = 0, cont = 0;

            Console.WriteLine("Introduce los números debajo:");
            num = Double.Parse(Console.ReadLine());

            while (num >= 0)
            {
                acc += num;
                cont++;

                num = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La media es {acc / cont}");

            Console.WriteLine();
        }
    }
}