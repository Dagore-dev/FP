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

            Console.WriteLine("Tablero [0,0] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 0, 0) + "\n");
            
            Console.WriteLine("Tablero [1,3] (False)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 1, 3) + "\n");
            
            Console.WriteLine("Tablero [1,5] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 1, 5) + "\n");
            
            Console.WriteLine("Tablero [1,4] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 1, 4) + "\n");
            
            Console.WriteLine("Tablero [6,2] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 6, 2) + "\n");
            
            Console.WriteLine("Tablero [7,0] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 7, 0) + "\n");
            
            Console.WriteLine("Tablero [3,2] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 3, 2) + "\n");
            
            Console.WriteLine("Tablero [3,1] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 3, 1) + "\n");
            
            Console.WriteLine("Tablero [4,6] (True)");
            Console.WriteLine(Comprueba1Dama(tableroAjedrez, 4, 6) + "\n");
            
            Console.WriteLine($"Comprueba dama = {CompruebaDamas(tableroAjedrez)}");
            Console.WriteLine($"Comprueba dama = {CompruebaDamas(tableroAjedrezVacio)}");
            Console.WriteLine($"Comprueba dama = {CompruebaDamas(tableroAjedrezMalo)}");
        }
        static bool Comprueba1Dama (int[,] aa, int row, int col)
        {
            bool result = false;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //Misma fila || Misma columna || Misma diagonal 0,0 1,1 2,2 || Misma diagonal 0,2 1,1 2,0
                    if (i == row || j == col || (i - j) == (row - col) || (i + j) == row + col)
                    {
                        //Si no es la misma casilla que estamos comprobando y su valor es distinto de cero (hay un pieza)
                        if ((i != row || j != col) && aa[i, j] != 0)
                        {
                            result = true;
                        }
                    }
                }
            }

            return result;
        }
        static bool CompruebaDamas (int[,] aa)
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
    }
}
