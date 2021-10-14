using System;

namespace estrucuturada28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Dime un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro numero");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a;  i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = a - 1; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
