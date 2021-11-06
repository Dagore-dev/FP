using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double score1, score2, mean;

            Console.Write("Nombre del alumno: ");
            name = Console.ReadLine();
            
            Console.Write("Edad del alumno: ");
            age = int.Parse(Console.ReadLine());

            while (age < 17 || age > 100)
            {
                Console.Write("Esa edad no está bien. Pueba de nuevo: ");
                age = int.Parse(Console.ReadLine());
            }

            Console.Write("Dame la nota del primer examen: ");
            score1 = ScorePrompt();
            Console.Write("Dame la nota del segundo examen: ");
            score2 = ScorePrompt();

            mean = (score1 + score2) / 2.0;
            
            Console.WriteLine($"{name} tiene {age} años.");
            Console.WriteLine($"Ha sacado un {score1} y un {score2}.");
            Console.WriteLine($"La media le sale {mean}.");
        }
        static double ScorePrompt ()
        {
            double score;

            score = double.Parse(Console.ReadLine());

            while (score < 0 || score > 10)
            {
                Console.Write("Esa nota no está en el formato adecuado. Prueba de nuevo: ");
                score = double.Parse(Console.ReadLine());
            }

            return score;
        }
    }
}
