using System;

namespace Estructurada17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int acc = 0;

            while (i < 1001)
            {
                if(i % 2 == 0)
                {
                    acc += i;
                }
                
                i++;
            }
            
            Console.WriteLine(acc);
        }
    }
}
