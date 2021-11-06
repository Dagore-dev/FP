using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            PiramideNumeros(13);
            PiramideNumeros(-13);
        }
        static void PiramideNumeros (int size)
        {
            size = Math.Abs(size);

            for (int row = 0; row <= size; row++)
            {
                Console.WriteLine(ColContent(row));
            }
        }
        static string ColContent (int row)
        {
            string result = "";
            int counter = 1;

            for (int col = 0; col < row; col++)
            {
                result += counter;
                counter++;

                if (counter > 9)
                {
                    counter = 0;
                }
            }
            
            return result;
        }
    }
}
