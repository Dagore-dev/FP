using System;

namespace FuncionesAdicionales18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumaNumeros(5));
        }
        static int SumaNumeros (int limit)
        {
            /*
            Escribe la función SumaNumeros a la que le pasamos un entero con la cantidad de números que queremos sumar y nos los va pidiendo dentro de la función (con Console.ReadLine) para finalmente devolvernos la suma. La función sólo sumará los números que sean positivos. Los negativos los ignorará por completo (no contarán para la cantidad ni se añaden a la suma).
            Ej.: SumaNumeros(4) nos pedirá cuatro números.
            Si escribimos: 1, -3, 4, 5, -2, 7 nos devolverá 17 (el -3 y el -2 no los suma y además los vuelve a pedir porque no son positivos). 
            */
            int result = 0, current;

            Console.WriteLine("Introduce a continuación los números que quieres sumar, pulsa intro después de cada número:");

            for (int i = 0; i < limit; i++)
            {
                current = int.Parse(Console.ReadLine());

                if (current >= 0)
                {
                    result += current;
                }
                else
                {
                    Console.WriteLine("No has introducido un número válido, vuelve a ingresarlo.");
                    i--;
                }
            }

            return result;
        }
    }
}
