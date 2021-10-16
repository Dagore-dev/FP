using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada19()
        {
            Console.WriteLine("El  usuario  de  este  programa  será  un  profesor,  que  introducirá  las  notas  de  sus  30 alumnos  de  una  en  una. El  algoritmo  debe  decirle  cuántos  suspensos  y  cuántos aprobados hay.");
            Console.WriteLine();

            int i = 0, pass = 0;
            double score;
            
            Console.WriteLine("Introduzca una a una las notas de los 30 alumnos de bajo:");
            score = double.Parse(Console.ReadLine());


            while (i < 30)
            {
                if (score >= 5)
                {
                    pass++;
                }

                score = double.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine($"La clase tiene {pass} aprobados y {30 - pass} suspensos.");

            Console.WriteLine();
        }
    }
}