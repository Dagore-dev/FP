using System;

namespace Funciones18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “resolucionCamara” a la que le pasas el número de MegaPixels que tiene una cámara digital(puede ser un double) y nos dice cuál es la resolución máxima de las fotos que hace la cámara.Como no podemos devolver dos valores(la altura y la anchura de la imagen), los escribiremos por pantalla.

            double megapixel, x, y;

            Console.Write("Introduce los megapíxeles: ");
            megapixel = double.Parse(Console.ReadLine());

            ResolucionCamara(megapixel, out x, out y);
            
            Console.WriteLine($"La resolución es de {x} x {y}");
        }
        static void ResolucionCamara(double megapixel, out double x, out double y)
        {
            //x * y = pixeles -> x = pixeles / y
            //x / y = 16 / 9 -> x = (16/9) * y
            //pixeles / y = (16/9) * y
            //y^2 = pixeles / (16/9)

            double pixels = megapixel * 1000000.0;
            double aspectRatio = 16.0 / 9.0;
            
            double innerSqrt = pixels / aspectRatio;
            
            y = Math.Floor(Math.Sqrt(innerSqrt));

            x = Math.Floor(pixels / y);
        }
    }
}
