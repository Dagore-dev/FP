using System;

namespace FuncionesAdicionales11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribe  tres  funciones  que  se  llamarán  Maximo,  Medio  y  Minimo.  A  cada  una  de  las funciones le pasaremos tres valores enteros (a, b, c). La función Maximo nos devolverá el mayor de los tres, la función Minimo el menor de los tres y la función  Medio el del medio. 
             
             Ej.: Maximo(7, 1, 4) nos devolverá 7.  
            */

            Console.WriteLine($"De 7, 1 y 4: El máximo es {Maximo(7, 1, 4)}, el mínimo {Minimo(7, 1, 4)} y el medio {Medio(7, 1, 4)}");
        }

        static int Medio(int v1, int v2, int v3)
        {
            int result;

            if (v1 < v2)
            {
                if (v1 < v3)
                {
                    result = v3;
                }
                else
                {
                    result = v1;
                }
            }
            else
            {
                if (v2 < v3)
                {
                    result = v3;
                }
                else
                {
                    result = v2;
                }
            }

            return result;
        }

        static int Minimo(int v1, int v2, int v3)
        {
            int result;

            if (v1 < v2)
            {
                if (v1 < v3)
                {
                    result = v1;
                }
                else
                {
                    result = v3;
                }
            }
            else
            {
                if (v2 < v3)
                {
                    result = v2;
                }
                else
                {
                    result = v3;
                }
            }

            return result;
        }

        static int Maximo(int v1, int v2, int v3)
        {
            int result;

            if (v1 < v2)
            {
                if (v2 < v3)
                {
                    result = v3;
                }
                else
                {
                    result = v2;
                }
            }
            else
            {
                if(v1 < v3)
                {
                    result = v3;
                }
                else
                {
                    result = v1;
                }
            }

            return result;
        }
    }
}
