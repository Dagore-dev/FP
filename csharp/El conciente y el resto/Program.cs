using System;

namespace El_conciente_y_el_resto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, conciente, resto;

            Console.WriteLine("Dime numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("... Dividido entre");
            n2 = int.Parse(Console.ReadLine());

            conciente = n1 / n2;
            resto = n1 % n2;

            Console.WriteLine("El conciente " + conciente + " y el resto" + resto);
        }
    }
}
