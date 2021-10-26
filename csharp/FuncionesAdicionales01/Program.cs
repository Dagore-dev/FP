using System;

namespace FuncionesAdicionales01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función primosRelativos a la que le pasas dos números enteros y te dice si son primos relativos, es decir, si no tienen ningún divisor común además del 1.

            Primosrelativos(6, 35);//Lo son.
            Primosrelativos(6, 27);//No lo son.
            Primosrelativos(5, 12);//Lo son.

        }
        static void Primosrelativos (int a, int b)
        {
            if (MCD(a, b) == 1)
            {
                Console.WriteLine($"{a} y {b} son primos relativos.");
            }
            else
            {
                Console.WriteLine($"{a} y {b} NO son primos relativos.");
            }
        }
        static int MCD (int a, int b)
        {
            int min, max, i;

            min = a < b ? a : b;
            max = a < b ? b : a;

            i = min;

            while (a % i != 0 || b % i != 0)
            {
                i--;
            }

            return i;
        }
    }
}
