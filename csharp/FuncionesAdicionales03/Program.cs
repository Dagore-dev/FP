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
            double remaining = money;
            int two = 0, one = 0, fifty = 0, twenty = 0, ten = 0, five = 0, twoCents = 0, oneCent = 0;


            while (remaining > 0)
            {
                if(remaining > 2)
                {
                    two++;
                    remaining -= 2;
                }
                else if (remaining > 1)
                {
                    one++;
                    remaining -= 1;
                }
                else if (remaining > 1/2)
                {
                    fifty++;
                    remaining -= 1 / 2;
                }
                else if (remaining > 1 / 5)
                {
                    twenty++;
                    remaining -= 1 / 5;
                }
                else if (remaining > 1 / 10)
                {
                    ten++;
                    remaining -= 1 / 10;
                }
                else if (remaining > 1 / 20)
                {
                    five++;
                    remaining -= 1 / 20;
                }
                else if (remaining > 1 / 50)
                {
                    twoCents++;
                    remaining -= 1 / 50;
                }
                else if (remaining < 1 / 100)
                {
                    oneCent++;
                    remaining -= 1 / 100;
                }
            }

            Console.WriteLine($"Utilizo {two} monedas de 2 euros, {one} monedas de 1 euro, {fifty} monedas de 0.50 euros, {twenty} monedas de 0.20 euros, {ten} monedas de 0.10 euros, {five} monedas de 0.05 euros, {twoCents} monedas de 0.02 euros y {oneCent} monedas de 0.01 euros.");

        }
    }
}
