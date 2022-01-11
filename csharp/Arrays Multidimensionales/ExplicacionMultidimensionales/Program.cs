using System;

namespace ExplicacionMultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Normalmente usamos un primer índice para la "fila" y el segundo índice para la "columna". Como son arrays tienen un tamaño inicial que no se puede alterar aunque el valor de cada elemento puede cambiarse sin problema.
                En muchos lenguajes los arrays multidimensionales no son más que arrays de arrays, no existen como tal.
                C# sí tiene una implementación para arrays multidimensionales.
            */

            //int[][] a = new int[5][5] así se crearía en Java.

            int[,] a = new int[3, 4];//Crea un array multidimensional 3x4.
            int[,] a2 = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } };//Se inicializan con valores con la misma sintáxis.

            a[0, 0] = 10;//Podemos acceder a los valores con esta sintáxis.
            Console.WriteLine(a[2,3]);//El último valor de a (3-1, 4-1).

            Console.WriteLine(a.Length);//Devuelve x * y.
            a.GetLength(0);//Devuelve el length de la fila, la primera dimensión.
            a.GetLength(1);//Devuelve el length de la columna, la segunda dimensión.

            //for (int i = 0; i < a2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a2[i,j]);
            //    }
            //}

            EscribeArrayMulti(a2);
        }
        static void EscribeArrayMulti (int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
