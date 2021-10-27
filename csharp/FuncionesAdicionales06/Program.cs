using System;

namespace FuncionesAdicionales06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe la función rombo que te escribe un rombo en pantalla a base de asteriscos (la pirámide del ejercicio 6 sería la cuarta parte del rombo). Opcional: Hacerlo con el número de bucles más pequeño posible (se puede hacer sin bucles incluso).
            
            Ej.: Para un valor 4
               **
              ****
             ******
            ********
             ******
              ****
               ** 
            */
            Rombo(TriangleSize());
            Rombo(TriangleSize());
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
        static void TrianguloEstrellitas(int number)
        {
            string acc = "";

            for (int i = 0; i < number; i++)
            {
                acc += "*";
                Console.WriteLine(acc);
            }
        }
        static void Rombo (int number)
        {

        }
    }
}
