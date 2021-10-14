using System;

namespace estructurada30
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, suma = 0;

            for ( i = 2; i <= 1000; i = i + 2)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
        }
    }
}
