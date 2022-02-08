using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableroAjedrez = { 
                          { 0, 0, 0, 0, 0, 1, 0, 0 },
                          { 0, 0, 0, 1, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 1, 0 },
                          { 1, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 1 },
                          { 0, 1, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 1, 0, 0, 0 },
                          { 0, 0, 1, 0, 0, 0, 0, 0 } };

            int[,] tableroAjedrezMalo = {
                          { 0, 0, 0, 0, 0, 1, 0, 0 },
                          { 0, 0, 0, 1, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 1, 0 },
                          { 1, 0, 0, 1, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 1 },
                          { 0, 1, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 1, 0, 0, 0 },
                          { 0, 0, 1, 0, 0, 0, 0, 0 } };

            int[,] tableroAjedrezVacio = { 
                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 0 } };

            Console.WriteLine("Tablero [0,0]");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 0, 0));
            Console.WriteLine();
            Console.WriteLine("Tablero [1,3] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 1, 3));
            Console.WriteLine();
            Console.WriteLine("Tablero [1,5] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 1, 5));
            Console.WriteLine();
            Console.WriteLine("Tablero [1,4] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 1, 4));
            Console.WriteLine();
            Console.WriteLine("Tablero [6,2] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 6, 2));
            Console.WriteLine();
            Console.WriteLine("Tablero [7,0] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 7, 0));
            Console.WriteLine();
            Console.WriteLine("Tablero [3,2] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 3, 2));
            Console.WriteLine();
            Console.WriteLine("Tablero [3,1] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 3, 1));
            Console.WriteLine();
            Console.WriteLine("Tablero [4,6] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 4, 6));
            Console.WriteLine();
            Console.WriteLine("Tablero ajedrez vacío (False siempre)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrezVacio, 0, 0));
            Console.WriteLine();
            Console.WriteLine($"Comprueba dama = {CompruebaDama(tableroAjedrez)}");
            Console.WriteLine($"Comprueba dama = {CompruebaDama(tableroAjedrezMalo)}");
        }
        static bool Comprueba1Dama (int[,] aa, int row, int col)
        {
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        if (i == row || j == col || (i - j) == (row - col) || (i + j) == row + col)
            //        {
            //            if (i != row || j != col && aa[i, j] != 0)
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //}

            //return false;
            
            bool result = false;

            if (CheckColUp(aa, row, col))
            {
                result = true;
            }
            if (CheckColDown(aa, row, col))
            {
                result = true;
            }
            if (CheckRowLeft(aa, row, col))
            {
                result = true;
            }
            if (CheckRowRight(aa, row, col))
            {
                result = true;
            }
            if (CheckDiagonalRightUp(aa, row, col))
            {
                result = true;
            }
            if (CheckDiagonalRightDown(aa, row, col))
            {
                result = true;
            }
            if (CheckDiagonalLeftDown(aa, row, col))
            {
                result = true;
            }
            if (CheckDiagonalLeftUp(aa, row, col))
            {
                result = true;
            }

            return result;
        }
        static bool CompruebaDama (int[,] aa)
        {
            bool result = false;
            int rows = aa.GetLength(0), cols = aa.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (aa[i,j] != 0 && Comprueba1Dama(aa, i, j))
                    {
                        result = true;
                        i = rows;
                        j = cols;
                    }
                }
            }
            
            return result;
        }
        static bool CheckColUp (int[,] aa, int row, int col)
        {
            bool result = false;

            if (row != 0)
            {
                for (int i = row - 1; i >= 0 ; i--)
                {
                    if (aa[i, col] != 0)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
        static bool CheckColDown (int[,] aa, int row, int col)
        {
            bool result = false;
            int rows = aa.GetLength(0);

            if (row + 1 != rows)
            {
                for (int i = row + 1; i < rows; i++)
                {
                    if (aa[i, col] != 0)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
        static bool CheckRowLeft (int[,] aa, int row, int col)
        {
            bool result = false;

            if (col != 0)
            {
                for (int i = col - 1; i >= 0; i--)
                {
                    if (aa[row, i] != 0)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }
        static bool CheckRowRight (int[,] aa, int row, int col)
        {
            bool result = false;
            int cols = aa.GetLength(1);

            if (col + 1 < cols)
            {
                for (int i = col + 1; i < cols; i++)
                {
                    if (aa[row, i] != 0)
                    {
                        result = true;
                    }
                }
            }
            
            return result;
        }
        static bool CheckDiagonalRightUp (int[,] aa, int row, int col)
        {
            bool result = false;
            int cols = aa.GetLength(1), i = row - 1, j = col + 1;

            while (i >= 0 && j < cols)
            {
                if (aa[i, j] != 0)
                {
                    result = true;
                }
                i--;
                j++;
            }

            return result;
        }
        static bool CheckDiagonalRightDown (int[,] aa, int row, int col)
        {
            bool result = false;
            int rows = aa.GetLength(0), cols = aa.GetLength(1), i = row + 1, j = col + 1;

            while (i < rows && j < cols)
            {
                if (aa[i,j] != 0)
                {
                    result = true;
                }
                i++;
                j++;
            }

            return result;
        }
        static bool CheckDiagonalLeftDown (int[,] aa, int row, int col)
        {
            bool result = false;
            int rows = aa.GetLength(0), i = row + 1, j = col - 1;

            while (i < rows && j >= 0)
            {
                if (aa[i,j] != 0)
                {
                    result = true;
                }
                i++;
                j--;
            }

            return result;
        }
        static bool CheckDiagonalLeftUp (int[,] aa, int row, int col)
        {
            bool result = false;
            int i = row - 1, j = col - 1;

            while (i > 0 && j > 0)
            {
                if (aa[i, j] != 0)
                {
                    result = true;
                }
                i--;
                j--;
            }

            return result;
        }
    }
}
