using System;

namespace IsNoteValid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isParsable;
            double number;

            Console.WriteLine("Dime tu nota en programación.");

            input = Console.ReadLine();

            isParsable = Double.TryParse(input, out number);

            if (isParsable)
            {
                if(number >= 0 && number <= 10)
                {
                    Console.WriteLine("Esta nota es correcta.");

                    if(number > 5)
                    {
                        Console.WriteLine("Estás aprobado.");
                    }
                    else
                    {
                        Console.WriteLine("Estás suspenso");
                    }
                }
                else
                {
                    Console.WriteLine("Esa nota es incorrecta.");
                }
            }
            else
            {
                Console.WriteLine("Introduzca un input válido.");
            }
        }
    }
}
