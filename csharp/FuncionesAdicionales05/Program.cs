using System;

namespace FuncionesAdicionales05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe la función trianguloEstrellitas. La función te pedirá un número que deberá ser como mínimo el número 3 y como máximo el 20. Si el número no es correcto, escribirá “ERROR”. La función escribirá por pantalla una pirámide a base de estrellitas como la del ejemplo. La función deberá funcionar para cualquier número entre 3 y 20 (o sea, nada de escribir las estrellitas a mano).

            Ej.: Tamaño = 4
            *
            **
            ***
            **** 
            */

            TrianguloEstrellitas(TriangleSize());
            TrianguloEstrellitas(TriangleSize());
            TrianguloEstrellitas(TriangleSize());
        }

        static int TriangleSize ()
        {
            int number;

            Console.Write("Introduce un número natural igual o mayor que 3: ");
            number = int.Parse(Console.ReadLine());

            if (number < 3)
            {
                Console.WriteLine("ERROR");
                number = 0;
            }

            return number;
        }
        static void TrianguloEstrellitas (int number)
        {
            string acc = "";

            for (int i = 0; i < number; i++)
            {
                acc += "*";
                Console.WriteLine(acc);
            }
        }
    }
}
