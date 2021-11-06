using System;

namespace Funciones09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que nos calcule el “mcm” de dos números. 
            Console.WriteLine(Mcm(27, 5));
        }
        static int Mcm(int a, int b)
        {
            int i = a > b ? a : b;//Máximo

            while (i % a != 0 || i % b != 0)//El mcm cumple que i % a == 0 && i % b == 0.
            {
                i++;
            }

            return i;
        }
    }
}
