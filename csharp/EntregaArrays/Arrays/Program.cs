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
                    case 13:
                        {
                            int[] a = new int[25];
                            EscribeArrays(a);
                            RellenaAleatorio(a);
                            EscribeArrays(a);
                        }
                        break;                    
                    case 14:
                        {
                            int[] a = { 0, 1, 2, 3, 4, 5 };
                            EscribeArrays(a);
                            Console.WriteLine(EstarOrdenado(a));

                            Console.WriteLine();

                            int[] b = { 5, 4, 3, 2, 1, 0 };
                            EscribeArrays(b);
                            Console.WriteLine(EstarOrdenado(b));
                        }
                        break;
                    case 15:
                        {
                            int[] a = { 0, 1, 2, 3, 4, 5 };
                            EscribeArrays(a);
                            Console.WriteLine(NumeroImpares(a));
                        }
                        break;
                    case 16:
                        {
                            int[] a = { 1, 2, 0, 3, 4, 5 };
                            EscribeArrays(a);
                            Console.WriteLine(MinArray(a));
                        }
                        break;
                    case 17:
                        {
                            int[] a = { 1, 2, 5, 3, 4, 0 };
                            EscribeArrays(a);
                            Console.WriteLine(MaxArray(a));
                        }
                        break;
                    case 18:
                        {
                            double[] a = { 2.5, 4.5, 3, 10, 8 };
                            EscribeArraysDouble(a);
                            Console.WriteLine(NumeroAprobados(a));
                        }
                        break;
                    case 19:
                        {
                            int[] a = { 1, 2, 5, 3, 4, 0 };
                            int limit = 3;
                            EscribeArrays(a);
                            Console.WriteLine($"Hay {PorEncimaDe(a, limit)} números, iguales o superiores a {limit}.");
                        }
                        break;
                    case 20:
                        {
                            int[] a = { 1, 2, 5, 0, 4, 0 };
                            EscribeArrays(a);
                            Console.WriteLine(Cuantosceros(a));
                        }
                        break;
                    case 21:
                        {
                            int[] a = { 1, 2, 5, 0, 4, 0 };
                            EscribeArrays(a);
                            int[] b = new int[6];
                            CopiaArray(a, b);
                            EscribeArrays(b);
                        }
                        break;
                    case 22:
                        {
                            int[] a = { 1, 2, 5, 0, 4, 0 };
                            EscribeArrays(a);
                            int[] b = new int[6];
                            CopiaArrayInvertido(a, b);
                            EscribeArrays(b);
                        }
                        break;
                    case 23:
                        {
                            int[] a  = { 1, 2, 3 };
                            int[] b = { 8, 6, 8 };
                            int[] c = new int[3];
                            
                            EscribeArrays(a);
                            EscribeArrays(b);
                            
                            SumArrays(a, b, c);

                            EscribeArrays(c);
                        }
                        break;
                    case 24:
                        {
                            int[] a = { 1, 2, 3 };
                            int[] b = { 8, 6, 8 };
                            int[] c = new int[3];
                            double[] d = new double[3];

                            Console.WriteLine("Operaciones con estos dos arrays:");
                            EscribeArrays(a);
                            EscribeArrays(b);

                            Console.WriteLine("RestaArrays:");
                            RestaArrays(a, b, c);
                            EscribeArrays(c);

                            Console.WriteLine("MultiplicaArrays:");
                            MultiplicaArrays(a, b, c);
                            EscribeArrays(c);

                            
                            Console.WriteLine("DivideArrays:");
                            DivideArrays(a, b, d);
                            EscribeArraysDouble(d);
                        }
                        break;
                    case 25:
                        {
                            int[] a = { 1, 2, 3, 4, 5 };
                            EscribeArrays(a);

                            InvierteArray(a);
                            EscribeArrays(a);
                        }
                        break;
                    case 26:
                        {
                            int[] a = { 1, 2, 3 };
                            int[] b = { 3, 2, 1 };
                            int[] c = { 1, 1, 1 };
                            int[] d = { 1, 1, 1 };

                            EscribeArrays(a);
                            EscribeArrays(b);
                            Console.WriteLine(ComparaArrays(a,b));

                            EscribeArrays(c);
                            EscribeArrays(d);
                            Console.WriteLine(ComparaArrays(c, d));
                        }
                        break;
                    case 27:
                        {
                            double[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                            bool[] b = new bool[10];

                            EscribeArraysDouble(a);
                            PonNotasArray(a, b);
                            EscribeArraysBool(b);
                        }
                        break;
                    case 28:
                        {
                            int[] a = { 1, 2, 3, 4, 5 };
                            int[] b = { 6, 7, 8, 9, 10 };
                            int[] c = new int[10];

                            EscribeArrays(a);
                            EscribeArrays(b);

                            ConcatenaArrays55(a, b, c);
                            EscribeArrays(c);
                        }
                        break;
                    case 29:
                        {
                            int[] a = { 1, 2, 3 };
                            int[] b = { 4, 5, 6 };
                            int[] c = new int[6];

                            EscribeArrays(a);
                            EscribeArrays(b);

                            ConcatenaArrays(a, b, c);
                            EscribeArrays(c);
                        }
                        break;
                    case 30:
                        {
                            int[] a = { 1, 2, 3, 4, 5 };
                            int num1 = 3, num2 = 7;

                            EscribeArrays(a);

                            Console.WriteLine($"Para {num1} devuelve {Contiene(a, num1)} y para {num2} devuelve {Contiene(a, num2)}");
                        }
                        break;
                    case 31:
                        {
                            int[] a = { 1, 2, 3 };
                            int[] b = { 4, 5, 6, 7, 8 };
                            int[] c;
                            
                            EscribeArrays(a);
                            EscribeArrays(b);

                            c = ConcatenaArraysPro(a, b);

                            EscribeArrays(c);
                        }
                        break;
                    case 32:
                        {
                            int[] a = { 1, 2, 3 };
                            int[] b;
                            
                            b = CopiaArrayPro(a);

                            EscribeArrays(b);
                        }
                        break;
                    case 33:
                        {
                            int[] a = { 1, 2, 4, 5 };
                            int number = 3;
                            int position = 2;
                            int[] b = new int[0];
                            int num2 = 1;
                            int position2 = 0;

                            EscribeArrays(a);
                            InsertaEnArray(ref a, number, position);
                            EscribeArrays(a);

                            EscribeArrays(b);
                            InsertaEnArray(ref b, num2, position2);
                            EscribeArrays(b);
                        }
                        break;
                    case 34:
                        {
                            int[] a = { 0, 1, 3, 2 };

                            EscribeArrays(a);
                            BorraDeArray(ref a, 2);
                            EscribeArrays(a);
                        }
                        break;
                    case 35:
                        {
                            int[] a = { 0, 1, 2, 3 };
                            int number = 2;

                            EscribeArrays(a);
                            Console.WriteLine("Eliminamos el 2");
                            Elimina1ElementoArray(ref a, number);
                            EscribeArrays(a);
                        }
                        break;
                    case 36:
                        {
                            int[] a = { 1, 2, 1, 2, 1, 1, 1, 2, 2, 1, 1 };
                            int number = 2;

                            EscribeArrays(a);
                            EliminaElementoArray(ref a, number);
                            EscribeArrays(a);
                        }
                        break;
                    case 37:
                        {
                            int[] a = { 1, 2, 6, 7 };
                            int[] b = { 3, 4, 5 };
                            int position = 2;

                            EscribeArrays(a);
                            InsertaArrayEnArray(ref a, position, b);
                            EscribeArrays(a);
                        }
                        break;
                    case 38:
                        {
                            int[] a = { 3, 6, 2, 8, 9 };
                            int start = 1, end = 3;

                            EscribeArrays(a);
                            Console.WriteLine($"Subarray de {start} a {end}");
                            EscribeArrays(SubArray(a, start, end));
                        }
                        break;
                    case 39:
                        {
                            int[] a = { 3, 6, 2, 8, 9 };
                            int start = 1, end = 3;

                            EscribeArrays(a);
                            Console.WriteLine($"Subarray de {start} a {end}");
                            RecortaArray(ref a, start, end);
                            EscribeArrays(a);
                        }
                        break;
                    case 40:
                        {
                            int[] a = { 3, 9, 4, 6, 8, 1 };

                            EscribeArrays(a);
                            OrdenaBurbuja(a);
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
            Console.WriteLine("13 - RellenaEnOrdenDescendente");
            Console.WriteLine("14 - EstarOrdenado");
            Console.WriteLine("15 - NumerosImpares");
            Console.WriteLine("16 - MinArray");
            Console.WriteLine("17 - MaxArray");
            Console.WriteLine("18 - NumeroAprobados");
            Console.WriteLine("19 - PorEncimaDe");
            Console.WriteLine("20 - CuantosCeros");
            Console.WriteLine("21 - CopiaArray");
            Console.WriteLine("22 - CopiaArrayInvertido");
            Console.WriteLine("23 - SumArrays");
            Console.WriteLine("24 - RestaArray, MultiplicaArray, DivideArray");
            Console.WriteLine("25 - InvierteArray");
            Console.WriteLine("26 - ComparaArrays");
            Console.WriteLine("27 - PonNotasArray");
            Console.WriteLine("28 - ConcatenaArrays55");
            Console.WriteLine("29 - ConcatenaArrays");
            Console.WriteLine("30 - Contiene");
            Console.WriteLine("31 - ConcatenaArraysPro");
            Console.WriteLine("32 - CopiaArrayPro");
            Console.WriteLine("33 - CopiaArrayPro");
            Console.WriteLine("34 - BorraDeArray");
            Console.WriteLine("35 - Elimina1ElementoArray");
            Console.WriteLine("36 - EliminaElementoArray");
            Console.WriteLine("37 - InsertaArrayEnArray");
            Console.WriteLine("38 - SubArray");
            Console.WriteLine("39 - RecortaArray");
            Console.WriteLine("40 - OrdenaBurbuja");
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

            string result = "";

            if (a.Length > 0)
            {
                result += "[";

                for (int i = 0; i < a.Length - 1; i++)
                {
                    result += a[i] + ", ";
                }

                result += $"{a[a.Length - 1]}]";
            }
            else
            {
                result += "[]";
            }

            Console.WriteLine(result);
        }
        static void EscribeArraysDouble(double[] a)
        {
            //Escribe una función “EscribeArray” a la que le pasamos un array de enteros del tamaño que sea y lo escribe por pantalla de la misma forma.Tendremos que usar la propiedad “Length” para saber el tamaño del array desde dentro de la función.

            string result = "";

            if (a.Length > 0)
            {
                result += "[";

                for (int i = 0; i < a.Length - 1; i++)
                {
                    result += a[i] + ", ";
                }

                result += $"{a[a.Length - 1]}]";
            }
            else
            {
                result += "[]";
            }

            Console.WriteLine(result);
        }
        static void EscribeArraysBool(bool[] a)
        {
            //Escribe una función “EscribeArray” a la que le pasamos un array de enteros del tamaño que sea y lo escribe por pantalla de la misma forma.Tendremos que usar la propiedad “Length” para saber el tamaño del array desde dentro de la función.

            string result = "";

            if (a.Length > 0)
            {
                result += "[";

                for (int i = 0; i < a.Length - 1; i++)
                {
                    result += a[i] + ", ";
                }

                result += $"{a[a.Length - 1]}]";
            }
            else
            {
                result += "[]";
            }

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

            int size = a.Length;
            
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = size;
                size--;
            }
        }
        static void RellenaAleatorio (int[] a)
        {
            //Escribe una función “RellenaAleatorio” a la que le pasamos un array de enteros y nos lo rellena de valores aleatorios entre 1 y 10.

            Random r = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 11);
            }
        }
        static bool EstarOrdenado (int[] a)
        {
            //Escribe una función “EstaOrdenado” a la que le pasas un array de enteros y te devuelve un booleano que será verdadero si los elementos del array se encuentran en orden ascendente.

            int prev = a[0] - 1, counter = 0;
            bool result;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == prev + 1)
                {
                    counter++;
                }

                prev = a[i];
            }

            result = counter == a.Length ? true : false;

            return result;
        }
        static int NumeroImpares (int[] a)
        {
            //Escribe una función “numeroImpares” a la que le pasas un array de enteros y te devuelve un entero que corresponde a la cantidad de números impares que tenemos en el array

            int counter = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;
        }
        static int MinArray (int[] a)
        {
            //Escribe una función “minArray” a la que le pasas un array y te devuelve el valor más pequeño de los contenidos en dicho array
            int min = int.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }
        static int MaxArray (int[] a)
        {
            //Escribe una función “maxArray” que te devuelve el más grande.

            int max = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }
        static int NumeroAprobados (double[] a)
        {
            int pass = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >=5 && a[i] <= 10)
                {
                    pass++;
                }
            }

            return pass;
        }
        static int PorEncimaDe (int[] a, int limit)
        {
            //Escribe una función “porEncimaDe” a la que le pasamos un valor “limite” y nos devuelve cuántos elementos del array son iguales o mayores que ese límite. Por ejemplo, le pasamos el valor 10 y nos dice cuántos elementos son 10 o más.

            int overLimit = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= limit)
                {
                    overLimit++;
                }
            }

            return overLimit;
        }
        static int Cuantosceros (int[] a)
        {
            //Escribe una función “CuantosCeros” a la que le pasamos un array y nos devuelve un entero que nos dice cuántos elementos tienen el valor 0.
            int numberOfZeros = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    numberOfZeros++;
                }
            }

            return numberOfZeros;
        }
        static void CopiaArray (int[] a, int[] b)
        {
            //Escribe una función “CopiaArray” a la que le pasas dos arrays por parámetro (array1 y array2, por ejemplo) del mismo tamaño(se debería comprobar dentro de la función). La función copiara el contenido del primer array al segundo array.
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
            }
            else
            {
                Console.WriteLine("Los arrays no tienen la misma longitud.");
            }
        }
        static void CopiaArrayInvertido (int[] a, int[] b)
        {
            //Escribe una función “CopiaArrayInvertido” a la que le pasas dos arrays por parámetro y te copia el contenido del primer array al segundo array pero en orden inverso(Ej.: si el primero es[5, 6, 7, 8, 9], en el segundo se copiará[9, 8, 7, 6, 5]).
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    b[i] = a[a.Length - i - 1];
                }
            }
            else
            {
                Console.WriteLine("Los arrays no tienen la misma longitud.");
            }
        }
        static void SumArrays (int[] a, int[] b, int[] c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] + b[i];
            }
        }
        static void RestaArrays (int[] a, int[] b, int[] c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] - b[i];
            }
        }
        static void MultiplicaArrays (int[] a, int[] b, int[] c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] * b[i];
            }
        }
        static void DivideArrays (int[] a, int[] b, double[] c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = (double) a[i] / (double) b[i];
            }
        }
        static void InvierteArray (int[] a)
        {
            // Escribe una función “InvierteArray” a la que le pasamos un array de enteros y modifica su contenido invirtiendo la posición de sus elementos(Ej.: [1,2,3] -> [3,2,1]).
            int[] temp = new int[a.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = a[i];
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = temp[a.Length - i - 1];
            }
        }
        static bool ComparaArrays (int[] a, int[] b)
        {
            //Escribe una función “ComparaArrays” a la que le pasamos dos arrays y nos devuelve un boolean que será verdadero si los dos arrays tienen el mismo tamaño y contienen los mismos datos.
            int i = 0;
            bool result = true;

            if (a.Length == b.Length)
            {
                while (i < a.Length && result == true)
                {
                    if (a[i] == b[i])
                    {
                        i++;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Los arrays no son del mismo tamaño.");
                result = false;
            }

            return result;
        }
        static void PonNotasArray (double[] a, bool[] b)
        {
            //Escribe una función “PonNotasArray” a la que le pasamos dos arrays del mismo tamaño.El primero será un array de reales(double) y contendrá las notas de los alumnos.El segundo será un array de booleanos en el que deberemos escribir en cada posición “true” si la nota es mayor o igual que 5(aprobado) y “false” en caso contrario.

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] >= 5)
                    {
                        b[i] = true;
                    }
                    else
                    {
                        b[i] = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Los arrays no tienen la misma longitud.");
            }
        }
        static void ConcatenaArrays55 (int[] a, int[] b, int[] c)
        {
            //Escribe una función “ConcatenaArrays55” a la que le pasamos tres arrays de enteros. Los dos primeros tendrán un tamaño de 5 y contendrán los datos que hay que copiar. El tercero tendrá un tamaño de 10 y en él copiaremos los datos del primer array y después los datos del segundo(Ej.: [4, 5, 6, 7, 8] & [1, 1, 2, 2, 3] = [4, 5, 6, 7, 8, 1, 1, 2, 2, 3]).
            int i = 0;

            if (a.Length == 5 && b.Length == 5 && c.Length == 10)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    c[i] = a[j];
                    i++;
                }

                for (int k = 0; k < b.Length; k++)
                {
                    c[i] = b[k];
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Los arrays no tienen el tamaño adecuado. Los dos primeros deben tener 5 posiciones y el tercero 10.");
            }
        }
        static void ConcatenaArrays (int[] a, int[] b, int[] c)
        {
            //Escribe una función “ConcatenaArrays” a la que pasamos tres arrays con la condición de que el tamaño del tercero sea igual a la suma del tamaño de los dos primeros.Hará lo mismo que la función anterior.
            int i = 0;

            if (c.Length == (a.Length + b.Length))
            {
                for (int j = 0; j < a.Length; j++)
                {
                    c[i] = a[j];
                    i++;
                }

                for (int k = 0; k < b.Length; k++)
                {
                    c[i] = b[k];
                    i++;
                }
            }
            else
            {
                Console.WriteLine("El tamaño del array donde se quieren concatenar los dos arrays no es adecuado.");
            }
        }
        static bool Contiene (int[] a, int number)
        {
            //Escribe una función “Contiene” a la que le pasamos un array y un valor entero. La función nos devolverá “true” si el array contiene el número y “false” si no lo contiene.
            int i = 0;
            bool result = false;

            while (i < a.Length && result == false)
            {
                if (a[i] == number)
                {
                    result = true;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            return result;
        }
        static int[] ConcatenaArraysPro (int[] a, int[] b)
        {
            /*
              Escribe una función “ConcatenaArraysPro” a la que le pasas dos arrays de enteros y te devuelve un array cuyo tamaño es la suma del tamaño de ambos y que contiene todos los elementos del primero y a continuación los del segundo. Esta función devolverá un array de enteros (int[]) el cuál se creará dentro de la propia función. 
                
                Ej. de uso: 
                int[] a = {1,2,3};
                int[] b = {4,5,6,7,2};
                int[] c;
                c = ConcatenaArraysPro(a, b);
             */
            int[] c = new int[a.Length + b.Length];

            ConcatenaArrays(a, b, c);

            return c;
        }
        static int[] CopiaArrayPro (int[] a)
        {
            /*
             Escribe una función “CopiaArrayPro” a la que le pasas un array y te devuelve un array del mismo tamaño y con los mismos datos.
               
                Ej. de uso: int[] a = {1,2,3};
                int[] b;
                b = CopiaArrayPro(a);
             */
            int[] b = new int[a.Length];

            CopiaArray(a, b);

            return b;
        }
        static void InsertaEnArray (ref int[] a, int number, int position)
        {
            //Escribe una función “InsertaEnArray” a la que le pasas tres parámetros: un array de enteros, un valor entero y una posición. La función insertará el valor en la posición indicada, desplazando el resto de valores para hacerle hueco. Ej.: Si tenemos el array [1,2,3,4,5] y queremos insertar el valor “26” en la posición “2”, el resultado será: [1,2,26,3,4,5]. Nota: el array habrá que pasarlo por referencia; esto es necesario siempre que hay que modificar el tamaño de un array.

            Array.Resize(ref a, a.Length + 1);

            int prev = a[position], temp;
            a[position] = number;

            for (int i = position + 1; i < a.Length; i++)
            {
                temp = a[i];
                a[i] = prev;
                prev = temp;
            }
        }
        static void BorraDeArray (ref int[] a, int position)
        {
            //Escribe una función “BorraDeArray” a la que le pasas dos parámetros: un array de enteros y una posición. La función eliminará el elemento colocado en la posición indicada. Ej.: Si tenemos el array[5, 7, 2, 8, 1] y queremos eliminar la posición 1, el resultado será:[5,2,8,1]. Nota: el array habrá que pasarlo por referencia; esto es necesario siempre que hay que modificar el tamaño de un array.

            for (int i = position; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }

            Array.Resize(ref a, a.Length - 1);
        }
        static void Elimina1ElementoArray (ref int[] a, int number)
        {
            //Escribe una función “Elimina1ElementoArray” a la que le pasas dos parámetros: un array de enteros y un valor entero.La función eliminará del array el valor entero independientemente de la posición en la que se encuentre.Si el valor se repite, se eliminará sólo la primera vez que aparece el valor. Nota: el array habrá que pasarlo por referencia; esto es necesario siempre que hay que modificar el tamaño de un array.

            int i = 0, j = -1;
            
            while ((i < a.Length - 1) && j == -1)
            {
                if (a[i] == number)
                {
                    j = i;
                }

                i++;
            }

            if (j != -1)
            {
                BorraDeArray(ref a, j);
            }
            else
            {
                Console.WriteLine("No se encontró el número en el array.");
            }
        }
        static void EliminaConMultipesBorraDeArray (ref int[] a, int number)
        {
            //Escribe una función “EliminaElementosArray” a la que le pasas dos parámetros: un array de enteros y un valor entero.La función eliminará del array el valor entero independientemente de la posición en la que se encuentre.Si el valor se repite, se eliminarán todas las veces que se repite. Nota: el array habrá que pasarlo por referencia; esto es necesario siempre que hay que modificar el tamaño de un array.

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == number)
                {
                    BorraDeArray(ref a, i);
                }
            }
        }
        static void EliminaElementoArray (ref int[] a, int number)
        {
            //Escribe una función “EliminaElementosArray” a la que le pasas dos parámetros: un array de enteros y un valor entero.La función eliminará del array el valor entero independientemente de la posición en la que se encuentre.Si el valor se repite, se eliminarán todas las veces que se repite. Nota: el array habrá que pasarlo por referencia; esto es necesario siempre que hay que modificar el tamaño de un array.

            /*
                Explicación Luis: Cuando sea un 4, sube un contador. Cuando no sea un 4, mueve a la izquierda tantas posiciones como valor actual del contador.
                
                Array   1 2 4 5 4 6 7 8 4
                Shift   0 0 1 1 2 2 2 2 3
                Nuevo   1 2 5 6 7 8
            */

            int counter = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == number)
                {
                    counter++;
                }
                else
                {
                    a[i - counter] = a[i];
                }
            }

            Array.Resize(ref a, a.Length - counter);
        }
        static void InsertaArrayEnArray (ref int[] a, int position, int[] b )
        {
            //Escribe una función “InsertaArrayEnArray” a la que le pasas tres parámetros: un array de enteros, una posición de ese array, y otro array de enteros. La función insertará en el primer array, a partir de la posición indicada, todo el contenido del segundo array. Ej.: [6, 2, 1, 3], posición: 2, insertar:[12, 13], resultado = [6, 2, 12, 13, 1, 3]. Nota: el array habrá que pasarlo por referencia; esto es necesario siempre que hay que modificar el tamaño de un array.

            int originalSize = a.Length;

            if (position < a.Length && position >= 0)
            {
                Array.Resize(ref a, a.Length + b.Length);
                EscribeArrays(a);

                for (int i = originalSize; i < a.Length; i++)
                {
                    a[i] = a[i - b.Length];
                }

                for (int i = position; i <= originalSize; i++)
                {
                    a[i] = b[i - position];
                }
            }
            else
            {
                Console.WriteLine("No existe esa posición en el array.");
            }
        }
        static int[] SubArray (int[] a, int start, int end)
        {
            //Escribe una función “SubArray” a la que le pasas un array y dos posiciones. La función te devuelve otro array que contiene los datos comprendidos entre ambas posiciones (incluidas ambas dos). Ej.: [3, 6, 2, 8, 9], posiciones, 1 y 3, resultado = [6, 2, 8].

            int j = start;
            int[] result = new int[end];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = a[j];
                j++;
            }

            return result;
        }
        static void RecortaArray (ref int[] a, int start, int end)
        {
            //Escribe una función “RecortaArray” a la que le pasas un array y dos posiciones. La función modificará el array inicial quedándose sólo con lo contenido entre ambas posiciones(como el ejercicio anterior pero en vez de devolver un array diferente modifica el array que le pasas).Nota: el array habrá que pasarlo por referencia; esto es necesario siempre que hay que modificar el tamaño de un array

            int j = start;
            
            for (int i = 0; i < end; i++)
            {
                a[i] = a[j];
                j++;
            }

            Array.Resize(ref a, end);
        }
        static void OrdenaBurbuja (int[] a)
        {
            /*
            Escribe la función “OrdenaBurbuja” a la que le pasaremos un array de enteros y lo ordenará mediante la ordenación de la burbuja. 
            La ordenación de la burbuja funciona de la siguiente forma:

                • Si el array tiene N elementos, se realizarán N-1 pasadas (por ejemplo, para un array de 5 elementos tendremos que realizar 4 pasadas para que quede ordenado).
                • En cada pasada, iremos recorriendo el array de principio a fin comprobando los números por parejas (por ejemplo: el primer y segundo número, el segundo y el tercero, etc.).
                • Si la pareja de números está en orden (o sea, el primero es menor que el segundo) la dejamos como está y si está desordenada, los intercambiamos.
                
            Ejemplo:

            Si el array original es [3, 9, 4, 6, 8, 1], la pasada sería así:
            
            [3, 9, 4, 6, 8, 1] -> [3, 4, 9, 6, 8, 1] -> [3, 4, 6, 9, 8, 1] -> [3, 4, 6, 8, 9, 1] -> [3, 4, 6, 8, 1, 9]
            
            Podéis comprobar que el array no se ordena con una sola pasada, pero poco a poco va quedando más ordenado. 
            */

            int temp;

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}
