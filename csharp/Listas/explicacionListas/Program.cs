using System;
using System.Collections.Generic;

namespace explicacionListas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                LISTAS
            
                Estructura de datos lineal y dinámica. Es decir, su principal diferencia con los arrays es que no tienen un tamaño establecido. La listas pueden implementarse como una interfaz de arrays o se pueden implementar como listas enlazadas donde cada nodo contiene un valor y una referencia al siguiente nodo. Estas últimas se recorren mucho peor que los arrays, las operaciones de inserción y elimininación son más eficientes.
            */

            List<int> l = new List<int>();//List<tipoDeDato> = new List<tipoDeDato>()
            EscribeList(l);
            l.Add(5);//Añade un elemento al final de la lista
            EscribeList(l);
            l[0] = 10;
            EscribeList(l);
            List<int> l2 = new List<int> { 1, 2, 3, 4, 5 };//Lista con algunos valores iniciales
            EscribeList(l2);
            List<int> l3 = new List<int>(l);//Una lista que es copia de l, también admite arrays.
            EscribeList(l3);

            Console.WriteLine();
            Console.WriteLine("Modificamos una lista con la función MeteLista110.");
            List<int> l4 = new List<int>();
            EscribeList(l4);
            MeteLista110(l4);
            EscribeList(l4);

            //Insert => Añade un elemento en la posición definida
            l.Insert(0, -99);//Inserta -99 en la posición 0, la posición debe exitir previamente.

            //Addrange() y InsertRange() permiten agregar una colección a la lista, puede ser una array.
            Console.WriteLine();
            Console.WriteLine("AddRange e InsertRange");
            EscribeList(l);
            l.AddRange(l4);
            EscribeList(l);
            l.InsertRange(0, l4);
            EscribeList(l);

            Console.WriteLine();
            Console.WriteLine("Borrar cosas");

            //RemoveAt => Borra la posición indicada.
            l.RemoveAt(0);
            //Remove => Borra el primer valor igual al que le pasas.
            l.Remove(10);
            EscribeList(l);
            //RemoveRange => Posición donde empieza y número de elementos a eliminar.
            l.RemoveRange(0, 3);
            EscribeList(l);
            //RemoveAll
            l.RemoveAll(item => item % 2 == 0);//Elimina todos los pares.
            EscribeList(l);
            //Clear => Limpia todos los elementos de la lista.
            l.Clear();

            Console.WriteLine();
            Console.WriteLine("Buscar cosas");
            MeteLista110(l);
            
            //Contains e IndexOf
            if (l.Contains(10))
            {
                Console.WriteLine($"Lo tenemos en la posición {l.IndexOf(10)}");
            }

            //La familia Find
            EscribeList(l);
            Console.WriteLine("Find con item => item % 2 != 0 --> " + l.Find(item => item % 2 != 0));//Devuelve el primer elemento que cumple la condición.
            Console.WriteLine("FindAll");
            EscribeList(l.FindAll(item => item % 2 != 0));//Devuelve una lista con los elementos que cumplen la condición.
            Console.WriteLine("FindIndex con item => item % 2 != 0 --> " + l.FindIndex(item => item % 2 != 0));//Devuelve la posición del primer elemento que cumple la condición.

            Console.WriteLine();
            Console.WriteLine("Otras funciones");

            //Otras funciones
            l.Reverse();
            EscribeList(l);
            l.Sort();
            EscribeList(l);
            int[] a = l.ToArray();
            int[] b = new int[5];
            l.CopyTo(5, b, 0, 5);

        }
        static void MeteLista110 (List<int> l)
        {
            for (int i = 1; i <=10; i++)
            {
                l.Add(i);
            }
        }
        static void EscribeList (List<int> l)
        {
            Console.Write("< ");

            for (int i = 0; i < l.Count; i++)//Count es el número de elementos actual. COUNT ES DINÁMICO
            {
                Console.Write(l[i] +  " ");
            }

            Console.Write(">");
            Console.WriteLine();
        }
    }
}
