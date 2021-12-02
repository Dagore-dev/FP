using System;

namespace CadenasAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            ShowMenu();

            Console.Write("Introduce la opción escogida: ");
            option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    {
                        string s = "Gómez Redondo David Ortíz Fernandez Javier Gonzalez Lopez Luis Perez Perez Pepito";

                        EscribeNombres(s);
                    }
                    break;
                case 2:
                    {
                        string s = "Hola, qué tal";
                        char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                        Console.WriteLine(s);
                        EscribeArraysChar(abc);
                        EscribeArrays(CuentaLetras(s));
                    }
                    break;
                case 3:
                    {
                        string s = "Hola, mi nombre es David. Tengo 26 años ¿Y tú?";

                        Console.WriteLine(MayusculasMinusculas(s, 4));
                    }
                    break;
                case 4:
                    {

                    }
                    break;
                case 5:
                    {

                    }
                    break;
                case 6:
                    {

                    }
                    break;
                case 7:
                    {

                    }
                    break;
                case 8:
                    {

                    }
                    break;
                case 9:
                    {

                    }
                    break;
                case 10:
                    {

                    }
                    break;
                case 11:
                    {

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
                default:
                    break;
            }
        }
        static void ShowMenu ()
        {
            Console.WriteLine(" 1 - EscribeNombres");
            Console.WriteLine(" 2 - CuentaLetras");
            Console.WriteLine(" 3 - MayusculasMinusculas");
            Console.WriteLine(" 4 - EliminaTags");
            Console.WriteLine(" 5 - OrdenaPalabrasComas");
            Console.WriteLine(" 6 - AcentosHTML");
            Console.WriteLine(" 7 - PalabrasMismaLetra");
            Console.WriteLine(" 8 - NumeroTexto99");
            Console.WriteLine(" 9 - LimpiaCadena");
            Console.WriteLine("10 - CompruebaEmail");
            Console.WriteLine("11 - PalabrasImpares");
            Console.WriteLine("12 - CuentaDiptongos");
            Console.WriteLine("13 - FiltraArrayPalabras");
            Console.WriteLine(" 0 - Salir");
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
        static void EscribeArraysChar(char[] a)
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
        static string QuitaAcentos(string s)
        {
            string acentos = "áéióúàèìòùâêîôûäëïöüÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜ", sinAcentos = "aeiouaeiouaeiouaeiouAEIOUAEIOUAEIOUAEIOU", result = s;
            int position = -1;

            for (int i = 0; i < result.Length; i++)
            {
                position = acentos.IndexOf(result[i]);

                if (position != -1)
                {
                    result = result.Replace(result[i], sinAcentos[position]);
                }
            }

            return result;
        }
        static string MayusculaPrimera(string s)
        {
            string result = "";

            if (char.IsLetter(s[0]))
            {
                result += char.ToUpper(s[0]);
            }
            else
            {
                result += s[0];
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) && !char.IsLetter(s[i - 1]))
                {
                    result += char.ToUpper(s[i]);
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }
        static void EscribeNombres (string s)
        {
            //Escribe la función EscribeNombres a la que le pasamos una cadena por parámetro y nos la escribe por la pantalla con el siguiente formato: la cadena contendrá varias palabras separadas por espacios, con el siguiente formato: “apellido1 apellido2 nombre apellido1 apellido2 nombre(…)” y deberemos escribirla por pantalla de la siguiente forma:
            /*
                nombre apellido1 apellido2
                nombre apellido1 apellido2
                (…) 
            */

            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i += 3)
            {
                Console.WriteLine($"{words[i]} {words[i + 1]} {words[i + 2]}");
            }
            //REVISAR!!!!!!
        }
        static int CuentaLetra (string s, char c)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    result++;
                }
            }

            return result;
        }
        static int[] CuentaLetras (string s)
        {
            //Escribe la función CuentaLetras a la que le pasas una cadena por parámetro y te devuelve un array de enteros.El tamaño del array será 5 y el contenido será el número de veces que aparecen las letras “a”, “b”, “c”, “d” y “e”, respectivamente, en la cadena que le hemos pasado(independientemente de si son mayúsculas o minúsculas). Ej.: cadena = “patata camaleón batata”, resultado:[8, 1, 1, 0, 1] Versión Pro: La función devolverá un array de enteros con 26 posiciones correspondientes a las 26 letras del abecedario.No uséis un switch (ni 26 ifs). Perdón, 27, se me olvidaba la eñe.

            string lowerS = QuitaAcentos(s.ToLower());
            char[] abc= { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] result = new int[abc.Length];

            for (int i = 0; i < abc.Length; i++)
            {
                result[i] = CuentaLetra(lowerS, abc[i]);
            }

            return result;
        }
        static string MayusculaFrase (string s)
        {
            string result = "";

            if (char.IsLetter(s[0]))
            {
                result += char.ToUpper(s[0]);
            }
            else
            {
                result += s[0];
            }

            //SIN FINALIZAR

            return result;
        }
        static string MayusculasMinusculas (string s, int option)
        {
            /*
                Escribe la función MayusculasMinusculas que recibirá dos parámetros: una cadena (que podrá contener saltos de línea) y un número entre 1 y 4. Dependiendo del número que le pasemos, la función nos devolverá otra cadena con las siguientes características:
                    • 1 = Todas las letras en minúsculas.
                    • 2 = Todas las letras en mayúsculas.
                    • 3 = La primera letra de cada palabra en mayúsculas y el resto en minúsculas.
                    • 4 = La primera letra de cada frase en mayúsculas y el resto en minúsculas (La primera letra y la primera tras cada punto).
                Escribir también un pequeño menú en el programa principal para probar las diferentes opciones. 
            */
            string result;

            switch (option)
            {
                case 1:
                    result = s.ToLower();
                    break;
                case 2:
                    result = s.ToUpper();
                    break;
                case 3:
                    result = MayusculaPrimera(s.ToLower());
                    break;
                case 4:
                    result = MayusculaFrase(s.ToLower());
                    break;
                default:
                    result = "ERROR: No seleccionó ninguna de las opciones disponibles.";
                    break;
            }

            return result;
        }
    }
}
