using System;

namespace Estructurada25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que nos escriba los 10 primeros números pares.

            int counter = 0;

            for (int i = 0; counter < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }
        }
    }
}
