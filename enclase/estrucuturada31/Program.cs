using System;

namespace estrucuturada31
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double nota;
            int aprobados = 0, suspensos = 0;

            

            for ( i = 0; i < 5; i++)
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
                }
                else
                {
                    Console.WriteLine("Nota erronia");
                    i--; //truco para que el contador no avance, ya que la nota no es correcta
                }
            }
            Console.WriteLine("Aprobados " + aprobados + "Suspensos" + suspensos);
        }
    }
}
