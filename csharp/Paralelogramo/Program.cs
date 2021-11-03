using System;

namespace Paralelogramo
{
    class Program
    {
        static void Main(string[] args)
        {
            Paralelogramo(4);
            Paralelogramo(20);
        }
        static void Paralelogramo(int size)
        {

            for (int row = 0; row < size; row++)
            {
                Console.Write(new string(' ', size - row));

                for (int col = 0; col < size; col++)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }
        }
    }
}
