using System;

namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1, altura, perimetro;

            Console.WriteLine("base");
            base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("altura");
            altura = double.Parse(Console.ReadLine());

            perimetro = base1 + base1 + altura + altura;

            Console.WriteLine("el perimetro es " + perimetro);


        }
    }
}
