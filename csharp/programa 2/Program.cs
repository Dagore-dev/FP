using System;

namespace programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, suma; //manera de abreviar varias variables del mismo tipo en una linea.
            Console.WriteLine("Dime el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            suma = n1 + n2;

            Console.WriteLine("La suma es " + suma);
        }
    }
}
