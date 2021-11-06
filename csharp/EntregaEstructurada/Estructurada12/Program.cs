using System;

namespace Estructurada12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe  un  programa  que  te  pregunte  si  quieres  números  pares  o  impares.  Si  te  dice pares, escribe los números pares  del 1 al 10 y si te dice  impares,  escribe los números impares del 1 al 10.

            Console.WriteLine("¿Pares o impares?");
            string option = Console.ReadLine();

            int i = 0;

            while (i < 11)
            {
                if (option == "Pares" || option == "pares")
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                if (option == "Impares" || option == "impares")
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                i++;
            }
        }
    }
}
