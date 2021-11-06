using System;

namespace FuncionesAdicionales03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe la función calderilla a la que le pasamos una cantidad de dinero (menor de 5€, puede tener decimales) y nos muestra por pantalla qué monedas debemos usar para dar el cambio(con el menor número posible de monedas).

            Calderilla(4.05);
            Calderilla(3.25);
        }
        
        static void Calderilla (double money)
        {
            //Monedas de 2 euros, 1 euro, 0.50 euros, 0.20 euros, 0.10 euros, 0.05 euros, 0.02 euros, 0.01 euros
            int  remaining = (int) (money * 100);
            int two = 0, one = 0, fifty = 0, twenty = 0, ten = 0, five = 0, twoCents = 0, oneCent = 0;

            Console.WriteLine($"Para devolver {money} emplearía: ");

            while (remaining > 0)
            {
                if(remaining >= 200)
                {
                    two++;
                    remaining -= 200;
                }
                else if (remaining >= 100)
                {
                    one++;
                    remaining -= 100;
                }
                else if (remaining >= 50)
                {
                    fifty++;
                    remaining -= 50;
                }
                else if (remaining >= 20)
                {
                    twenty++;
                    remaining -= 20;
                }
                else if (remaining >= 10)
                {
                    ten++;
                    remaining -= 10;
                }
                else if (remaining >= 5)
                {
                    five++;
                    remaining -= 5;
                }
                else if (remaining >= 2)
                {
                    twoCents++;
                    remaining -= 2;
                }
                else
                {
                    oneCent++;
                    remaining -= 1;
                }
            }

            Console.WriteLine($"{two} monedas de 2 euros");
            Console.WriteLine($"{one} monedas de 1 euro");
            Console.WriteLine($"{fifty} monedas de 0.50 euros");
            Console.WriteLine($"{twenty} monedas de 0.20 euros");
            Console.WriteLine($"{ten} monedas de 0.10 euros");
            Console.WriteLine($"{five} monedas de 0.05 euros");
            Console.WriteLine($"{twoCents} monedas de 0.02 euros");
            Console.WriteLine($"{oneCent} monedas de 0.01 euros.");

            Console.WriteLine();
        }
    }
}
