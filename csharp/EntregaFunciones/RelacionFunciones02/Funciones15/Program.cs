using System;

namespace Funciones15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “LeeNumero” a la que le pasas dos parámetros (a y b) y nos lee del teclado un número comprendido entre a y b(ambos incluidos). Si el número no es correcto, te vuelve a pedir que lo introduzcas.
        }
        static int LeeNumero (int a, int b)
        {
            int number, min, max;

            min = a < b ? a : b;
            max = a < b ? b : a;

            Console.Write($"Escribe un número entre {min} y {max}: ");
            number = int.Parse(Console.ReadLine());

            while (number < min || number > max)
            {
                Console.WriteLine("El número introducido no está en el rango.");
                Console.Write($"Introduce de nuevo un número entre {min} y {max}: ");
                number = int.Parse(Console.ReadLine());
            }

            return number;
        }
    }
}
