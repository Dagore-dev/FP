using System;

namespace Mitad
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //double mitad;

            //Console.WriteLine("Dime un numero");
            //n = int.Parse(Console.ReadLine()); //da error por el int. de esta linea

            //mitad = n / 2;

            //Console.WriteLine("ls mitsd es " + mitad);

            //-------------------------------------------
            // OPERADORES
            //------------------------------------------

            //suma
            int suma = 3 + 5;

            //Resta 

            int resta = 3 - 5;

            //Multiplicacion

            int multi = 3 * 5;

            //Division

            int division = 3 / 5;
            Console.WriteLine(division);

            double division2 = 3 / 5;
            Console.WriteLine(division2);

            double division3 = 3.0 / 5.0;
            Console.WriteLine(division3);

            double division4 = 3.0 / 5;
            Console.WriteLine(division4);

            //resto

            int division5 = 17 / 5;
            int resto5 = 17 % 5;

            Console.WriteLine("17 entre 5 sale a " + division5 + "y resto" + resto5);

            int expresion = 3 + 4 * 5 / 2 * 9; // mul primero, div segun y el resto.

            int expresion2 = 4 * 3 / 2;// como no se asegura el orden correcto de la operacion, se pone el parentesis en la multiplicacion.





        }
    }
}
