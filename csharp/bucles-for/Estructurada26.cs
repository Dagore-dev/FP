using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada26()
        {
            Console.WriteLine("Escribe un programa que te pregunte si quieres números pares o impares. Si te dice pares, escribe los números pares del 1 al 10 y si te dice impares, escribe los números impares del 1 al 10.");
            Console.WriteLine();

            string option;
            int i = 1;
            
            Console.WriteLine("¿Te digo números pares o impares?");
            option = Console.ReadLine();

            if (option == "pares" || option == "impares")
            {

                if (option == "pares")
                {
                    i = 2;
                }

                for (int j = i; j < 11; j += 2)
                {
                    Console.WriteLine(j);
                }
            }
            else
            {
                Console.WriteLine("No he entendido la opción que has introducido.");
            }

            Console.WriteLine();
        }
    }
}