using System;

namespace FuncionesAdicionales06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe la función rombo que te escribe un rombo en pantalla a base de asteriscos. Opcional: Hacerlo con el número de bucles más pequeño posible (se puede hacer sin bucles incluso).
            
            Ej.: Para un valor 4
               **
              ****
             ******
            ********
             ******
              ****
               **
            
            Solución: https://www.youtube.com/watch?v=UqQFpM_cgbY
            */
            Rombo(TriangleSize());

        }
        static int TriangleSize()
        {
            int number;

            Console.Write("Introduce un número natural: ");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("ERROR");
                number = 0;
            }

            return number;
        }
        static void Rombo (int number)
        {
            /*
                1. Damos un número de vueltas igual number.
                2. En cada vuelta tenemos 2 asteriscos más.
                3. Los espacios en blanco disminuyen en cada vuelta.
                4. number - 1 - vuelta = número de espacios en blanco.
            */
            int numberOfRows = number - 1;
            
            for (int row = 0; row < number; row++)
            {
                Console.Write(new String(' ', numberOfRows - row));
                
                Console.Write("**");
                
                for (int col = 0; col < row; col++)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }

            for (int row = number - 2; row >= 0; row--)//-2 en lugar de numberOfRows para excluir del bucle la línea central del rombo.
            {
                Console.Write(new String(' ', numberOfRows - row));

                Console.Write("**");

                for (int col = 0; col < row; col++)
                {
                    Console.Write("**");
                }

                Console.WriteLine();
            }
        }
    }
}
