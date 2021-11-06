using System;

namespace Estructurada11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que nos escriba los 10 primeros números pares.

            int i = 0;
            int acc = 0;

            while (acc < 10)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    acc++;
                }

                i++;
            }
        }
    }
}
