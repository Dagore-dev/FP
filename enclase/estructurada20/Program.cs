using System;

namespace estructurada20
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, n, i;
            Console.WriteLine("Dime un numero");

            n = int.Parse(Console.ReadLine());

            max = n;

            i = 0;
            while (i < 9)
            {
                Console.WriteLine("Dime otro numero");
                n = int.Parse(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
                i++;
            }
            Console.WriteLine(max);
        }
    }
}
