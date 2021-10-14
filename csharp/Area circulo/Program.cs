using System;

namespace Area_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
           double radio , area;
            Console.WriteLine("dime el radio");
            radio = double.Parse(Console.ReadLine());

            area = Math.PI * (radio * radio);//Math.PI es la manera de poner pi mas exacto

            Console.WriteLine("El area es " + area);
        }
    }
}
