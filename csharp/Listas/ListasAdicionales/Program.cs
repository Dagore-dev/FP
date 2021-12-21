using System;
using System.Collections.Generic;
using System.Linq;

namespace ListasAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Showmenu();
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        List<int> l = new List<int> { 5, 5, 1, 2, 8, 3, 0, 3, 2, 2, 5, 7, 5};

                        EscribeLista(l);
                        OrdenaRepetidos(l);
                        EscribeLista(l);
                    }
                    break;
                case 2:
                    {
                        List<int> l1 = new List<int> { 1, 1, 2, 3, 99, 1, 99, 5 };

                        EscribeLista(l1);
                        EscribeLista(ElementosUnicos(l1));
                        EscribeLista(ElementosRepetidos(l1));
                    }
                    break;
                case 3:
                    {
                        List<int> l1 = new List<int> { 1, 1, 2, 6, 0, 0, 5, 4 }, l2 = new List<int> { 6, 2, 0, 3, 6, 4 };

                        EscribeLista(ListaDominoDobles(l1));
                        EscribeLista(ListaDominoDobles(l2));
                    }
                    break;
                case 4:
                    {
                        string s1 = "Amanda tiene tres serpientes";

                        EscribeListaString(PalabrasMismaLetra(s1));
                    }
                    break;
                case 5:
                    {
                        string s1 = "Mi mamá me mima";

                        EscribeListaString(ListaPalabrasLargas(s1, 4));
                    }
                    break;
                case 6:
                    {
                        List<string> cities = new List<string> { "Jerez", "Tarifa", "Barbate" };
                        List<double> temperatures = new List<double> { 18.9, 14.1, 18.9 };

                        EscribeListaString(cities);
                        EscribeListaDouble(temperatures);
                        HaceCalor(cities, temperatures);
                        EscribeListaString(cities);
                        EscribeListaDouble(temperatures);
                    }
                    break;
                default:
                    break;
            }
        }
        #region Utils
        static void Showmenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine(" 1 - OrdenaRepetidos");
            Console.WriteLine(" 2 - ElementosUnicos y ElementosRepetidos");
            Console.WriteLine(" 3 - ListaDominoDobles");
            Console.WriteLine(" 4 - PalabrasMismaLetra");
            Console.WriteLine(" 5 - ListaPalabrasLargas");
            Console.WriteLine(" 6 - HaceCalor");
            Console.WriteLine(" 0 - Salir");
            Console.Write("Introduzca una opción: ");
        }
        static void EscribeLista(List<int> l)
        {
            Console.Write("<");

            if (l.Count > 0)
            {
                for (int i = 0; i < l.Count - 1; i++)
                {
                    Console.Write(l[i] + ", ");
                }

                Console.Write(l[l.Count - 1]);
            }

            Console.Write(">");
            Console.WriteLine();
        }
        static void AddNTimes(List<int> l, int value, int n)
        {
            for (int i = 0; i < n; i++)
            {
                l.Add(value);
            }
        }
        static int Repeats(List<int> l, int value)
        {
            int result = 0;

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == value)
                {
                    result++;
                }
            }

            return result;
        }
        static List<int> EliminaRepetidos(List<int> l1)
        {
            List<int> l2 = new List<int>();

            for (int i = 0; i < l1.Count; i++)
            {
                if (!l2.Contains(l1[i]))
                {
                    l2.Add(l1[i]);
                }
            }

            return l2;
        }
        static void EscribeListaString(List<string> l)
        {
            Console.Write("<");

            if (l.Count > 0)
            {
                for (int i = 0; i < l.Count - 1; i++)
                {
                    Console.Write(l[i] + ", ");
                }

                Console.Write(l[l.Count - 1]);
            }

            Console.Write(">");
            Console.WriteLine();
        }
        static void EscribeListaDouble(List<double> l)
        {
            Console.Write("<");

            if (l.Count > 0)
            {
                for (int i = 0; i < l.Count - 1; i++)
                {
                    Console.Write(l[i] + ", ");
                }

                Console.Write(l[l.Count - 1]);
            }

            Console.Write(">");
            Console.WriteLine();
        }
        static string OnlyLettersAndSpaces(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) || char.IsWhiteSpace(s[i]))
                {
                    result += s[i];
                }
            }

            return result;
        }
        #endregion
        #region Ejercicios
        static void OrdenaRepetidos (List<int> l)
        {
            //Escribe la función OrdenaRepetidos, a la que le pasas una lista con números y te la ordena en función del número de veces que se repiten sus elementos, con los números que más se repiten apareciendo en las primeras posiciones y los que menos se repiten(o aparecen una sola vez) apareciendo en las últimas.
            //Ej.: [5, 5, 1, 2, 8, 3, 0, 3, 2, 2, 5, 7, 5] => [5, 5, 5, 5, 2, 2, 2, 3, 3, 1, 8, 0, 7]

            List<int> set = EliminaRepetidos(l), frecuency = new List<int>(), result = new List<int>();
            int max, index;

            for (int i = 0; i < set.Count; i++)
            {
                frecuency.Add(Repeats(l, set[i]));
            }

            while (frecuency.Count > 0)
            {                
                max = frecuency.Max();
                index = frecuency.IndexOf(max);

                AddNTimes(result, set[index], max);

                frecuency.Remove(max);
                set.RemoveAt(index);
            }

            l.Clear();
            l.AddRange(result);
        }
        static List<int> ElementosUnicos (List<int> l)
        {
            //La función ElementosUnicos recibirá una lista y nos devolverá otra lista que contendrá solamente los elementos de la primera que sólo aparecen una vez. Ej.: { 1, 1, 2, 3, 99, 1, 99, 5} nos devolvería { 2, 3, 5 }

            List<int> result = new List<int>();
            int count = 0;

            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[j] == l[i])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    result.Add(l[i]);
                }

                count = 0;
            }
            
            return result;
        }
        static List<int> ElementosRepetidos (List<int> l)
        {
            //La función ElementosRepetidos hace justo lo contrario: recibirá una lista y nos devuelve otra lista con los elementos que aparecen repetidos en la primera lista. Ej.: { 1, 1, 2, 3, 99, 1, 99, 5} nos devolvería { 1, 99}

            List<int> result = new List<int>();
            int count = 0;

            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (l[j] == l[i])
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    result.Add(l[i]);
                }

                count = 0;
            }

            return EliminaRepetidos(result);
        }
        static List<int> ListaDominoDobles (List<int> l)
        {
            List<int> result = new List<int>();
            bool isCorrect = true;
            
            if (l.Count % 2 == 0)
            {

                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i] < 0 || l[i] > 6)
                    {
                        isCorrect = false;
                        i = l.Count;
                    }
                }

                if (isCorrect)
                {
                    for (int i = 0; i < l.Count - 1; i += 2)
                    {
                        if (l[i] == l[i + 1])
                        {
                            result.Add(l[i]);
                            result.Add(l[i]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Valores no comprendidos entre 0 y 6.");
                }

            }
            else
            {
                Console.WriteLine("ERROR: La lista no es par.");
            }

            return result;
        }
        static List<string> PalabrasMismaLetra (string s)
        {
            //Escribe la función PalabrasMismaLetra a la que le pasamos una cadena y nos devolverá una lista de cadenas que contendrá las palabras que empiezan y acaban por la misma letra. A la hora de contar las palabras, habrá que ignorar los símbolos de puntuación y las mayúsculas y minúsculas. Ej.: “Amanda tiene tres serpientes” devolvería {amanda, serpientes}

            string word;
            string[] splitted = OnlyLettersAndSpaces(s).ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            for (int i = 0; i < splitted.Length; i++)
            {
                word = splitted[i];

                if (word[0] == word[word.Length - 1])
                {
                    result.Add(word);
                }
            }

            return result;
        }
        static List<string> ListaPalabrasLargas (string s, int min)
        {
            //Escribe la función ListaPalabrasLargas, a la que le pasamos una cadena que contiene palabras separadas por espacios y un entero en el que le indicamos la longitud mínima de una palabra y nos devuelve una lista de cadenas que contendrá solamente las palabras que tienen una longitud igual o mayor a la mínima. Ej.: “Mi mamá me mima” (longitud = 4) devolvería { mamá, mima}

            List<string> result = new List<string>();
            string[] splitted = OnlyLettersAndSpaces(s).Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string word;

            for (int i = 0; i < splitted.Length; i++)
            {
                word = splitted[i];

                if (word.Length >= min)
                {
                    result.Add(word);
                }
            }

            return result;
        }
        static void HaceCalor (List<string> cities, List<double> temperatures)
        {
            /*
            Escribe la función HaceCalor a la que la pasamos dos listas: una lista de string con nombres de localidades y una lista de double con temperaturas. Cada temperatura corresponde a la localidad que está en la misma posición de la otra lista.
                Ej.: [ Jerez, Tarifa, Barbate ]
                     [ 18.9,   14.1,   18.6 ]
                La función deberá calcular la temperatura media y borrar de las listas las localidades y temperaturas que estén por debajo de la media (es decir, dejar sólo las temperaturas que estén por encima de la media).
                En el ejemplo, habría que borrar “Tarifa” y su temperatura “14.1”.
                Si las listas tienen diferente tamaño, deberá dar un error. 
            */
            double average = temperatures.Average();

            if (cities.Count == temperatures.Count)
            {
                for (int i = 0; i < cities.Count; i++)
                {
                    if (temperatures[i] < average)
                    {
                        cities.RemoveAt(i);
                        temperatures.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        #endregion
    }
}
