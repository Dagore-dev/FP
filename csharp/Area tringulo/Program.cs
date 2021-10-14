using System;

namespace Area_tringulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1, altura, area;

            Console.WriteLine("dime la base");
            base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("dime la altura");
            altura = double.Parse(Console.ReadLine());

            area = (base1 * altura) / 2;

            Console.WriteLine("area es " + area);

        }
    }
}
