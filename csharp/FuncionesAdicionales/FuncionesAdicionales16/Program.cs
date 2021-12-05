using System;

namespace FuncionesAdicionales16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Descomposición factorial de 10: ");
            DescomponerFactoresPrimos(10);

            Console.WriteLine();
            
            Console.Write("Descomposición factorial de 11: ");
            DescomponerFactoresPrimos(11);

            Console.WriteLine();

            Console.Write("Descomposición factorial de 24: ");
            DescomponerFactoresPrimos(24);

            Console.WriteLine();

            Console.Write("Descomposición factorial de 50: ");
            DescomponerFactoresPrimos(50);

            Console.WriteLine();

            Console.Write("Descomposición factorial de 77: ");
            DescomponerFactoresPrimos(77);

            Console.WriteLine();

            Console.Write("Descomposición factorial de 360: ");
            DescomponerFactoresPrimos(360);
        }
        static void DescomponerFactoresPrimos (int n)
        {
            /*
            Escribe la función DescomponerFactoresPrimos a la que le pasamos un entero y nos escribe por pantalla sus factores primos. No devuelve nada porque escribe los datos por pantalla.
            Ejemplo: Si le pasamos el número 24, nos debería escribir: 2 2 2 3
            */

            while (n % 2 == 0)
            {
                n /= 2;
                Console.Write(2 + " ");
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            if (n > 2)
            {
                Console.Write(n);
            }
                
        }
    }
}
