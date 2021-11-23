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
                    case 6:
                        {
                            double[] a = { 1, 2, 3, 4, 5, 6.7, 8, 9.5, 10, 11 };
                            EscribeArraysDouble(a);
                            EscribeArrayNotas(a);
                        }
                        break;
                    case 7:
                        {
                            int[] a = { 1, 3, 7, 5 };
                            int[] b = { 8, 1, 9, 3 };

                            EscribeArrays(a);
                            EscribeArrays(b);

                            Console.WriteLine();
                            TachaElementosNoComunes(a, b);

                            EscribeArrays(a);
                            EscribeArrays(b);
                        }
                        break;
                    case 8:
                        {
                            int[] a = { 1, 2, 2, 3, 8, 1, 3 };
                            EscribeArrays(a);

                            Console.WriteLine();

                            EscribeArrays(EliminaRepetidos(a));
                        }
                        break;
                    case 9:
                        {
                            double[] a = { 1.56, 2.75, 3, 9.9 };

                            EscribeArraysDouble(a);

                            Console.WriteLine("RedondeaArray");
                            EscribeArraysDouble(RedondeaArray(a));

                            Console.WriteLine("DecimalesArray");
                            EscribeArraysDouble(DecimalesArray(a));
                        }
                        break;
                    case 10:
                        {
                            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                            EscribeArrays(a);

                            DesordenaArray(a);
                            EscribeArrays(a);
                        }
                        break;
                    case 11:
                        {
                            int[] a = { 7, 3, 9, 4, 4, 6 };

                            EscribeArrays(a);
                            Console.WriteLine();

                            EscribeArrays(MinMaxArray(a));
                        }
                        break;
                    case 12:
                        {
                            int[] a = { 9, 5, 3, 2, 10 };

                            GraficaBarras(a);
                        }
                        break;
                    case 13:
                        {
                            int[] a = { 2, 1, 1, 0, 1, 1, 0, 1, 1, 0, 2, 0, 5, 1, 2, 2, 1, 0 };
                            EscribeArrays(a);

                            Console.WriteLine(MejorRacha(a));
                        }
                        break;
                    case 14:
                        {
                            NumerosPrimosPro(25);
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
            Console.WriteLine("6 - EscribeArrayNotas");
            Console.WriteLine("7 - TachaElementosNoComunes");
            Console.WriteLine("8 - EliminaRepetidos");
            Console.WriteLine("9 - RedondeaArray y DecimalesArray");
            Console.WriteLine("10 - DesordenaArray");
            Console.WriteLine("11 - MinMaxArray");
            Console.WriteLine("12 - GraficaBarras");
            Console.WriteLine("13 - MejorRacha");
            Console.WriteLine("14 - NumerosPrimosPro");
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
        static void EscribeArraysDouble(double[] a)
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

                for (int i = 0; i < a.Length - 1; i++)
                {
                    CheckGrade(a[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("; ");
                }
                CheckGrade(a[a.Length - 1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }
        static void CheckGrade (double grade)
        {
            if (grade > 0 && grade <= 10)
            {
                if (grade >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(grade);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ERROR");
            }
        }
        static void TachaElementosNoComunes (int[] a, int[] b)
        {
            //Escribe la función TachaElementosNoComunes a la que le pasamos dos arrays. La función sustituirá los elementos de un array que no aparezcan en el otro por ceros (y viceversa).
            //Ej: [1, 3, 5, 7] y [1, 2, 3, 4] => [1, 3, 0, 0] y [1, 0, 3, 0]

            bool IsCommon = false;
            
            for (int i = 0; i < a.Length; i++)
            {

                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        IsCommon = true;
                        j = b.Length;
                    }
                }

                if (!IsCommon)
                {
                    a[i] = 0;
                }

                IsCommon = false;
            }

            for (int i = 0; i < b.Length; i++)
            {

                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i] == a[j])
                    {
                        IsCommon = true;
                        j = a.Length;
                    }
                }

                if (!IsCommon)
                {
                    b[i] = 0;
                }

                IsCommon = false;
            }
        }
        static void CopiaArray(int[] a, int[] b)
        {
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
        static void EliminaConcurrencias(ref int[] a, int number)
        {
            bool first = false;
            int counter = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == number)
                {
                    if (!first)
                    {
                        first = true;
                    }
                    else
                    {
                        counter++;
                    }
                }
                else
                {
                    a[i - counter] = a[i];
                }
            }

            Array.Resize(ref a, a.Length - counter);
        }
        static int[] EliminaRepetidos (int[] a)
        {
            //Escribe la función EliminaRepetidos a la que le pasas un array y te devuelve otro array en el que se han eliminado los elementos que estén repetidos.
            //Ej: [1, 5, 9, 2, 3, 4, 1, 1, 2] => [1, 5, 9, 2, 3, 4]

            int[] copy = new int[a.Length];

            CopiaArray(a, copy);

            for (int i = 0; i < copy.Length; i++)
            {
                EliminaConcurrencias(ref copy, a[i]);
            }

            return copy;
        }
        static double[] RedondeaArray (double[] a)
        {
            /*
                Escribe dos funciones: RedondeaArray y DecimalesArray. A la función RedondeaArray le pasaremos un array de double y nos devolverá otro array de double en el que a los números le quitamos la parte decimal.
                
                Ej.: [1.56, 2.75, 3, 9.9] => [1, 2, 3, 9]
                
                A la función DecimalesArray le pasaremos un array de double y nos devolverá otro array de double en el que aparecerán solamente las partes decimales de los números.
                
                Ej.: [1.56, 2.75, 3, 9.9] => [0.56, 0.75, 0, 0.9] 
            */

            double[] result = new double[a.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Math.Floor(a[i]);
            }

            return result;
        }
        static double[] DecimalesArray (double[] a)
        {
            /*
                Escribe dos funciones: RedondeaArray y DecimalesArray. A la función RedondeaArray le pasaremos un array de double y nos devolverá otro array de double en el que a los números le quitamos la parte decimal.

                Ej.: [1.56, 2.75, 3, 9.9] => [1, 2, 3, 9]

                A la función DecimalesArray le pasaremos un array de double y nos devolverá otro array de double en el que aparecerán solamente las partes decimales de los números.

                Ej.: [1.56, 2.75, 3, 9.9] => [0.56, 0.75, 0, 0.9] 
            */
            double[] result = new double[a.Length];
            double temp;

            for (int i = 0; i < result.Length; i++)
            {
                temp = Math.Truncate(a[i]);

                result[i] = a[i] - temp;
            }
            
            return result;
        }
        static void DesordenaArray (int[] a)
        {
            //Escribe la función DesordenaArray. La función recibirá un array de enteros por parámetro, que al término de la función deberá quedar desordenado. Para conseguir esto, iremos cogiendo los elementos de un array de manera aleatoria y los iremos poniendo en un array auxiliar.

            Random r = new Random();
            int position, temp;

            for (int i = 0; i < a.Length; i++)
            {
                position = r.Next(0, a.Length);

                temp = a[i];

                a[i] = a[position];
                a[position] = temp;
            }
        }
        static int MinArray(int[] a)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }
        static int MaxArray(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }
        static int[] MinMaxArray (int[] a)
        {
            /*
                Escribe la función MinMaxArray a la que le pasaremos un array de enteros y nos devolverá otro array de enteros diferente en el que aparecerán los números comprendidos entre el menos y el mayor del array que le hemos pasado. 
                
                Con un ejemplo se entiende mejor:
                    Le pasamos [7, 3, 9, 4, 4, 6]
                    El mínimo es 3, el máximo 9.
                    Nos devolverá [3, 4, 5, 6, 7, 8, 9] 
            */

            int min = MinArray(a), max = MaxArray(a);
            int[] result = new int[(max - min) + 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = min + i;
            }

            return result;
        }
        static void GraficaBarras (int[] a)
        {
            /*
                Escribe la función GraficaBarras a la que le pasamos un array de enteros y nos muestra una gráfica de barras por pantalla. Ejemplo: [9, 5, 3, 2, 10]

                 9 █████████
                 5 █████
                 3 ███
                 2 ██
                10 ██████████

                • Antes de pintar la gráfica, habrá que comprobar que todos los valores estén entre 0 y 10 (supongamos que representan vuestras notas). Si hay valores incorrectos, no se pinta la gráfica y se muestra un mensaje de error.
                • Usar el caracter ASCII 219 (█) para las barritas
                • Dejar una línea en blanco entre barra y barra para que quede bonito.
                • OPCIONAL: que los aprobados aparezcan en verde y los suspensos en rojo. 
            */

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 10 || a[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ERROR");
                    Console.ForegroundColor = ConsoleColor.White;

                    i = a.Length;
                }
                else
                {
                    if (a[i] > 9)
                    {
                        Console.Write(a[i] + " ");
                    }
                    else
                    {
                        Console.Write(" " + a[i] + " ");
                    }

                    for (int j = 0; j < a[i]; j++)
                    {
                        if (a[i] >= 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        Console.Write("█");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine();
                }
            }
        }
        static int MejorRacha (int[] a)
        {
            /*
                Escribe la función MejorRacha a la que le pasamos un array que contiene resultados de fútbol y nos devuelve un entero correspondiente a la mayor racha de victorias seguidas. El array contendrá parejas de números (o sea, su tamaño será par) de los cuales el primero serán los goles que ha marcado nuestro equipo y el segundo los goles que ha recibido (p.ej.: [1, 0, 2, 2, 3, 5] se correspondería con una victoria por 1-0, un empate 2-2 y una derrota por 3-5). La función contará cuantas victorias consecutivas hay y nos devolverá la mayor racha.
                Ej.: [2, 1, 1, 0, 1, 1, 0, 1, 1, 0, 2, 0, 5, 1, 2, 2, 1, 0] se corresponde con: 2-1, 1-0, 1-1, 0-1, 1-0, 2-0, 5-1, 2-2, 1-0, con una racha máxima de 3 victorias.
            */

            int counter = 0, result = 0;

            if (a.Length % 2 == 0)
            {
                for (int i = 0; i < a.Length - 1; i+=2)
                {
                    if (a[i] > a[i + 1])
                    {
                        counter++;

                        if (counter > result)
                        {
                            result = counter;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error con el tamaño del array.");
            }

            return result;
        }
        static void NumerosPrimosPro (int max)
        {
            /*
                Escribe la función NumerosPrimosPro que nos calculará los números primos entre 1 y otro número (para probarlo, nos vale con 1000). Esta función usará un algoritmo más avanzado que el que hemos visto con anterioridad y que es mucho más eficiente a la hora de calcular muchos números primos.
                
                El funcionamiento es el siguiente (para el ejemplo del 1 al 1000): 
                    • Creamos un array de 1001 elementos (por el cero).
                    • Empezamos en la posición 2 del array y vamos haciendo lo siguiente:
                        o Si en esta posición hay un 0 (que es lo que había al principio), añadimos esta posición a una lista de números primos.
                        o Si había un 0, además, tenemos que ir “tachando” todos los múltiplos de ese número primo poniendo otro valor en esas posiciones (por ejemplo, un -1). En el caso del 2, que sería el primero, pondríamos un -1 en la posición 4, 6, 8, 10, 12, etc., y así hasta llegar al 1000.
                        o Si en la posición hay un -1, eso es que este número ya era múltiplo de uno anterior, así que no hacemos nada y pasamos al siguiente.
                    • Al final, devolveremos la lista de números primos que hemos ido recopilando.
               
                Para comprobarlo, mostrar los números primos entre 1 y 1000 por pantalla y escribir cuántos números son (empieza por 2, 3, 5, 7... acaba por 983, 991, 997 y son 168 números primos en total).
            */

            int[] a = new int[max + 1];

            for (int i = 2; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    Console.WriteLine(i);

                    for (int j = i + i; j < a.Length; j += i)
                    {
                        a[j] = -1;
                    }
                }
            }

            EscribeArrays(a);
        }
    }
}
