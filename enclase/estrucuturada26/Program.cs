using System;

namespace estrucuturada26
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int i;
            Console.WriteLine("Dime pares o impares");
            opcion = Console.ReadLine();
            if (opcion == "pares")
            {
                for (int i = 2; i < 10; i = i + 2)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                for (int i = 1; i < 10; i = i +2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
