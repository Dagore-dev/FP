using System;
using System.Collections.Generic;
using System.Linq;

namespace EntregaListas
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
                        List<int> l = new List<int>();
                        EscribeListCutre(l);
                        LeeLista(l);
                        EscribeListCutre(l);
                    }
                    break;
                case 2:
                    {
                        List<int> l = new List<int>();
                        EscribeListCutre(l);
                        LeeListaN(l, 10);
                        EscribeListCutre(l);
                    }
                    break;
                case 3:
                    {
                        List<int> l = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, l2 = new List<int>(), l3 = new List<int> { 1 };
                        EscribeLista(l);
                        EscribeLista(l2);
                        EscribeLista(l3);
                    }
                    break;
                case 4:
                    {
                        List<int> l = new List<int> { 0, -1, 2, -3, 4, -5, 6, -7, 8, -9 }, l2 = new List<int> { 0, 1, -2, 3, -4, 5, -6, 7, -8, 9 }, l3 = new List<int> { 0, -1, 2, -3, 4, -5, 6, -7, 8, -9 }, l4 = new List<int> { 0, 1, -2, 3, -4, 5, -6, 7, -8, 9 };

                        EscribeLista(l);
                        EliminaNegativos(l);
                        EscribeLista(l);

                        Console.WriteLine();

                        EscribeLista(l2);
                        EliminaNegativos(l2);
                        EscribeLista(l2);

                        Console.WriteLine();

                        EscribeLista(l3);
                        EliminaNegativosPredicado(l3);
                        EscribeLista(l3);

                        Console.WriteLine();

                        EscribeLista(l4);
                        EliminaNegativosPredicado(l4);
                        EscribeLista(l4);
                    }
                    break;
                case 5:
                    {
                        List<int> l1 = new List<int> { -3, -1, 2, -2, 3, 1, 5, -4, 4, -5 }, l2 = new List<int>(), l3 = new List<int>();

                        EscribeLista(l1);
                        ClasificaNumeros(l1, l2, l3);
                        EscribeLista(l2);
                        EscribeLista(l3);
                    }
                    break;
                case 6:
                    {
                        List<int> l = new List<int> { 1, 2, 1, 1, 2, 2, 2, 1, 2, 1, 2 };
                        EscribeLista(l);
                        EliminaRepetidos(l);
                        EscribeLista(l);
                    }
                    break;
                case 7:
                    {
                        List<int> l1 = new List<int> { -3, -1, 2, -2, 3, 1, 5, -4, 4, -5 };

                        EscribeLista(l1);
                        OrdenaListaSeleccion(l1);
                        EscribeLista(l1);
                    }
                    break;
                case 8:
                    {
                        List<int> l1 = new List<int> { -3, -1, 2, -2, 3, 1, 5, -4, 4, -5 };

                        EscribeLista(l1);
                        OrdenaListaInsercion(l1);
                        EscribeLista(l1);
                    }
                    break;
                case 9:
                    {
                        List<string> l1 = new List<string> { "Hola", "Don", "Pepito", "Hola", "Don", "José" };

                        EscribeListaString(l1);
                        OrdenaPalabrasLista(l1);
                        EscribeListaString(l1);
                    }
                    break;
                case 10:
                    {
                        List<string> l1 = new List<string> { "Hola", "Don", "Pepito", "Hola", "Don", "José" }, l2 = new List<string>();

                        EscribeListaString(l1);
                        OrdenaPalabrasLista2(l1);
                        EscribeListaString(l1);

                        Console.WriteLine();

                        EscribeListaString(l2);
                        OrdenaPalabrasLista2(l2);
                        EscribeListaString(l2);
                    }
                    break;
                case 11:
                    {
                        int[] a1 = { 1, 2, 3, 7, 8, 9 }, a2 = { 4, 5, 6 };

                        EscribeArrays(a1);
                        EscribeArrays(a2);

                        Console.WriteLine();

                        EscribeArrays(InsertaArrayEnArrayPro(a1, 3, a2));
                        EscribeArrays(InsertaArrayEnArrayPro(a1, a1.Length - 1, a2));
                        EscribeArrays(InsertaArrayEnArrayPro(a1, 0, a2));
                    }
                    break;
                case 12:
                    {

                    }
                    break;
                case 13:
                    {

                    }
                    break;
                case 14:
                    {

                    }
                    break;
                case 15:
                    {

                    }
                    break;
                case 16:
                    {

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
            Console.WriteLine(" 1 - LeeLista");
            Console.WriteLine(" 2 - LeeListaN");
            Console.WriteLine(" 3 - EscribeLista");
            Console.WriteLine(" 4 - EliminaNegativos");
            Console.WriteLine(" 5 - ClasificaNumeros");
            Console.WriteLine(" 6 - EliminaRepetidos");
            Console.WriteLine(" 7 - OrdenaListaSeleccion");
            Console.WriteLine(" 8 - OrdenaListaInsercion");
            Console.WriteLine(" 9 - OrdenaListaPalabras");
            Console.WriteLine("10 - OrdenaListaPalabras2");
            Console.WriteLine("11 - InsertaArrayEnArrayPro");
            Console.WriteLine("12 - SorteoBonoloto");
            Console.WriteLine("13 - EliminaRepetidos");
            Console.WriteLine("14 - UnionListas");
            Console.WriteLine("15 - InterseccionListas");
            Console.WriteLine("16 - DesordenaLista");
            Console.WriteLine("17 - ModaLista");
            Console.WriteLine("18 - PuntuacionesTrampolin");
            Console.WriteLine(" 0 - Salir");
            Console.Write("Introduzca una opción: ");
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
        static bool EsNumero(string s)
        {
            bool result = true;
            string s2 = s.Trim();

            for (int i = 0; i < s2.Length; i++)
            {
                if (!char.IsNumber(s2[i]))
                {
                    result = false;
                    i = s2.Length;
                }
            }

            return result;
        }
        static void EscribeListCutre(List<int> l)
        {
            Console.Write("< ");

            for (int i = 0; i < l.Count; i++)//Count es el número de elementos actual. COUNT ES DINÁMICO
            {
                Console.Write(l[i] + " ");
            }

            Console.Write(">");
            Console.WriteLine();
        }
        static void EscribeListaString (List<string> l)
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
        #endregion
        #region Ejercicios
        static void LeeLista (List<int> l)
        {
            // Escribe la función LeeLista que va leyendo enteros desde el teclado y los va metiendo en una lista.La función ira leyendo valores hasta que escribamos un - 1.La lista la pasamos por parámetro.
            string input = Console.ReadLine();
            int current;

            while (EsNumero(input) && input != "-1")
            {
                current = int.Parse(input);
                l.Add(current);
                input = Console.ReadLine();
            }
        }
        static void LeeListaN (List<int> l, int max)
        {
            //Escribe la función LeeListaN que lee desde el teclado el número de enteros que le digamos. Para ello, le pasaremos dos parámetros: la lista y un entero.
            string input;
            int current;

            for (int i = 0; i < max; i++)
            {
                input = Console.ReadLine();

                if (EsNumero(input))
                {
                    current = int.Parse(input);
                    l.Add(current);
                }
                else
                {
                    i--;
                    Console.WriteLine("Eso no era un número, vuelva a introducirlo.");
                }          
            }
        }
        static void EscribeLista (List<int> l)
        {
            //Escribe la función EscribeLista a la que le pasas una lista y te escribe su contenido por pantalla. Para diferenciarla de los arrays, usaremos angulos para delimitarla.
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
        static void EliminaNegativos (List<int> l)
        {
            //Escribe la función EliminaNegativos que elimine todos los números negativos de una lista de enteros.
            List<int> l2 = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] >= 0)
                {
                    l2.Add(l[i]);
                }
            }

            l.Clear();
            l.AddRange(l2);
        }
        static void EliminaNegativosPredicado (List<int> l)
        {
            List<int> filtered = l.FindAll(item => item >= 0);
            l.Clear();
            l.AddRange(filtered);
        }
        static void ClasificaNumeros (List<int> l1, List<int> l2, List<int> l3)
        {
            // Escribe la función ClasificaNumeros a la que le pasamos tres listas. La primera contiene un montón de números positivos y negativos.Habrá que copiar los positivos en la primera lista y los negativos en la segunda lista, y después ordenar las dos listas.

            for (int i = 0; i < l1.Count; i++)
            {
                if (l1[i] >= 0)
                {
                    l2.Add(l1[i]);
                }
                else
                {
                    l3.Add(l1[i]);
                }
            }

            l2.Sort();
            l3.Sort();
        }
        static void EliminaRepetidos (List<int> l)
        {
            //Escribe la función EliminaRepetidos a la que le pasas una lista y te elimina los elementos repetidos, dejando sólo uno de cada(ej.: < 1, 2, 3, 1 > = < 1, 2, 3 >). La forma más fácil es ir copiando de una lista a otra sólo los elementos que no estén ya introducidos(p.ej., usando Contains).

            List<int> l2 = new List<int>();

            for (int i = 0; i < l.Count; i++)
            {
                if (!l2.Contains(l[i]))
                {
                    l2.Add(l[i]);
                }
            }

            l.Clear();
            l.AddRange(l2);
        }
        static void OrdenaListaSeleccion (List<int> l)
        {
            /*
            Escribe la función OrdenaListaSeleccion a la que le pasas una lista de enteros desordenada y te la ordena mediante el algoritmo de selección. 
            La ordenación por selección funciona de la siguiente forma:
            - Buscamos el elemento más pequeño de nuestra lista.
            - Lo metemos en otra lista resultado.
            - Lo eliminamos de nuestra lista.
            - Repetimos hasta que nuestra lista se quede vacía y todos los elementos hayan pasado a la lista resultado en orden. 
            */
            
            //ESTAMOS USANDO EL LINQ PARA TENER MIN Y MAX
            List<int> result = new List<int>();

            while (l.Count > 0)
            {
                result.Add(l.Min());
                l.Remove(l.Min());
            }

            l.AddRange(result);
        }
        static void OrdenaListaInsercion (List<int> l)
        {
            /*
             Escribe la función OrdenaListaInsercion a la que le pasas una lista de enteros desordenada y te la ordena mediante el algoritmo de inserción.
            La ordenación por inserción funciona de la siguiente forma:
            - Cogemos cada elemento en orden de nuestra lista.
            - A la hora de meterlo en la lista resultado lo metemos de manera que la lista resultado se quede ordenada. Para ello, vamos pasando por la lista resultado hasta que encontremos un valor mayor e insertamos nuestro número delante.
            - Repetimos hasta que nuestra lista se quede vacía y todos los elementos hayan pasado a la lista resultado en orden
             */
            List<int> result = new List<int>();
            int j = 0;

            if (l.Count > 0)
            {

                result.Add(l[0]);

                for (int i = 1; i < l.Count; i++)
                {
                    j = 0;
                    while (j < result.Count && l[i] > result[j])
                    {
                        j++;
                    }
                    result.Insert(j, l[i]);
                }

                l.Clear();
                l.AddRange(result);
            }
        }
        static void OrdenaPalabrasLista (List<string> l)
        {
            //Escribe la función OrdenaListaPalabras a la que le pasas una lista de cadenas que contiene palabras y te las ordena alfabéticamente.

            List<string> result = new List<string>();

            while (l.Count > 0)
            {
                result.Add(l.Min());
                l.Remove(l.Min());
            }

            l.AddRange(result);
        }
        static string ShortestStringFromList (List<string> l)
        {
            string result;
            
            if (l.Count > 0)
            {
                result = l[0];
                
                for (int i = 1; i < l.Count; i++)
                {
                    if (result.Length > l[i].Length)
                    {
                        result = l[i];
                    }
                }
            }
            else
            {
                result = "ERROR: La lista está vacía.";
            }
            
            return result;
        }
        static void OrdenaPalabrasLista2 (List<string> l)
        {
            //Escribe la función OrdenaListaPalabras2 a la que le pasas una lista de cadenas que contiene palabras y te las ordena por tamaño(la más pequeña el principio).

            List<string> result = new List<string>();

            while (l.Count > 0)
            {
                result.Add(ShortestStringFromList(l));
                l.Remove(ShortestStringFromList(l));
            }

            l.AddRange(result);
        }
        static int[] InsertaArrayEnArrayPro (int[] a1, int position, int[] a2)
        {
            //Escribe la función InsertaArrayEnArrayPro a la que le pasamos tres parámetros: un array de enteros, una posición en ese array y otro array de enteros. La función insertará en el primer array, desde la posición indicada, todo el contenido del segundo array, y nos devolverá otro array con el resultado. Para ello, usaremos una lista como paso intermedio: copiamos el array a la lista, realizamos la inserción en la lista y luego convertiremos la lista en un array y lo devolveremos.

            int[] result;
            List<int> l = new List<int>();

            if (position < a1.Length)
            {
                l.AddRange(a1);
                l.InsertRange(position, a2);

                result = l.ToArray();

            }
            else
            {
                Console.WriteLine("ERROR: Tamaño del primer array insuficiente.");
                result = new int[0];
            }

            return result;
        }
        static List<int> SorteoBonoloto ()
        {
            //Escribe la función SorteoBonoloto que nos da los 6 números que van a tocar en el próximo sorteo. Para ello, meteremos en una lista los 49 números, elegiremos una posición al azar, guardaremos el número en otra lista y lo eliminaremos de la primera (para que no pueda volver a salir). Al terminar de sortear los 6 números, devolveremos una lista que contenga el resultado.
            List<int> result = new List<int>();

            
            
            return result;
        }
        #endregion
    }
}
