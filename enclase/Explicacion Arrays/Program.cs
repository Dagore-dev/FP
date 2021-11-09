using System;

namespace Explicacion_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];//Array de int con 5 posiciones. En C# la inicialización del array va con todo ceros.

            int[] othersNumbers = { 1, 2, 3, 4, 5 };//Inicializado con otros valores de manera literal.

            Console.WriteLine(numbers[3]);//Escribe 0 en pantalla, el valor en la posición tres del array numbers.
            
            foreach (int number in othersNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)//Rellenando un array siguiendo una progresión.
            {
                numbers[i] = i * 2;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
