using System;

namespace PassOrFail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double nota;
            
            Console.WriteLine("¿Qué nota has sacado en entornos de desarrollo?");

            input = Console.ReadLine();

            bool isParsable = Double.TryParse(input, out nota);

            if (isParsable)
            {
                if (nota >= 5.0)
                {
                    Console.WriteLine("Estás aprobado.");
                }
                else
                {
                    Console.WriteLine("Estás suspenso.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduzca un input válido.");
            }

        }
    }
}
