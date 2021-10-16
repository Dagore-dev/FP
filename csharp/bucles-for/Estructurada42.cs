using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada42()
        {
            
            Console.WriteLine("Juego  del  número  secreto.  El  ordenador  elegirá  un  número  al  azar  entre  1  y  100.  El usuario irá introduciendo números por teclado, y el ordenador le irá dando pistas: \"mi número es mayor\" o \"mi número es menor\", hasta que el usuario acierte. Entonces el ordenador le felicitará y le comunicará el número de intentos que necesitó para acertar el número secreto.");
            Console.WriteLine();

            int secretNumber, guessNumber, triesNumber = 0;

            Random random = new Random();
            secretNumber = random.Next();

            Console.Write("Introduce un número entero positivo: ");
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

            Console.WriteLine($"Efectivamente, el número secreto es {secretNumber} ¡Lo has conseguido en {triesNumber} intentos!");

            Console.WriteLine();
        }
    }
}