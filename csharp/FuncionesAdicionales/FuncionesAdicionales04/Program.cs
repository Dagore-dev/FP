using System;

namespace FuncionesAdicionales04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2 ^ 0 = {Potencia2(0)}");
            Console.WriteLine($"2 ^ 2 = {Potencia2(2)}");
            Console.WriteLine($"2 ^ 3 = {Potencia2(3)}");
            Console.WriteLine($"2 ^ 10 = {Potencia2(10)}");
            Console.WriteLine($"2 ^ (-15) = {Potencia2(-15)}");
        }

        static int Potencia2 (int number)
        {
            int result = 1;

            if (number < 0)
            {
                result = -1;
            }
            else
            {
                if (number == 0)
                {
                    result = 2;
                }
                else
                {
                    for (int i = 0; i < number; i++)
                    {
                        result *= 2;
                    }
                }
            }

            return result;
        }
    }
}
