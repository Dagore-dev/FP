using System;

namespace Volumen_Toro
{
    class Program
    {
        static void Main(string[] args)
        {
            double Rp, Rg, volumen;// cuando las variables son de dos palabras, la segunda lainicial en mayuscula

            Console.WriteLine("Dime el radio pequeño");
            Rp = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime el radio grande");
            Rg = double.Parse(Console.ReadLine());

            volumen = ((Math.PI * Math.PI) * 2) * (Rg * (Rp * Rp));
            // otra forma volumen = (Math.PI * radioMenor * radioMenor) * (2 * Math.PI * radioMayor);

            Console.WriteLine("El volumen del toro es " + volumen);
        }
    }
}
