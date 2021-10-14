using System;

namespace Estructurada19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int pass = 0;
            Console.WriteLine("Introduzca una a una las notas de los 30 alumnos.");
            double note = double.Parse(Console.ReadLine());


            while (i < 30)
            {
                if(note >= 5)
                {
                    pass++;
                }
                
                note = double.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine($"La clase tiene {pass} aprobados y {30 - pass} suspensos.");
        }
    }
}
