using System;
using System.IO;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (CompruebaCoordenadas("ficheros/tarjeta5x5.cdn"))
            //{
            //    Console.WriteLine("Has acertado!");
            //}
            //else
            //{
            //    Console.WriteLine("Fallaste.");
            //}

            if (CompruebaCoordenadas("ficheros/tarjeta8x10.cdn"))
            {
                Console.WriteLine("Has acertado!");
            }
            else
            {
                Console.WriteLine("Fallaste.");
            }
        }
        static bool CompruebaCoordenadas (string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Random r = new Random();
            bool result = false;
            int rows = br.ReadInt32(), cols = br.ReadInt32(), row = r.Next(0, rows), col = r.Next(0, cols);
            string anwser;
            string[,] aa = new string[rows, cols];

            Console.WriteLine("Leyendo fichero ...");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    aa[i, j] = br.ReadString();
                }
            }

            Console.Write($"¿Qué cadena se encuentra en la posición [{row},{col}]? ");
            anwser = Console.ReadLine();

            if (anwser == aa[row, col])
            {
                result = true;
            }

            br.Close();
            fs.Close();
            return result;
        }
    }
}
