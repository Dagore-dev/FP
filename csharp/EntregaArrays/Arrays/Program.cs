using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Puedes modificar directamente el contenido del array con la función sin usar parámetros por referencia. Lo que te llega por el array son las direcciones de memoria donde se encuentra el contenido.
            int option;

            WriteMenu();

            option = int.Parse(Console.ReadLine());

            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        {
                            int[] a = { 23, 43, 1, -3, 6 };
                            EscribeArrays5(a);
                        }
                        break;
                    case 2:
                        {
                            int[] a = { 23, 43, 1, -3, 6, 23, 43, 1, -3, 6 };
                            EscribeArrays(a);
                        }
                        break;
                    case 3:
                        {
                            int[] a = new int[5];
                            LeeArray5(a);
                            EscribeArrays5(a);
                        }
                        break;
                    case 4:
                        {
                            int[] a = new int[3];
                            LeeArray(a);
                            EscribeArrays(a);
                        }
                        break;
                    case 5:
                        {
                            int[] a = { 23, 43, 1, -3, 6 };
                            PonCeros5(a);
                            EscribeArrays(a);
                        }
                        break;
                    case 6:
                        {
                            int[] a = { 1, 2, 3 };
                            PonCeros(a);
                            EscribeArrays(a);
                        }
                        break;
                    case 7:
                        {
                            int[] a = { 0, 1, 2, 3, 4 };
                            EscribeArrays(a);
                            Console.WriteLine("Suman en total: " + SumaArray5(a));
                        }
                        break;
                    case 8:
                        {
                            int[] a = { 0, 1, 2, 3 };
                            EscribeArrays(a);
                            Console.WriteLine("Suman en total: " + SumaArray(a));
                        }
                        break;
                    case 9:
                        {
                            int[] a = { 0, 1, 2, 3, 4 };
                            EscribeArrays(a);
                            Console.WriteLine("La media es igual a " + MediaArray5(a));
                            int[] b = { 3, 1, 2, 3, 7 };
                            EscribeArrays(b);
                            Console.WriteLine("La media es igual a " + MediaArray5(b));
                        }
                        break;
                    case 10:
                        {
                            int[] a = { 0, 1, 2, 3, 4, 0, 1, 2, 3, 4 };
                            EscribeArrays(a);
                            Console.WriteLine("La media es igual a " + MediaArray(a));
                            int[] b = { 3, 1, 2, 3, 7, 3, 1, 2, 3, 7 };
                            EscribeArrays(b);
                            Console.WriteLine("La media es igual a " + MediaArray(b));
                        }
                        break;
                    case 11:
                        {
                            int[] a = new int[5];
                            EscribeArrays(a);
                            RellenaEnOrden(a);
                            EscribeArrays(a);
                        }
                        break;
                    case 12:
                        {
                            int[] a = new int[5];
                            EscribeArrays(a);
                            RellenaEnOrdenDescendente(a);
                            EscribeArrays(a);
                        }
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }

                WriteMenu();
                option = int.Parse(Console.ReadLine());
            }
        }
        static void WriteMenu ()
        {
            Console.WriteLine();
            Console.WriteLine("Menú");
            Console.WriteLine();
            Console.WriteLine("1 - EscribeArray5");
            Console.WriteLine("2 - EscribeArray");
            Console.WriteLine("3 - LeeArray5");
            Console.WriteLine("4 - LeeArray");
            Console.WriteLine("5 - PonCeros5");
            Console.WriteLine("6 - PonCeros");
            Console.WriteLine("7 - SumaArray5");
            Console.WriteLine("8 - SumaArray");
            Console.WriteLine("9 - MediaArray5");
            Console.WriteLine("10 - MediaArray");
            Console.WriteLine("11 - RellenaEnOrden");
            Console.WriteLine("12 - RellenaEnOrdenDescendente");
            Console.WriteLine("0 - Salir");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
        }
        static void EscribeArrays5 (int[] a)
        {
            //Escribe una función “EscribeArray5” a la que le pasamos un array de tipo entero decinco elementos y lo escribe por pantalla de la siguiente forma:[23, 43, 1, -3, 6]

            string result = "[";

            for (int i = 0; i < 4; i++)
            {
                result += a[i] + ", ";
            }

            result += $"{a[4]}]";

            Console.WriteLine(result);
        }
        static void EscribeArrays (int[] a)
        {
            //Escribe una función “EscribeArray” a la que le pasamos un array de enteros del tamaño que sea y lo escribe por pantalla de la misma forma.Tendremos que usar la propiedad “Length” para saber el tamaño del array desde dentro de la función.

            string result = "[";

            for (int i = 0; i < a.Length - 1; i++)
            {
                result += a[i] + ", ";
            }

            result += $"{a[a.Length - 1]}]";

            Console.WriteLine(result);
        }
        static void LeeArray5 (int[] a)
        {
            //Escribe una función “LeeArray5” que lea un array de enteros de 5 elementos. Habrá que pasarle el array ya definido y él lo rellenará pidiéndole los valores al usuario por consola.
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Dime la posición {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void LeeArray (int[] a)
        {
            //Escribe una función “LeeArray” que lea un array de enteros de cualquier tamaño. El array lo crearemos fuera de la función y dentro de la función usaremos la propiedad “Length” para saber cuál es el tamaño y cuántos datos debemos leer.

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Dime la posición {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void PonCeros5 (int[] a)
        {
            //Escribe una función “PonCeros5” que modifique el contenido de un array de enteros de cinco elementos y ponga en todas las posiciones un 0.
            for (int i = 0; i < 5; i++)
            {
                a[i] = 0;
            }
        }
        static void PonCeros (int[] a)
        {
            //Escribe una función “PonCero” que haga lo mismo para un array de enteros de cualquier tamaño.
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }
        static int SumaArray5 (int[] a)
        {
            //Escribe una función “SumaArray5” que sume todas las posiciones de un array de enteros de cinco elementos y nos devuelva el resultado.
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += a[i];
            }

            return sum;
        }
        static int SumaArray (int[] a)
        {
            //Escriba una función “SumaArray” que haga lo mismo para un array de enteros de cualquier tamaño.

            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }
        static double MediaArray5 (int[] a)
        {
            //Escribe una función “MediaArray5” que nos calcule el valor medio de los elementos de un array de enteros de tamaño 5.

            double mean;
            int sum = SumaArray(a);

            mean = sum / 5.0;

            return mean;
        }
        static double MediaArray (int[] a)
        {
            //Escribe una función “MediaArray” que haga lo mismo para un array de enteros de cualquier tamaño.

            double mean;
            int sum = SumaArray(a);

            mean = sum / (double) a.Length;

            return mean;
        }
        static void RellenaEnOrden (int[] a)
        {
            //. Escribe una función “RellenaEnOrden” que nos rellena un array de enteros con los números desde el 1 en adelante(1, 2, 3, 4... hasta el tamaño del array).
            
            for (int i = 1; i <= a.Length - 1; i++)
            {
                a[i] = i;
            }
        }
        static void RellenaEnOrdenDescendente (int[] a)
        {
            //Escribe una función “RellenaEnOrdenDesc” que nos rellena un array con los valores siguientes: tamaño del array, tamaño del array - 1, etc., 3, 2, 1.


        }
    }
}
