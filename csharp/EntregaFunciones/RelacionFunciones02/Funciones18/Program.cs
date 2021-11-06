using System;

namespace Funciones18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “ResolucionCamara” a la que le pasas el número de MegaPixels que tiene una cámara digital(puede ser un double) y nos dice cuál es la resolución máxima de las fotos que hace la cámara. Los valores los devolverá en dos parámetros de tipo out (x, y).
            
            double megapixel;
            int x, y;

            Console.Write("Introduce los megapíxeles: ");
            megapixel = double.Parse(Console.ReadLine());

            ResolucionCamara(megapixel, out x, out y);

            Console.WriteLine($"La resolución es de {x} x {y}");
        }
        static void ResolucionCamara(double megapixel, out int x, out int y)
        {
            double pixels = megapixel * 1000000.0, aspectRatio = 16.0 / 9.0;

            double innerSqrt = pixels / aspectRatio;

            y = (int)Math.Sqrt(innerSqrt);

            x = (int)(pixels / y);
        }
    }
}
