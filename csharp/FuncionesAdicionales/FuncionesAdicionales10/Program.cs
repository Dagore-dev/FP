using System;

namespace FuncionesAdicionales10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe  una  función  EscribeSerieNumeros3  que  nos  pide  tres  números.  El  primero tendrá que ser un número entre 1 y 100; si el número no es correcto, lo vuelve a pedir. 
                
            El segundo tendrá que ser un número entre 1 y 100 pero con la condición de que sea mayor que el primero; lo volverá a pedir mientras no sea correcto.
            
            El tercero tendrá que  ser un número entre 1 y 100 con la condición de que sea mayor que el primero y menor que el segundo; también lo volverá a pedir hasta que sea correcto. 
                
            Una  vez  que  tengamos  los  tres  números,  nos  escribirá  por  pantalla  los  números comprendidos entre el primero y el tercero y en otra línea los números comprendidos entre el tercero y el segundo. Mejor con un ejemplo: 
            
            Los tres números son 5, 12 y 7. Nos tendrá que escribir:
                5 6 7 
                7 8 9 10 11 12
            */
            EscribeSerieNumeros3();
        }
        static void EscribeSerieNumeros3 ()
        {
            int first, second, third;

            first = Prompt(1, 100);
            second = Prompt(first, 100);
            third = Prompt(first, second);

            PrintRange(first, third);
            PrintRange(third, second);
            
        }
        static void PrintRange (int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static int Prompt (int min, int max)
        {
            int number;

            Console.Write($"Introduce un número (Entre {min} y {max}): ");
            number = int.Parse(Console.ReadLine());

            while (number < min || number > max)
            {
                Console.Write($"El número ingresaso no está entre {min} y {max}. Vuelve a intentarlo: ");
                number = int.Parse(Console.ReadLine());
            }

            return number;
        }
    }
}
