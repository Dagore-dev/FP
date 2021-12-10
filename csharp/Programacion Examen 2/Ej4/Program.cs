using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 93, 87, 89, 82, 80, 88, 76, 80, 92, 91, 78 }, a2 = { 87, 87, 85, 83, 87, 85, 82, 86, 92, 95, 83 }, a3 = { 87, 87, 85, 101, 87, 85, 82, 86, 92, 95, 83 }, a4 = { 3, 4, 6};

            Console.WriteLine(FootballCards(a1, a2));//Devuelve 2.
            Console.WriteLine(FootballCards(a2, a1));//Devuelve 1.
            Console.WriteLine(FootballCards(a2, a2));//Devuelve 0.
            Console.WriteLine(FootballCards(a1, a1));//Devuelve 0.
            Console.WriteLine(FootballCards(a1, a3));//Devuelve -1, puntuación mal de algún jugador.
            Console.WriteLine(FootballCards(a1, a4));//Devuelve -1, número de jugadores incorrecto.
        }
        static int FootballCards (int[] a1, int[] a2)
        {
            int result = -1;

            if (a1.Length == 11 && a2.Length == 11)
            {
                if (HasCorrectPlayerValues(a1, a2))
                {
                    result = PlayMatch(a1, a2);
                }
            }

            return result;
        }
        static bool HasCorrectPlayerValues (int[] a1, int[] a2)
        {
            bool result = true;

            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] < 0 || a1[i] > 100 || a2[i] < 0 || a2[i] > 100)
                {
                    result = false;
                    i = a1.Length;
                }
            }

            return result;
        }
        static int PlayMatch (int[] a1, int[] a2)
        {
            int result = 1, team1 = 0, team2 = 0, mvp1 = MaxArray(a1), mvp2 = MaxArray(a2);

            //Reparto de puntos regular
            for (int i = 0; i < a1.Length; i += 2)
            {
                if (a1[i] > a2[i])
                {
                    team1++;
                }
                else
                {
                    if (a1[i] < a2[i])
                    {
                        team2++;
                    }
                }
            }

            //Reparto de puntos entre los mejores de cada equipo
            if (mvp1 > mvp2)
            {
                team1 += 2;
            }
            else
            {
                if (mvp1 < mvp2)
                {
                    team2 += 2;
                }
            }

            //Determinación del resultado
            if (team1 < team2)
            {
                result = 2;
            }
            else
            {
                if (team1 == team2)
                {
                    result = 0;
                }
            }

            return result;
        }
        static int MaxArray(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }
    }
}
