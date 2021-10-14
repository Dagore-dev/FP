using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada35()
        {
            //Escribe un programa que le pide al usuario la nota de un alumno (un número real). El programa escribirá “Suspenso” si la nota está entre 0 y 5; “Suficiente” si la nota está entre 5 y 6; “Bien” si la nota está entre 6 y 7; “Notable” si la nota está entre 7 y 9 y “Sobresaliente” si está entre 9 y 10.Si la nota no es válida, el programa nos vuelve a pedir un valor hasta que introduzcamos una correcta.
            double score;

            Console.Write("Dime la nota del alumno: ");
            score = double.Parse(Console.ReadLine());

            while (score < 0 || score > 10)
            {
                Console.WriteLine("Por favor, escribe una nota válida: ");
                score = double.Parse(Console.ReadLine());
            }

            if (score < 5)
            {
                Console.WriteLine("Suspenso.");
            }
            else if (score >= 5 && score < 6)
            {
                Console.WriteLine("Suficiente.");
            }
            else if (score >= 6 && score < 7)
            {
                Console.WriteLine("Bien.");
            }
            else if (score >= 7 && score < 9)
            {
                Console.WriteLine("Notable.");
            }
            else Console.WriteLine("Sobresaliente.");

            Console.WriteLine("\n");
        }
    }
}