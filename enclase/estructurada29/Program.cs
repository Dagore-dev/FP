using System;

namespace estructurada29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, max, min;
            Console.WriteLine("Dime un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro numero");
            b = int.Parse(Console.ReadLine());

            min = Math.Min(a, b);
            max = Math.Max(a, b);

            for ( i = min; i <= max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
