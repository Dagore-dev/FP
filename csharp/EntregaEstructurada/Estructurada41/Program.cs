using System;

namespace Estructurada41
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generalizar el algoritmo anterior (averiguar si un número es primo o no) para averiguar todos los números primos que existen entre 2 y 1000.

            int current, counter = 0;

            for (current = 2; current <= 1000; current++)
            {
                for (int j = 1; j <= current; j++)
                {
                    if (current % j == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 2)
                {
                    Console.WriteLine(current);
                    counter = 0;
                }
                else
                {
                    counter = 0;
                }
            }
        }
    }
}
