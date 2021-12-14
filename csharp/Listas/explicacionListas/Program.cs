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
            l.Add(5);
            EscribeList(l);
            l[0] = 10;
            EscribeList(l);
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
