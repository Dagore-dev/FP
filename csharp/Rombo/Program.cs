using System;

namespace Rombo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rombo(5);
            Rombo(10);
        }
        static void Rombo(int size)
        {

            for (int row = 0; row <= size; row++)
            {
                Console.Write(new string(' ', size - row));

                for (int col = 0; col < row; col++)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }

            for (int row = 0; row < size - 1; row++)
            {
                Console.Write(new string(' ', row + 1));

                for (int col = 0; col < size - (row + 1); col++)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }
        }
    }
}
