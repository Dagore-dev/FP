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
            int size = a.GetLength(0);
            if (size == 3 && a.GetLength(1) == 3)
            {

            }
            else
            {
                Console.WriteLine("ERROR: No es una matriz 3x3.");
            }
        }
        static int Diagonal (int a, int b)
        {
            int result = 0;

            return result;
        }
    }
}
