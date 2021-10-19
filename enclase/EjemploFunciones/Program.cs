using System;

namespace EjemploFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            for(i = 2; i <= 1000; i++)
            {
                if(IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static bool IsPrime (int n)
        {
            int number = n, counter = 0;

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
