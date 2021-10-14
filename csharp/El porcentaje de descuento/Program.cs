using System;

namespace El_porcentaje_de_descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, descuento, cantidad, preciofinal;

            Console.WriteLine("cuales es el precio");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("cuales es el descuento");
            descuento = double.Parse(Console.ReadLine());

            cantidad = (precio * descuento) / 100.0;

            preciofinal = precio - cantidad;

            Console.WriteLine("el precio final es " + preciofinal + " el descuento es de " + cantidad);








        }
    }
}
