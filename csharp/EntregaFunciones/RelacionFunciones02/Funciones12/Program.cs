using System;

namespace Funciones12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “PulgadasACentimetros” a la que le pases un valor en pulgadas (de tipo double) y te devuelva el valor en centímetros.Haz también la función “CentimetrosAPulgadas”. 
        }
        static double PulgadasACentimetros (double inches)
        {
            return inches * 2.54;
        }
        static double CentimetrosAPulgadas (double centimeters)
        {
            return centimeters / 2.54;
        }
    }
}
