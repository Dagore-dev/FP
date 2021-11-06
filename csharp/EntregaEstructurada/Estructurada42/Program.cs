using System;

namespace Estructurada42
{
    class Program
    {
        static void Main(string[] args)
        {
            //Juego  del  número  secreto.  El  ordenador  elegirá  un  número  al  azar  entre  1  y  100.  El usuario irá introduciendo números por teclado, y el ordenador le irá dando pistas: "mi número es mayor" o "mi número es menor", hasta que el usuario acierte. Entonces el ordenador le felicitará y le comunicará el número de intentos que necesitó para acertar el número secreto.

            int secretNumber, guessNumber, triesNumber = 0;

            Random random = new Random();
            secretNumber = random.Next(1, 101);

            Console.Write("Introduce un número entero positivo entre 1 y 100: ");
            guessNumber = int.Parse(Console.ReadLine());

            triesNumber++;

            while (guessNumber != secretNumber)
            {
                Console.WriteLine("Lo siento, no has acertado el número.");
                triesNumber++;

                if (guessNumber > secretNumber)
                {
                    Console.Write("El número secreto es más pequeño, prueba de nuevo: ");
                }
                else
                {
                    Console.Write("El número secreto es más grande, prueba de nuevo: ");
                }

                guessNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine($"Efectivamente, el número secreto es {secretNumber} ¡Lo has conseguido en {triesNumber} intentos!");
        }
    }
}
