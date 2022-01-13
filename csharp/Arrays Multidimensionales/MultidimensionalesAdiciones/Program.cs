using System;
using System.Collections.Generic;

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
                        int[,] a1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } }, a2 = { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } }, a3 = { { 6, 1, 1 }, { 4, -2, 5 }, { 2, 8, 7 } };

                        EscribeArrayBi(a1);
                        Console.WriteLine(CuadradoMagico(a1));

                        Console.WriteLine("----------------------");

                        EscribeArrayBi(a2);
                        Console.WriteLine(CuadradoMagico(a2));
                        
                        Console.WriteLine("----------------------");

                        EscribeArrayBi(a3);
                        Console.WriteLine(CuadradoMagico(a3));
                    }
                    break;
                case 4:
                    {
                        int[,] 
                            a1 = { { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 } },
                            a2 = { { 4,1,7,6,3,9,2,8,5}, {6,5,2,8,1,4,3,9,7}, { 3,9,8,5,7,2,1,6,4}, {2,3,4,9,6,7,8,5,1 }, { 9,8,1,2,5,3,4,7,6}, { 5,7,6,4,8,1,9,3,2}, {7,2,3,1,9,5,6,4,8 }, { 8,4,9,7,2,6,5,1,3}, { 1,6,5,3,4,8,7,2,9} };

                        EscribeArrayBi(a1);
                        Console.WriteLine(CompruebaSudoku(a1));
                        Console.WriteLine();
                        EscribeArrayBi(a2);
                        Console.WriteLine(CompruebaSudoku(a2));
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
            Console.WriteLine("5 - RellenaBordeBidimensional");
            Console.WriteLine("6 - HundirLaFlota");
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
        static int[] EliminaRepetidos(int[] a)
        {
            List<int> l = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!l.Contains(a[i]))
                {
                    l.Add(a[i]);
                }
            }

            return l.ToArray();
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
        static bool CuadradoMagico (int[,] a)
        {
            int row = a.GetLength(0), col = a.GetLength(1), k = 0;
            int[] sums;
            bool result = true;

            if (row == 3 && col == 3)
            {
                sums = new int[8];

                for (int i = 0; i < row; i++)
                {
                    sums[k] = SumRow(a, i);
                    k++;
                }

                for (int i = 0; i < col; i++)
                {
                    sums[k] = SumCol(a, i);
                    k++;
                }

                //Primera diagonal
                for (int i = 0; i < row; i++)
                {
                    sums[k] += a[i, i];
                }
                k++;

                //Segunda diagonal
                for (int i = 0; i < row; i++)
                {
                    sums[k] += a[i, row - 1 - i];//(0,2), (1,1), (2,0)
                }

                for (int i = 0; i < sums.Length; i++)
                {
                    if (sums[0] != sums[i])
                    {
                        result = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: No es una matrix 3x3.");
                result = false;
            }

            return result;
        }
        static int SumRow (int[,] a, int row)
        {
            int result = 0, col = a.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                result += a[row, i];
            }
            
            return result;
        }
        static int SumCol(int[,] a, int col)
        {
            int result = 0, row = a.GetLength(0);

            for (int i = 0; i < row; i++)
            {
                result += a[i, col];
            }

            return result;
        }
        static bool CompruebaSudoku (int[,] a)
        {
            int row = a.GetLength(0), col = a.GetLength(1), j = 0;
            bool[] results = new bool[27];
            bool result = true;

            if (row == 9 && col == 9)
            {
                //Filas
                for (int i = 0; i < row; i++)
                {
                    results[j] = CompruebaArray19(RowFromMatrix(a, i));
                    j++;
                }

                //Columnas
                for (int i = 0; i < col; i++)
                {
                    results[j] = CompruebaArray19(ColFromMatrix(a, i));
                    j++;
                }

                //Cuadrados
                CheckSquaresFromSudoku(a, ref results, j);

                //Comprueba resultados:
                for (int i = 0; i < results.Length; i++)
                {
                    if (!results[i])
                    {
                        result = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: No es un sudoku 9x9.");
            }

            return result;
        }
        static int[] RowFromMatrix (int[,] aa, int row)
        {
            int col = aa.GetLength(1);
            int[] slice = new int[col];

            for (int i = 0; i < col; i++)
            {
                slice[i] = aa[row, i];
            }

            return slice;
        }
        static int[] ColFromMatrix (int[,] aa, int col)
        {
            int row = aa.GetLength(0);
            int[] slice = new int[row];

            for (int i = 0; i < row; i++)
            {
                slice[i] = aa[i, col];
            }

            return slice;
        }
        static int[] MatrixToArray (int[,] matrix)
        {
            int row = matrix.GetLength(0), col = matrix.GetLength(1);
            List<int> l = new List<int>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    l.Add(matrix[i, j]);
                }
            }

            return l.ToArray();
        }
        static bool CompruebaArray19 (int[] a)
        {
            int current, length = a.Length;
            int[] set;
            bool result = true;

            if (length == 9)
            {
                for (int i = 0; i < length; i++)
                {
                    current = a[i];
                    if (current < 1 || current > 9)
                    {
                        result = false;
                        i = length;
                    }
                }

                if (result)
                {
                    set = EliminaRepetidos(a);
                    if (length != set.Length)
                    {
                        result = false;
                    }

                }
            }
            else
            {
                Console.WriteLine("ERROR: No tiene nueve elementos.");
            }

            return result;
        } 
        static int[] ArrayFromSudokuSquare (int[,] matrix, int startRow, int startCol, int endRow, int endCol)
        {
            List<int> l = new List<int>();
            bool isCorrect = CheckArgs(matrix, startRow, startCol, endRow, endCol);

            if (isCorrect)
            {
                for (int i = startRow; i <= endRow; i++)
                {
                    for (int j = startCol; j <= endCol; j++)
                    {
                        l.Add(matrix[i, j]);
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: Problem with arguments");
            }
            
            return l.ToArray();
        }
        static bool CheckArgs (int[,] matrix, int startRow, int startCol, int endRow, int endCol)
        {
            int row = matrix.GetLength(0), col = matrix.GetLength(1);
            bool result = true;

            if (startRow < 0
                || startRow > row
                || endRow < startRow
                || endRow > row
                || startCol < 0
                || startCol > col
                || endCol < startCol
                || endCol > col)
            {
                result = false;
            }

            return result;
        } 
        static void CheckSquaresFromSudoku (int[,] matrix, ref bool[] results, int index)
        {
            /*    
                0 => 0 0 2 2
                1 => 0 3 2 5 
                2 => 0 6 2 8
                3 => 3 0 5 2
                4 => 3 3 5 5  
                5 => 3 6 5 8
                6 => 6 0 8 2
                7 => 6 3 8 5
                8 => 6 6 8 8
            */
            int[] starts = { 0, 3, 6 }, ends = { 2, 5, 8 };
            int startRow, startCol, endRow, endCol;

            for (int i = 0; i < 3; i++)
            {
                startRow = starts[i];
                endRow = ends[i];
                for (int j = 0; j < 3; j++)
                {
                    startCol = starts[j];
                    endCol = ends[j];
                    results[index] = CompruebaArray19(ArrayFromSudokuSquare(matrix, startRow, startCol, endRow, endCol));
                    index++;
                }
            }
        }
    }
}
