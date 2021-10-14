using System;

namespace InputProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROPUESTA DE DAVID CON TRYPARSE
            /*
            Console.WriteLine("Dame un número");
            
            string input = Console.ReadLine();

            int number;

            bool isParsable = Int32.TryParse(input, out number);//Intenta transformar el input a número, devulve true y lo mete en la variable que le digas o, si no puede, devuelve false.


            if(isParsable)
                Console.WriteLine(number * 2);
            else
                Console.WriteLine("Escribe un puto número, cabrón.");
            */

            //Ctrl + k + c para comentar bloques de código y Ctrl + k + u para descomentarlo.
            //LEER ENTEROS

            //int edad;

            //Console.WriteLine("¿Cuántos años tienes");

            //edad = int.Parse(Console.ReadLine());//int.Parse() transforma un string a tipo int. Pero no verifica que sea un número.

            //Console.WriteLine($"Tienes {edad} años.");

            //LEER REALES

            //double euros;//Ctrl + r + r para renombrar una variable allá donde aparezca.

            //Console.WriteLine("Cúanto cuesta el café?");

            //euros = double.Parse(Console.ReadLine());//Por la configucarión regional hay que emplear coma en lugar de punto pa meter el número por consola.

            //Console.WriteLine($"El café cuesta {euros}");

            //LEER CARACTERES

            char letra;
            Console.WriteLine("Escribe una letra.");
            letra = Console.ReadLine()[0];//Pilla solo la primera
            Console.WriteLine(letra);
        }
    }
}
