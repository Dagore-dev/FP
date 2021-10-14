using System;

namespace estrucuturada27
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("dime un numero");
            n = int.Parse(Console.ReadLine());

            for ( i = 1; i < 10; i++)
            {
                Console.WriteLine(n + "x" + i + "=" + (i * n));
            }
        }
    }
}
