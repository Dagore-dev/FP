using System;

namespace Estructurada08Luis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el primer entero.");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo entero.");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dime el tercer entero.");
            int c = Int32.Parse(Console.ReadLine());

            int menor, medio, mayor;

            if (a <= b && b <= c)
            {
                menor = a; medio = b; mayor = c;
            }
            else if (a <= c && c <= b){
                menor = a; medio = c; mayor = b;
            }
            else if (b <= a && a <= c){
                menor = b; medio = a; mayor = c;
            }
            else if (b <= c && c <= a)
            {
                menor = b; medio = c; mayor = a;
            }
            else if (c <= a && a <= b){
                menor = c; medio = a; mayor = b;
            }
            else
            {
                menor = c; medio = b; mayor = a;
            }

            Console.WriteLine($"El menor es {menor}, el medio es {medio} y el mayor es {mayor}.");
        }
    }
}
