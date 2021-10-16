using System;

namespace bucles_for
{
    partial class Program
    {
        private static void Estructurada37()
        {
            Console.WriteLine("Escribe un programa que nos presente un menú con 3 opciones. Eligiendo la opción “a” nos escribirá todos los múltiplos de 11 comprendidos entre 1 y 100. Eligiendo la opción “b” lo mismo, pero con los múltiplos de 17.Eligiendo la opción “c” lo mismo, pero con los múltiplos de 23.");
            Console.WriteLine();

            string option;
            int num = 0;

            Console.WriteLine("Opción a: Todos los múltiplos de 11 entre 1 y 100.");
            Console.WriteLine("Opción b: Todos los múltiplos de 17 entre 1 y 100.");
            Console.WriteLine("Opción c: Todos los múltiplos de 23 entre 1 y 100.");

            Console.Write("Introduce tu opción: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "a":
                    num = 11;
                    break;
                case "b":
                    num = 17;
                    break;
                case "c":
                    num = 23;
                    break;
                default:
                    Console.WriteLine("No has introducido una de las opciones");
                    break;
            }

            if (num > 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i % num == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}