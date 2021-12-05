using System;

namespace FuncionesAdicionales19
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgresionAritmetica(1, 3);
            Console.WriteLine();
            ProgresionAritmetica(4, 9);
            Console.WriteLine();
            ProgresionAritmetica(20, 18);
            Console.WriteLine();
        }
        static void ProgresionAritmetica (int num1, int num2)
        {
            /*
            Escribe la función ProgresionAritmetica a la que le pasamos dos enteros y nos escribirá por pantalla (con Console.WriteLine) los 10 primeros números de la progresión aritmética que empieza los dos que le hemos pasado.
            Ej.:
                Si nos pasan: 1 y 3, escribiría: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19
                Si nos pasan: 4 y 9, escribiría: 4, 9, 14, 19, 24, 29, 34, 39, 44, 49
                Si nos pasan: 20 y 18, escribiría: 20, 18, 16, 14, 12, 10, 8, 6, 4, 2 
            */
            int number = num2, progression = num2 - num1;

            Console.Write($"{num1}, {num2}, ");

            for (int i = 0; i < 7; i++)
            {
                number += progression;
                Console.Write(number + ", ");
            }

            number += progression;
            Console.Write(number);
        }
    }
}
