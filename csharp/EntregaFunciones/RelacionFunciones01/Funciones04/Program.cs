using System;

namespace Funciones04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “ImprimeSerie” a la que le pases dos enteros y te escriba por la pantalla todos los valores comprendidos entre ambos.Lo hará en orden ascendente si el primero es menor que el segundo y descendente en caso contrario. Usa “for”.
        }
        static void ImprimeSerie (int num1, int num2)
        {
            if (num1 > num2)
            {
                for (int i = num1; i >= num2; i--)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                for (int j = num1; j <= num2; j++)
                {
                    Console.Write($"{j} ");
                }
            }
        }
    }
}
