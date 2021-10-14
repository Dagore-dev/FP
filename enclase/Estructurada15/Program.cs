using System;

namespace Estructurada15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el primer número.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo número.");
            int b = int.Parse(Console.ReadLine());

            if(a < b)
            {
                int cont = a;

                while (cont <= b)
                {
                    Console.WriteLine(cont);
                    cont++;
                }
            }
            if(a > b)
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
