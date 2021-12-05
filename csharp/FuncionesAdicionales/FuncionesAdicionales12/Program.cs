using System;

namespace FuncionesAdicionales12
{
    class Program
    {
        static void Main(string[] args)
        {
            Romboide(5, 7);

            Console.WriteLine();

            Romboide(3, 10);
        }
        static void Romboide  (int rows, int n)
        {
            /*
            Escribe la función Romboide, que nos pintará un romboide con asteriscos. Habrá que pasarle dos parámetros: la altura y la longitud. La longitud será el número de asteriscos que hay en cada piso y la altura el número de pisos que tendrá.
            Ej.:
            Romboide(5, 7) nos pintará:
            
                 *******
                *******
               *******
              *******
             *******
            
            Romboide(3, 10) nos pintará:

               **********
              **********
             **********
            */

            string symbols = new string('*', n);

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string(' ', rows - i) + symbols);
            }
        }
    }
}
