using System;

namespace CmToFeetsAndInches
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isparsable;
            double centimeters;
            double allInches;
            int feets;
            double inches;

            double centimetersToInches = 2.54;
            int inchesToFeets = 12;
            
            Console.WriteLine("Introduzca un número en cm. Use coma decimal.");

            input = Console.ReadLine();

            isparsable = Double.TryParse(input, out centimeters);

            if (isparsable)
            {
                allInches = centimeters / centimetersToInches;

                feets = Convert.ToInt32(Math.Floor(allInches / inchesToFeets));

                inches = allInches % inchesToFeets;

                Console.WriteLine($"{centimeters} centímetros en el sistema americano queda como: {feets} pies y {inches} pulgadas.");
            }
            else
                Console.WriteLine("Por favor, introduzca un input válido.");
        }
    }
}
