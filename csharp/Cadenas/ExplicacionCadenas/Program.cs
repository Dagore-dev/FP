using System;
using System.Text;

namespace ExplicacionCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cadena", s2, s3 = "2", s4;
            char[] c = { 'c', 'a', 'd', 'e', 'n', 'a' };

            //Un string es muy similar a una array de caracteres.

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.WriteLine();

            for (int j = 0; j < c.Length; j++)
            {
                Console.WriteLine(c[j]);
            }

            Console.WriteLine();

            //La asignación en los strings funciona como en los otros tipos primitivos, NO como en los arrays:
            
            s2 = s;//s2 = "cadena" y apunta a la misma dirección de memoria que s.

            s += "!";

            Console.WriteLine($"s ahora es igual a \"{s}\", mientras que s2 sigue valiendo \"{s2}\".");

            s3 += 2;//El operador + al tener un entero por un lado y una cadena por otro hace el cast al número y concatena.

            Console.WriteLine(s3);

            #region StringBuilder
            //String builder: Para hacer concatenaciones intensivas.

            StringBuilder sb = new StringBuilder();

            sb.Append("C");

            for (int i = 1; i < s2.Length; i++)
            {
                sb.Append(s2[i]);
            }

            s4 = sb.ToString();

            Console.WriteLine(s4);

            #endregion

            #region Métodos de cadenas
            //Métodos de cadenas

            //*.Contains

            string patata = "patata";
            patata.Contains('p');//Devuelve True.

            //*.EndsWith

            string unaWeb = "www.google.com";
            unaWeb.EndsWith(".com");//Devuelve True.

            //*.StartWith

            unaWeb.StartsWith("www.");//Devuelve True.

            //*.IndexOf

            string pepino = "pepino";
            pepino.IndexOf('i');//Devuelve 3.
            pepino.IndexOf('p');//Devuelve 1.
            pepino.IndexOf('z');//Devuelve -1 porque no lo encuentra.

            //*.LastIndexOf

            pepino.LastIndexOf('p');//Devuelve 2.
            pepino.LastIndexOf('f');//Devuelve -1.

            string rojo = "El rojo es un color bonito.";
            int position = rojo.IndexOf("es");

            rojo.IndexOf('o', position);//Devuelve 15.La posición de la primera 'o' después de que empiece el substring "es".

            //*.Insert

            rojo = rojo.Insert(19, " cálido y");//rojo = "El rojo es un color cálido y bonito."

            //*.Remove

            rojo = rojo.Remove(19, 9);//rojo = "El rojo es un color bonito."

            //*.Substring

            string camaleon = "camaleón";
            camaleon.Substring(0, 4);//Devuelve "cama".
            camaleon.Substring(4);//Devuelve "león".

            //*.Replace

            camaleon.Replace('c', 'C');//Devuelve "Camaleón". MUCHO CUIDADO, REEMPLAZA TODO Y HACE SOLO UNA PASADA.

            //*.Trim

            string espacios = "           Hola!      ";
            espacios.Trim();//Devuelve "Hola!".

            //*.TrimStart

            espacios.TrimStart();//Devuelve "Hola!      ".

            //*.TrimEnd

            espacios.TrimEnd();//Devuelve "           Hola!".

            //*.ToLower *.ToUpper

            string hola = "HoLa";
            hola.ToLower();//"hola"
            hola.ToUpper();//"HOLA"

            //*.PadLeft: Completa con espacios a la izquierda hasta el valor que se le pasa. *.PadRight: Lo mismo pero a la derecha.

            Console.WriteLine("232,57 $".PadLeft(12));
            Console.WriteLine("1,35 $".PadLeft(12));
            Console.WriteLine("94.584,48 $".PadLeft(12));
            Console.WriteLine("45,00 $".PadLeft(12));

            //Maniobras con For. Cambio las 'a' que encuentro por un número que se va incrementando.

            int counter = 0;
            string ejemplo = "patata", vacia = "";

            for (int i = 0; i < ejemplo.Length; i++)
            {
                if (ejemplo[i] != 'a')
                {
                    vacia += ejemplo[i];
                }
                else
                {
                    vacia += counter;
                    counter++;
                }
            }

            //*.split

            string pass = "hola don pepito hola don jose";

            string[] passArr = pass.Split(' ');//passArr = {"hola", "don", "pepito", "hola", "don", "jose"}

            //String.Join()

            String.Join(' ', passArr);//Devuelve "hola don pepito hola don jose".
            String.Join('-', passArr);//Devuelve "hola-don-pepito-hola-don-jose".

            #endregion
        }
    }
}
