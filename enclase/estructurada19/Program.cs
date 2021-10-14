using System;

namespace estructurada19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double nota;
            int aprobados = 0, suspensos = 0;
            int numeroAlumnos = 30;
            while (i < numeroAlumnos)
            {
                Console.WriteLine("Dime la nota del alumno " + i + ":");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 10)
                {


                    if (nota >= 5)
                    {
                        aprobados++;
                    }
                    else
                    {
                        suspensos++;
                    }

                    i++;
                }
                else
                {
                    Console.WriteLine("La nota esta mal, vuelve a poner la nota");
                }
            }
            Console.WriteLine("aprobados" + aprobados + "y " + suspensos);
        }
    }
}
