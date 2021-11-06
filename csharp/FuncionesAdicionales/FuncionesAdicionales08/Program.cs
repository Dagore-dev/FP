using System;

namespace FuncionesAdicionales08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe la función CuadradoEstrellitas que te pinta un cuadrado realizado con estrellitas.El tamaño máximo será 20.Si escribes más de 20 o menos de 1, dará un mensaje de error en lugar de pintar el cuadrado.
            CuadradoEstrellitas();
        }
        static void CuadradoEstrellitas ()
        {
            int size;
            size = Promp();

            for (int i = 0; i < size; i++)
            {
                if (i == 0 || i == (size -1))
                {
                    Console.Write(new string('*', size));
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string(' ', size - 2));
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        static int Promp ()
        {
            int size;

            Console.Write("Escribo un cuadrado con estrellitas del tamaño que me digas, dime un tamaño entre 1 y 20: ");
            size = int.Parse(Console.ReadLine());

            if(size < 1 || size > 20)
            {
                Console.WriteLine("El tamaño indroducido no está en el rango.");
                size = 0;
            }
            else
            {
                Console.WriteLine($"Tamaño = {size}");
            }

            return size;
        }
    }
}
