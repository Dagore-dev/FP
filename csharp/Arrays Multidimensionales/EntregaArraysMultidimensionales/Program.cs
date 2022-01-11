using System;

namespace EntregaArraysMultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            ShowMenu();

            Console.Write("Elije una opción: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        int[,] a1 = { { 0, -1, 2 }, { 3, 4, -5 }, { -6, 7, 8 } }, a2 = { { 0, -10, 2 }, { 30, 4, -5 }, { -6, 7, 80 } };
                        EscribeArray3x3(a1);
                        Console.WriteLine("------------------");
                        EscribeArray3x3(a2);
                    }
                    break;
                case 2:
                    {
                        int[,] a1 = new int[3, 3];

                        Rellena3x3(a1);
                        EscribeArray3x3(a1);
                    }
                    break;
                case 3:
                    {
                        int[,] a1 = new int[3, 3];
                        RellenaAleatorio3x3(a1);
                        EscribeArray3x3(a1);
                    }
                    break;
                case 4:
                    {
                        int[,] a1 = { { 0, -1, 2 }, { 3, 4, -5 }, { -6, 7, 8 } }, a2 = { { 0, -10, 2 }, { 30, 4, -5 }, { -6, 7, 80 } };

                        EscribeArray3x3(a1);
                        Console.WriteLine(SumaArray3x3(a1));
                        Console.WriteLine();

                        EscribeArray3x3(a2);
                        Console.WriteLine(SumaArray3x3(a2));
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    {
                        int[,] a1 = { { 0, -1, 2, 3, 4 }, { -4, 3, 2, -1, 0 } };
                        EscribeArrayBi(a1);
                    }
                    break;
                case 6:
                    {
                        int[,] a1 = new int[2, 5];
                        RellenaAleatorioBi(a1);
                        EscribeArrayBi(a1);
                    }
                    break;
                case 7:
                    {
                        int[,] a1 = new int[3, 4], a2 = new int[2, 2];
                        RellenaEnordenBi(a1);
                        EscribeArrayBi(a1);
                        Console.WriteLine();
                        RellenaEnordenBi(a2);
                        EscribeArrayBi(a2);
                    }
                    break;
                case 8:
                    {
                        int[,] a1 = { { 0, -1, 2, 3, 4 }, { -4, 3, 2, -1, 0 } }, a2 = { { 1, 1, 1, 1 }, { 2, 2, 2, 2, }, { 3, 3, 3, 3 } };
                        EscribeArrayBi(a1);
                        Console.WriteLine(SumaArrayBi(a1));
                        Console.WriteLine();
                        EscribeArrayBi(a2);
                        Console.WriteLine(SumaArrayBi(a2));
                    }
                    break;
                case 9:
                    {
                        int[,] a1 = { { 1, 1 }, { 1, 1 } }, a2 = { { -1, -1 }, { -1, -1 } }, a3 = new int[2,2];
                        int[,] a4 = { { 1, 1 }, { 1, 1 }, { 1, 1 } }, a5 = { { -1, -1 }, { -1, -1 }, { 1, 1 } }, a6 = new int[3, 2];
                        int[,] a7 = { { 1, 1 }, { 1, 1 }, { 1, 1 } }, a8 = { { -1, -1 }, { -1, -1 }, { 1, 1 } }, a9 = new int[3, 4];

                        EscribeArrayBi(a1);
                        Console.WriteLine();
                        EscribeArrayBi(a2);
                        Console.WriteLine();
                        Suma2ArraysBi(a1, a2, a3);
                        EscribeArrayBi(a3);

                        Console.WriteLine("---------------------------");

                        EscribeArrayBi(a4);
                        Console.WriteLine();
                        EscribeArrayBi(a5);
                        Console.WriteLine();
                        Suma2ArraysBi(a4, a5, a6);
                        EscribeArrayBi(a6);

                        Console.WriteLine("---------------------------");

                        EscribeArrayBi(a7);
                        Console.WriteLine();
                        EscribeArrayBi(a8);
                        Console.WriteLine();
                        Suma2ArraysBi(a7, a8, a9);
                        EscribeArrayBi(a9);
                    }
                    break;
                case 10:
                    {
                        int[,] a1 = { { 1, 1 }, { 1, 1 } }, a2 = { { -1, -1 }, { -1, -1 } }, a3 = new int[2, 2], a4 = new int[3,2];

                        EscribeArrayBi(a1);
                        EscribeArrayBi(a2);
                        CopiaArrayBi(a1, a2);
                        Console.WriteLine();
                        EscribeArrayBi(a2);

                        Console.WriteLine("-----------------");

                        EscribeArrayBi(a1);
                        EscribeArrayBi(a3);
                        CopiaArrayBi(a1, a3);
                        Console.WriteLine();
                        EscribeArrayBi(a3);

                        Console.WriteLine("-----------------");

                        EscribeArrayBi(a1);
                        EscribeArrayBi(a4);
                        CopiaArrayBi(a1, a4);
                        Console.WriteLine();
                        EscribeArrayBi(a4);
                    }
                    break;
                case 11:
                    {
                        int[,] a1 = { { 1, 1 }, { 1, 1 } }, a2 = { { -1, -1 }, { -1, -1 } };

                        EscribeArrayBi(a1);
                        Console.WriteLine();
                        EscribeArrayBi(CopiaArrayBiPro(a1));
                        Console.WriteLine("------------------------");
                        EscribeArrayBi(a2);
                        Console.WriteLine();
                        EscribeArrayBi(CopiaArrayBiPro(a2));
                    }
                    break;
                case 12:
                    {
                        int[,] chessTable = new int[8, 8];

                        RellenaArrayAjedrez(chessTable);
                        EscribeArrayBi(chessTable);
                    }
                    break;
                case 13:
                    {
                        int[,] a1 = new int[4, 4], a2 = new int[5, 5];

                        RellenaDiagonal(a1);
                        EscribeArrayBi(a1);
                        Console.WriteLine();
                        RellenaDiagonal(a2);
                        EscribeArrayBi(a2);
                    }
                    break;
                case 14:
                    {
                        int[,] a1 = new int[4, 4], a2 = new int[5, 5];

                        RellenaX(a1);
                        EscribeArrayBi(a1);
                        Console.WriteLine();
                        RellenaX(a2);
                        EscribeArrayBi(a2);
                    }
                    break;
                case 15:
                    {
                        int[,] a1 = new int[4, 4], a2 = new int[6, 6], a3 = new int[1, 3];

                        RellenaCuadros(a1);
                        EscribeArrayBi(a1);
                        Console.WriteLine();
                        RellenaCuadros(a2);
                        EscribeArrayBi(a2);
                        Console.WriteLine();
                        RellenaCuadros(a3);
                        EscribeArrayBi(a3);
                    }
                    break;
                default:
                    break;
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("MENU");

            Console.WriteLine(" 1 - EscribeArray3x3");
            Console.WriteLine(" 2 - Rellena3x3");
            Console.WriteLine(" 3 - RellenaAleatorio3x3");
            Console.WriteLine(" 4 - SumaArray3x3");
            Console.WriteLine(" 5 - EscribeArrayBi");
            Console.WriteLine(" 6 - RellenaAleatorioBi");
            Console.WriteLine(" 7 - RellenaEnordenBi");
            Console.WriteLine(" 8 - SumaArrayBi");
            Console.WriteLine(" 9 - Suma2ArraysBi");
            Console.WriteLine("10 - CopiaArrayBi");
            Console.WriteLine("11 - CopiaArrayBiPro");
            Console.WriteLine("12 - RellenaArrayAjedrez");
            Console.WriteLine("13 - RellenaDiagonal");
            Console.WriteLine("14 - RellenaX");
            Console.WriteLine("15 - RellenaCuadros");
        }
        static void EscribeArray3x3 (int[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(a[i,j] >= 0)
                    {
                        Console.Write(' ');
                    }
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void Rellena3x3 (int[,] a)
        {
            int n = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = n;
                    n++;
                }
            }
        }
        static void RellenaAleatorio3x3 (int[,] a)
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = r.Next();
                }
            }
        }
        static int SumaArray3x3 (int[,] a)
        {
            int result = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result += a[i, j];
                }
            }
            return result;
        }
        static void EscribeArrayBi (int[,] a)
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
        static void RellenaAleatorioBi (int[,] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next();
                }
            }
        }
        static void RellenaEnordenBi (int[,] a)
        {
            int n = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = n;
                    n++;
                }
            }
        }
        static int SumaArrayBi (int[,] a)
        {
            int result = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result += a[i, j];
                }
            }
            return result;
        }
        static void Suma2ArraysBi (int[,] a1, int[,] a2, int[,] a3)
        {
            bool a1SizeEqualToa2Size = CheckBiArraySize(a1, a2), a2SizeEqualToa3Size = CheckBiArraySize(a2, a3);

            if (a1SizeEqualToa2Size && a2SizeEqualToa3Size)
            {
                for (int i = 0; i < a1.GetLength(0); i++)
                {
                    for (int j = 0; j < a2.GetLength(1); j++)
                    {
                        a3[i, j] = a1[i, j] + a2[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: Arrays de diferentes tamaños.");
            }
        }
        static bool CheckBiArraySize(int[,] a1, int[,] a2)
        {
            bool result = false;
            if (a1.GetLength(0) == a2.GetLength(0) && a1.GetLength(1) == a2.GetLength(1))
            {
                result = true;
            }
            return result;
        }
        static void CopiaArrayBi (int[,] a1, int[,] a2)
        {
            if (CheckBiArraySize(a1, a2))
            {
                for (int i = 0; i < a1.GetLength(0); i++)
                {
                    for (int j = 0; j < a1.GetLength(1); j++)
                    {
                        a2[i, j] = a1[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: Los arrays no tienen el mismo tamaño.");
            }
        }
        static int[,] CopiaArrayBiPro (int[,] a1)
        {
            int[,] result = new int[a1.GetLength(0), a1.GetLength(1)];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    result[i, j] = a1[i, j];
                }
            }
            return result;
        }
        static void RellenaArrayAjedrez (int[,] a)
        {
            int cell = 0;
            if (a.GetLength(0) == 8 && a.GetLength(1) == 8)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    cell = cell == 1 ? 0 : 1;
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = cell;
                        cell = cell == 1 ? 0 : 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: No es un tablero de ajedrez.");
            }
        }
        static void RellenaDiagonal (int[,] a)
        {
            if (a.GetLength(0) == a.GetLength(1))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (IsInDiagonal(i, j))
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            if (IsInUpperTriangle(i, j))
                            {
                                a[i, j] = 2;
                            }
                            else
                            {
                                a[i, j] = 3;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: No es un array cuadrado.");
            }
        }
        static bool IsInUpperTriangle (int i, int j)
        {
            return i < j;
        }
        static bool IsInDiagonal (int i, int j)
        {
            return i == j;
        }
        static void RellenaX (int[,] a)
        {
            if (a.GetLength(0) == a.GetLength(1))
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (IsInX(i, j, a.GetLength(1)))
                        {
                            a[i, j] = 1;
                        }
                        else
                        {
                            a[i, j] = 2;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: No es un array cuadrado.");
            }
        }
        static bool IsInX (int i, int j, int size)
        {
            /*La suma de las coordenadas es igual a tamaño -1 para la otra diagonal. */
            return IsInDiagonal(i, j) || (i + j) == size - 1;
        }
        static void RellenaCuadros (int[,] a)
        {
            int section, center = a.GetLength(0) / 2;
            if (a.GetLength(0) == a.GetLength(1) && a.Length % 2 == 0)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        section = GetSection(i, j, center);
                        a[i, j] = section;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR: No es un array cuadrado de lado par.");
            }
        }
        static int GetSection (int i, int j, int center)
        {
            int result;

            if (i < center)
            {
                if (j < center)
                {
                    result = 1;
                }
                else
                {
                    result = 2;
                }
            }
            else
            {
                if (j < center)
                {
                    result = 3;
                }
                else
                {
                    result = 4;
                }
            }

            return result;
        }
    }
}
