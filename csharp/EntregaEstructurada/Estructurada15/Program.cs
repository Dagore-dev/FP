using System;

namespace Estructurada15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que te pide dos números. Si el primero es menor que el segundo, escribe todos  los números  comprendidos entre  ambos en  orden ascendente.  Si el primero es  mayor que  el segundo, escribe  todos los  números comprendidos  entre ambos en orden descendente.

            Console.WriteLine("Dame el primer número.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo número.");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                int cont = a;

                while (cont <= b)
                {
                    Console.WriteLine(cont);
                    cont++;
                }
            }
            else
            {
                int cont = a;
                while (cont >= b)
                {
                    Console.WriteLine(cont);
                    cont--;
                }
            }
        }
    }
}
