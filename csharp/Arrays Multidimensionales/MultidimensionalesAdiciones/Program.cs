using System;

namespace MultidimensionalesAdiciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            ShowMenu();

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        int[,] a1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
                        int[,] a2 = { { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

                        EscribeArrayBi(a1);
                        InvierteBI(a1);
                        Console.WriteLine();
                        EscribeArrayBi(a1);

                        Console.WriteLine("---------------");

                        EscribeArrayBi(a2);
                        InvierteBI(a2);
                        Console.WriteLine();
                        EscribeArrayBi(a2);

                        Console.WriteLine("---------------");
                    }
                    break;
                case 2:
                    {
                        int[,] a1 = { { 6, 1, 1 }, { 4, -2, 5 }, { 2, 8, 7 } }, a2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                        EscribeArrayBi(a1);
                        Console.WriteLine($"|a1| = {CalculaDeterminante(a1)}");

                        Console.WriteLine();

                        EscribeArrayBi(a2);
                        Console.WriteLine($"|a2| = {CalculaDeterminante(a2)}");
                    }
                    break;
                case 3:
                    {

                    }
                    break;
                case 4:
                    {

                    }
                    break;
                case 5:
                    {

                    }
                    break;
                default:
                    break;
            }
        }
        static void ShowMenu ()
        {
            Console.WriteLine("MENU");

            Console.WriteLine("1 - InvierteBi");
            Console.WriteLine("2 - CalculaDeterminante");
            Console.WriteLine("3 - CuadradoMagico");
            Console.WriteLine("4 - CompruebaSudoku");
            Console.WriteLine("4 - RellenaBordeBidimensional");
            Console.WriteLine("5 - HundirLaFlota");
            Console.Write("Introduzca su opción: ");
        }
        #region utils
        static void EscribeArrays(int[] a)
        {
            string result = "";

            if (a.Length > 0)
            {
                result += "[";

                for (int i = 0; i < a.Length - 1; i++)
                {
                    result += a[i] + ", ";
                }

                result += $"{a[a.Length - 1]}]";
            }
            else
            {
                result += "[]";
            }

            Console.WriteLine(result);
        }
        static void EscribeArrayBi(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] >= 0)
                    {
                        Console.Write(' ');
                    }
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static bool IsInDiagonal(int i, int j)
        {
            return i == j;
        }
        #endregion
        static void InvierteBI (int[,] a)
        {
            int temp;
            if (a.GetLength(0) == a.GetLength(1))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = i + 1; j < a.GetLength(1); j++)//Empezamos aquí para no recorrer dos veces el mismo triángulo.
                    {
                        temp = a[i, j];
                        a[i, j] = a[j, i];
                        a[j, i] = temp;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: El array no es cuadrado.");
            }
        }
        static int CalculaDeterminante (int[,] a)
        {
            //https://www.mathsisfun.com/algebra/matrix-determinant.html
            int row = a.GetLength(0), col = a.GetLength(1), result = 0;
            if (row == 3 && col == 3)
            {
                result = a[0, 0] * determinant2x2From3x3(a, 0) - a[0, 1] * determinant2x2From3x3(a, 1) + a[0, 2] * determinant2x2From3x3(a, 2);
            }
            else
            {
                Console.WriteLine("ERROR: No es una matriz 3x3.");
            }

            return result;
        }
        static int determinant2x2From3x3 (int[,] aa, int excluded)
        {
            int[] a = partialMatrixFrom3x3(aa, excluded);

            return a[0] * a[3] - a[1] * a[2];
        }
        static int[] partialMatrixFrom3x3 (int[,] a, int excluded)
        {
            int row = a.GetLength(0), col = a.GetLength(1), k = 0;
            int[] result = new int[4];

            for (int i = 1; i < row; i++)//Primera fila siempre excluida.
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != excluded)
                    {
                        result[k] = a[i, j];
                        k++;
                    }
                }
            }

            return result;
        }
    }
}
