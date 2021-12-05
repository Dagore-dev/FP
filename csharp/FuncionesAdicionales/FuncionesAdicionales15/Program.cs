using System;

namespace FuncionesAdicionales15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"¿3 es un cuadrado perfecto? {CuadradoPerfecto(3)} ");
            Console.WriteLine($"¿4 es un cuadrado perfecto? {CuadradoPerfecto(4)} ");
            Console.WriteLine($"¿6 es un cuadrado perfecto? {CuadradoPerfecto(6)} ");
            Console.WriteLine($"¿25 es un cuadrado perfecto? {CuadradoPerfecto(25)} ");

            Console.WriteLine();

            Console.Write("Cuadrados perfectos entre 0 y 20: ");
            ListaCuadradosPerfectos(0, 20);
        }
        /*
        Escribe dos funciones:
            • A la función CuadradoPerfecto le pasaremos un entero por parámetro y nos devolverá un boolean, que será true si el entero es un cuadrado perfecto y false si no lo es. Un número A es un cuadrado perfecto si existe otro número B que multiplicado por sí mismo nos da A. O, dicho de otra forma, un número es un cuadrado perfecto si su raíz cuadrada sale exacta. Ej.: 4, 9, 16, 25, etc.
            • A la función ListaCuadradosPerfectos le pasaremos dos enteros min y max y nos escribirá por pantalla todos los cuadrados perfectos que existen entre esos dos números. No devuelve nada porque escribe el resultado directamente por pantalla. Esta función usará la función anterior para el cálculo.
            
        Por ejemplo: ListaCuadradosPerfectos(10, 20) nos escribirá el 9 y el 16. 
        */
        static bool CuadradoPerfecto (int n)
        {
            bool isCuadradoPerfecto = true;

            if (Math.Sqrt(n) % 1 != 0)
            {
                isCuadradoPerfecto = false;
            }
            
            return isCuadradoPerfecto;
        }
        static void ListaCuadradosPerfectos (int min, int max)
        {
            int temp;
            
            if (min > max)
            {
                temp = min;
                min = max;
                max = temp;
            }

            for (int i = min; i <= max; i++)
            {
                if (CuadradoPerfecto(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
