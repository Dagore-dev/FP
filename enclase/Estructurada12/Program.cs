using System;

namespace Estructurada12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Pares o impares?");
            string option = Console.ReadLine();

            int i = 0;

            while (i < 11)
            {
                if(option == "Pares" || option == "pares")
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                if(option == "Impares" || option == "impares")
                {
                    if(i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                i++;
            }

        }
    }
}
