using System;

namespace Funciones08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que nos calcule el “MCD” de dos números.
        }
        static int MCD (int a, int b)
        {
            int i = a < b ? a : b;//Mínimo

            while (a % i != 0 || b % i != 0)//MCD cumple que a % i == 0 && b % i == 0
            {
                i--;
            }

            return i;
        }
    }
}
