using System;

namespace ArraysAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            WriteMenu();

            option = int.Parse(Console.ReadLine());


            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        {
                            int[] a = { 0, 1, 2, 3, 4, 5 };
                            
                            EscribeArrays(a);
                            IntercambiaParImpar(a);
                            EscribeArrays(a);
                        }
                        break;
                    case 2:
                        {
                            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                            int[] b = { 5, 5, 6, 5, 8, 6, 6, 6, 4, 5, 2, 2, 7, 3, 0, 7 };
                            int[] c = { 4, 9, 2, 9, 9, 9, 6, 8, 6, 1, 5, 0, 1, 7, 5, 6 };

                            EscribeArrays(a);
                            Console.WriteLine(CompruebaTarjeta(a));

                            EscribeArrays(b);
                            Console.WriteLine(CompruebaTarjeta(b));

                            EscribeArrays(c);
                            Console.WriteLine(CompruebaTarjeta(c));
                        }
                        break;
                    case 3:
                        {
                            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                            EscribeArrays(a);
                            
                            Console.WriteLine("n = 5");
                            EscribeArrays(TailArray(a, 5));

                            Console.WriteLine("n = 9");
                            EscribeArrays(TailArray(a, 9));
                        }
                        break;
                    case 4:
                        {
                            int[] a = { 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 };
                            int[] b = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                            EscribeArrays(a);
                            Console.WriteLine(Detecta5(a));

                            EscribeArrays(b);
                            Console.WriteLine(Detecta5(b));
                        }
                        break;
                    case 5:
                        {
                            int number = 10;

                            EscribeArraysBool(CalculaNPrimos(number));
                        }
                        break;
                    default:
                        break;
                }

                WriteMenu();
                option = int.Parse(Console.ReadLine());
            }
        }
        static void WriteMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menú");
            Console.WriteLine();
            Console.WriteLine("1 - IntercambiaParImpar");
            Console.WriteLine("2 - CompruebaTarjeta");
            Console.WriteLine("3 - TailArray");
            Console.WriteLine("4 - Detecta5");
            Console.WriteLine("5 - CalculaNPrimos");
            Console.WriteLine("0 - Salir");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
        }
        static void EscribeArrays(int[] a)
        {
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
        static bool IsPrime(int number)
        {
            bool result;
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        static  void IntercambiaParImpar (int[] a)
        {
            /*
                 Escribe la función IntercambiaParImpar. A esta función le pasaremos un array de enteros por parámetro y en ese mismo array intercambiará los elementos de las posiciones pares por los elementos de las posiciones impares: el elemento de la posición 0 se intercambiará con el de la posición 1, el de la posición 2 con el de la posición 3, etc. El array tendrá que tener un número par de elementos (2, 4, 6, etc.). De no ser así, la función mostrará un mensaje de error y dejará el array como estaba.
                Ej.: 
                Si le pasamos [1, 2, 3, 4, 5, 6], el array quedará: [2, 1, 4, 3, 6, 5]
                Si le pasamos [1, 2, 1, 2, 1, 2], el array quedará: [2, 1, 2, 1, 2, 1]
                Si le pasamos [7, 1, 4, 6, 9, 5], el array quedará: [1, 7, 6, 4, 5, 9] 
            */

            int temp;

            if (a.Length % 2 == 0)
            {
                for (int i = 0; i < a.Length; i += 2)
                {
                    temp = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = temp;
                }
            }
            else
            {
                Console.WriteLine("ERROR: El array no tiene un número par de elementos.");
            }
        }
        static bool CompruebaTarjeta (int[] a)
        {
            /*
                 Escribe la función CompruebaTarjeta. A esta función le pasaremos un array de enteros con los 16 números de una tarjeta de crédito. La función nos devolverá un bool que será true si el número de tarjeta es correcto y false si no lo es. Para averiguar si un número de tarjeta de crédito es correcto utilizaremos el siguiente algoritmo:
                1. Multiplicar por dos los valores que estén en las posiciones pares del array (0, 2, …).
                2. Si algún valor es mayor o igual que 10, restarle 9 a ese valor.
                3. Sumar todos los valores. Si el resultado es múltiplo de 10, la tarjeta es buena.
            
                Ejemplos de tarjetas válidas: 5565 8666 4522 7307, 4929 9968 6150 1756
                Nota: No os carguéis el array inicial. Si el array no tiene 16 elementos, devolver false directamente. 
            */

            bool result = true;
            int value, total = 0;

            if (a.Length == 16)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    value = i % 2 == 0 ? a[i] * 2 : a[i];
                    
                    if (value >= 10)
                    {
                        value -= 9;
                    }

                    total += value;
                }

                if (total % 10 != 0)
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            
            return result;
        }
        static int[] TailArray (int[] a, int n)
        {
            /*
                 Escribe la función TailArray. A esta función le pasaremos un array de enteros y un número n. La función nos devolverá otro array de enteros con los n últimos elementos del array que le pasamos. O sea, si n = 5, nos devolverá un array con las cinco últimas posiciones del primero. Si n es mayor que el número de elementos del array o n es menor que 0, la función mostrará un mensaje de error y devolverá el array original.
                Ej.: Si le pasamos [1, 2, 3, 4, 5, 6] y n=3, nos devolverá: [4, 5, 6]
                Nota: El array que le pasamos por parámetro debe quedar exactamente igual que al principio; no os lo carguéis. 
            */

            int[] result;
            int j = 0;

            if (n > a.Length || n < 0)
            {
                Console.WriteLine("ERROR");
                result = a;
            }
            else
            {
                result = new int[n];

                for (int i = a.Length - n; i < a.Length; i++)
                {
                    result[j] = a[i];
                    j++;
                }
            }

            return result;
        }
        static bool Detecta5 (int[] a)
        {
            //Escribe la función Detecta5 a la que le pasamos un array de enteros y nos dice si hay, al menos una vez, cinco números iguales consecutivos(nos devuelve un boolean).

            bool result = false;
            int counter = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    counter++;
                    if (counter == 4)
                    {
                        result = true;
                        i = a.Length;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            return result;
        }
        static bool[] CalculaNPrimos (int number)
        {
            /*
                Escribe la función CalculaNPrimos. A la función le pasaremos un entero que será el máximo número primo que queremos calcular. Por ejemplo, si le pasamos el 10 nos dirá qué números son primos entre 1 y 10. El resultado lo devolverá en un array de booleanos, de tal forma que, si un número x es primo, en la posición x pondrá true y si no es primo pondrá false.
                Ej.:
                CalculaNPrimos(10) nos devolverá un array de 11 elementos (porque la primera posición es 0 y necesitamos 11 para que exista la posición 10).
                
                El array será: [ False False True True False True False True False False False ]
                Las dos primeras posiciones son false porque el 0 y el 1 no son primos y luego estarán a true las posiciones 2, 3, 5 y 7.
            */

            bool[] result = new bool[number + 1];

            for (int i = 0; i < result.Length; i++)
            {
                if (IsPrime(i))
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }
            }

            return result;
        }
        static void EscribeArrayNotas (double[] a)
        {
            /*
                Escribe la función EscribeArrayNotas que te escribe por pantalla un array de double que contiene notas del alumnado, con las siguientes características:
                    • Si la nota está entre 5 y 10, se escribirá en verde.
                    • Si la nota está entre 0 y 5 (sin incluir el cinco), se escribirá en rojo.
                    • Si la nota no está entre 0 y 10, en lugar de la nota se escribirá “ERROR” en amarillo.
                    • El resto de cosas (los corchetes, las comas) se escribirán en blanco.
                Para cambiar de color en la consola, antes de escribir con Console.Write tenéis que usar la función “Console.ForegroundColor = ConsoleColor.” y te sale una lista para elegir el color que quieres usar. 
            */

            if (a.Length > 0)
            {
                Console.Write("[");

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0 && a[i] <= 10)
                    {
                        if (a[i] >= 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("ERROR");
                    }
                }
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
    }
}
