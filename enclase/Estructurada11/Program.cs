using System;

namespace Estructurada11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int acc = 0;

            while (acc < 10)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                    acc++;
                }

                i++;
            }
        }
    }
}
