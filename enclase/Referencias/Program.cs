using System;

namespace Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n = 0;
            
            Return123(out a, out b, out c);

            Console.WriteLine($"a = {a}, b = {b} y c = {c}");

            Increment(ref n);

            Console.WriteLine(n);
        }
        static void Return123 (out int a, out int b, out int c)
        {
            a = 1; b = 2; c = 3;
        }
        static void Increment (ref int n)
        {
            n += 1;
        }
    }
}
