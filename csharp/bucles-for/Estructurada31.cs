using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada31()
        {
            //El usuario de este programa será un profesor, que introducirá las notas de sus 30 alumnos de una en una. El algoritmo debe decirle cuántos suspensos y cuántos aprobados hay.
            double current;
            int pass = 0;

            Console.WriteLine("Introduce las notas de los alumnos:");

            for (int i = 0; i < 30; i++)
            {
                current = double.Parse(Console.ReadLine());

                if (current >= 5)
                {
                    pass++;
                }
            }

            Console.WriteLine($"Hay {pass} aprobados y {30 - pass} suspensos en la clase.");

            Console.WriteLine("\n");
        }
    }
}