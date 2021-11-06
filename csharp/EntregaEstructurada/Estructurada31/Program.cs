using System;

namespace Estructurada31
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
