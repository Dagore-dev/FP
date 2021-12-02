using System;

namespace EntregaCadenas
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
                        string s = "Hola, me llamo David.";

                        Console.WriteLine($"La cadena \"{s}\" tiene {NumeroEspacios(s)} espacios.");
                    }
                    break;
                case 2:
                    {
                        string s = "Hola, me llamo David.";

                        Console.WriteLine($"La cadena \"{s}\" tiene {NumeroVocales(s)} vocales.");
                    }
                    break;
                case 3:
                    {
                        string s = "Sara baras";
                        string s2 = "A Bali su flan anal fusilaba";
                        string s3 = "Esto no es un palíndromo";

                        Console.WriteLine(s);
                        Console.WriteLine($"{EsPalindromo(s)}");

                        Console.WriteLine();

                        Console.WriteLine(s2);
                        Console.WriteLine($"{EsPalindromo(s2)}");
                        
                        Console.WriteLine();

                        Console.WriteLine(s3);
                        Console.WriteLine($"{EsPalindromo(s3)}");
                    }
                    break;
                case 4:
                    {
                        string s = "Hola";

                        Console.WriteLine($"\"{s}\" contiene 'o': {Contiene(s, 'o')}");
                        Console.WriteLine($"\"{s}\" contiene 'j': {Contiene(s, 'j')}");
                    }
                    break;
                case 5:
                    {
                        char c = 'a';
                        int n1 = 5, n2 = 3;

                        Console.WriteLine($"'{c}' {n1} veces : {RepiteCaracter(c, n1)}");
                        Console.WriteLine($"'{c}' {n2} veces : {RepiteCaracter(c, n2)}");
                    }
                    break;
                case 6:
                    {
                        string s = "    ola     k   ase    .";
                        Console.WriteLine(s);
                        Console.WriteLine(QuitaEspacios(s));
                    }
                    break;
                case 7:
                    {
                        string s = "    ola     k   ase    .";
                        Console.WriteLine(s);
                        Console.WriteLine(QuitaespaciosTrim(s));
                    }
                    break;
                case 8:
                    {
                        string s = "abcabcabc";
                        Console.WriteLine(s);
                        Console.WriteLine($"Sustituye 'a' por 'd' :{SustituyeCaracter(s, 'a', 'd')}");
                    }
                    break;
                case 9:
                    {
                        string s = " ¡  Esto es una frase   cualquiera !  ";
                        Console.WriteLine(s);
                        Console.WriteLine(CuentaPalabras(s));
                    }
                    break;
                case 10:
                    {
                        string s = "56846845647";
                        string s2 = "45645fhgg4846";

                        Console.WriteLine($"{s} es número: {EsNumero(s)}");
                        Console.WriteLine($"{s2} es número: {EsNumero(s2)}");
                    }
                    break;
                case 11:
                    {
                        string s = "abababababaababab";
                        char c = 'a';

                        Console.WriteLine($"Elimina '{c}' del string \"{s}\", obteniendo: {QuitaCaracter(s, c)}");
                    }
                    break;
                case 12:
                    {
                        string s = "¿Qué tal? ¿Cómo estás?";

                        Console.WriteLine(s);
                        Console.WriteLine(QuitaAcentos(s));
                    }
                    break;
                case 13:
                    {
                        string s = "Hola, qué tal";

                        Console.WriteLine(s);
                        Console.WriteLine(InvierteCadena(s));
                    }
                    break;
                case 14:
                    {
                        string s = "Hola, cómo estás?";
                        char c = ' ';
                        Console.WriteLine(s);
                        Console.WriteLine($"Tiene {VecesCaracter(s, c)} caracteres '{c}'.");
                    }
                    break;
                case 15:
                    {
                        string s = "Me llamo David porque mi padre se llamaba David, y mi tío también se llama David";
                        string word = "David";

                        Console.WriteLine(s);
                        Console.WriteLine($"{word} aparece {VecesPalabra(s, word)} veces.");
                    }
                    break;
                case 16:
                    {
                        string s1 = "¿Hola, qué tal?", s2 = "hola, qué tal", s3 = "  hola, qué tal";

                        Console.WriteLine($"{s1} --> {MayusculaPrimera(s1)}");
                        Console.WriteLine($"{s2} --> {MayusculaPrimera(s2)}");
                        Console.WriteLine($"{s3} --> {MayusculaPrimera(s3)}");
                    }
                    break;
                case 17:
                    {
                        string s = "ABBA BAAB ABBA BAAB ABBA BAAB", s2 = "Hola,  ¿Qué tal     David  ? ¿Qué es de ti David?";

                        Console.WriteLine($"{s} --> {SustituyePalabra(s, "ABBA", "BAAB")}");
                        Console.WriteLine($"{s} --> {SustituyePalabra(s, "BAAB", "ABBA")}");
                        Console.WriteLine($"{s2} --> {SustituyePalabra(s2, "David", "Javi")}");
                    }
                    break;
                case 18:
                    {
                        string s = "Hola, ¿Qué tal?", s2 = "hola adios hola adios";

                        Console.WriteLine($"{s} --> {InviertePalabras(s)}");
                        Console.WriteLine($"{s2} --> {InviertePalabras(s2)}");
                    }
                    break;
                case 19:
                    {
                        string s = "Hola, buenas tardes. Mi nombre es David. Hola, buenas tardes. Mi nombre es Juan.";
                        
                        Console.WriteLine(s);
                        Console.WriteLine();
                        Console.WriteLine(MarcaSubCadena(s, "Hola, buenas tardes"));
                    }
                    break;
                case 20:
                    {
                        string s = " ¡  Esto es una frase   cualquiera !  ";

                        Console.WriteLine(s);
                        Console.WriteLine(QuitaEspaciosSobrantes(s));
                    }
                    break;
                default:
                    break;
            }

        }
        static void ShowMenu ()
        {
            Console.WriteLine(" 1 - NumeroEspacios");
            Console.WriteLine(" 2 - NumeroVocales");
            Console.WriteLine(" 3 - EsPalindromo");
            Console.WriteLine(" 4 - Contiene");
            Console.WriteLine(" 5 - RepiteCaracter");
            Console.WriteLine(" 6 - QuitaEspacios");
            Console.WriteLine(" 7 - QuitaEspaciosTrim");
            Console.WriteLine(" 8 - SustituyeCaracter");
            Console.WriteLine(" 9 - CuentaPalabras");
            Console.WriteLine("10 - EsNumero");
            Console.WriteLine("11 - QuitaCaracter");
            Console.WriteLine("12 - QuitaAcentos");
            Console.WriteLine("13 - InvierteCadena");
            Console.WriteLine("14 - VecesCaracter");
            Console.WriteLine("15 - VecesPalabra");
            Console.WriteLine("16 - MayusculasPrimera");
            Console.WriteLine("17 - SustituyePalabra");
            Console.WriteLine("18 - InviertePalabras");
            Console.WriteLine("19 - MarcaSubCadena");
            Console.WriteLine("20 - QuitaEspaciosSobrantes");
            Console.WriteLine(" 0 - Salir");
        }
        static string RemoveWhitespaces (string s)
        {
            if (s.IndexOf(' ') == -1)
            {
                return s;
            }

            return RemoveWhitespaces(s.Remove(s.IndexOf(' '), 1));
        }
        static int NumeroEspacios (string s)
        {
            //Escribe la función “NumeroEspacios” a la que le pasamos una cadena y nos devuelve el número de espacios que contiene esa cadena(tanto al principio como al final e intercalados).

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    result++;
                }
            }

            return result;
        }
        static int NumeroVocales (string s)
        {
            //Escribe la función “NumeroVocales” a la que le pasamos una cadena y nos devuelve el número de vocales que hay en la cadena.

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if ("aeiou".Contains(s[i]))
                {
                    result++;
                }
            }

            return result;
        }
        static bool EsPalindromo (string s)
        {
            //Escribe la función “EsPalindromo” a la que le pasamos una cadena y nos dice si la cadena es un palíndromo(true) o no(false). Un palíndromo es una palabra o frase que se lee igual al revés que al derecho.

            string test = RemoveWhitespaces(s).ToLower();

            Console.WriteLine(test);

            bool result = true;
            int i = 0, j = test.Length - 1;

            while (i < j)
            {
                if (test[i] == test[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    result = false;
                    i = j;
                }
            }

            return result;
        }
        static bool Contiene (string s, char c)
        {
            //Escribe la función “Contiene” a la que le pasamos una cadena y un carácter por parámetro y nos dice si el carácter aparece en la cadena o no.Es igual que la función Contains.Evidentemente, no podéis usar esta función para hacer la vuestra.

            return s.IndexOf(c) != -1 ? true : false;
        }
        static string RepiteCaracter (char c, int n)
        {
            // Escribe la función “RepiteCaracter” a la que le pasamos dos parámetros: un carácter y un entero. La función nos devolverá una cadena que contendrá el carácter repetido tantas veces como indique el entero. Ej.: RepiteCaracter(‘A’, 5) = “AAAAA”. No se pueden utilizar PadLeft ni PadRight.
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += c;
            }

            return result;
        }
        static string QuitaEspacios (string s)
        {
            // Escribe la función “QuitaEspacios” a la que le pasamos una cadena y nos devuelve la misma cadena, pero con todos los espacios quitados(tanto los del principio como los del final como los intermedios).

            if (s.IndexOf(' ') == -1)
            {
                return s;
            }

            return RemoveWhitespaces(s.Remove(s.IndexOf(' '), 1));
        }
        static string QuitaespaciosTrim (string s)
        {
            //Escribe la función “QuitaEspaciosTrim” a la que le pasamos una cadena y nos devuelve otra cadena igual que la primera en la que se han eliminado los espacios que haya al principio y al final. No se puede utilizar Trim (ni sus variantes).

            int i = 0, counter = 0;
            string result = s;
            
            //Elimina los espacios al principio
            while (i < s.Length)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    counter++;
                    i++;
                }
                else
                {
                    result = s.Remove(0, counter);
                    i = s.Length;
                }
            }
            
            //Reset de variables
            counter = 0;
            i = result.Length - 1;

            //Elimina espacios del final
            while (i >= 0)
            {
                if (char.IsWhiteSpace(result[i]))
                {
                    counter++;
                    i--;
                }
                else
                {
                    result = result.Remove(i, counter);
                    i = -1;
                }
            }

            return result;
        }
        static string SustituyeCaracter (string s, char c1, char c2)
        {
            //Escribe la función “SustituyeCaracter” a la que le pasamos una cadena, un carácter y otro carácter y nos devuelve otra cadena igual que la primera en la que se ha sustituido el primer carácter por el segundo carácter. Ojo, en las cadenas, al contrario que en los arrays, no podemos modificar directamente un valor al estilo de cadena[2] = ‘A’ (los corchetes sólo sirven para leer el valor, no para modificarlo).
            
            string temp;

            if (!s.Contains(c1))
            {
                return s;
            }

            temp = s.Substring(0, s.IndexOf(c1)) + c2 + s.Substring(s.IndexOf(c1) + 1);

            return SustituyeCaracter(temp, c1, c2);
        }
        static string RemoveExtraWhitespaces(string s)
        {
            if (s.IndexOf("  ") == -1)
            {
                return s;
            }

            return RemoveExtraWhitespaces(s.Remove(s.IndexOf("  "), 1));
        }
        static int CuentaPalabras (string s)
        {
            //Escribe la función “CuentaPalabras” a la que le pasamos una cadena que contiene una frase y nos devuelve el número de palabras que hay en la misma.
            string s2 = "";

            //Filtro para quedarte solo con letras y espacios en blanco
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) || char.IsWhiteSpace(s[i]))
                {
                    s2 += s[i];
                }
            }

            s2 = RemoveExtraWhitespaces(s2).Trim();

            return s2.Split(' ').Length;
        }
        static bool EsNumero (string s)
        {
            //Escribe la función “EsNumero”, a la que le pasamos una cadena y nos dice si está formada enteramente por números o no. Esta función es muy interesante para evitarnos errores a la hora de hacer un Console.ReadLine.Si queremos leer un número del teclado, lo correcto es leerlo con un Console.ReadLine como si fuera una cadena, después comprobar con la función EsNumero si está formado completamente por dígitos y después hacerle un int.Parse para pasarlo a un entero.Así no peta tanto

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
        static string QuitaCaracter (string s, char c)
        {
            //Escribe la función “QuitaCaracter” a la que le pasamos una cadena y un carácter y nos devuelve la cadena, pero con todas las ocurrencias de ese carácter quitadas.

            if (s.IndexOf(c) == -1)
            {
                return s;
            }

            return QuitaCaracter(s.Remove(s.IndexOf(c), 1), c);
        }
        static string QuitaAcentos (string s)
        {
            //Escribe la función “QuitaAcentos” a la que le pasas una cadena con caracteres acentuados y te devuelve la cadena con los acentos quitados(esto se hace para algunos programas que no se enteran de los acentos).

            string acentos = "áéióúàèìòùâêîôûäëïöüÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜ", sinAcentos = "aeiouaeiouaeiouaeiouAEIOUAEIOUAEIOUAEIOU", result = s;
            int position = -1;

            for (int i = 0; i < result.Length; i++)
            {
                position = acentos.IndexOf(result[i]);

                if ( position != -1)
                {
                    result = result.Replace(result[i], sinAcentos[position]);
                }
            }

            return result;
        }
        static string InvierteCadena (string s)
        {
            //Escribe la función “InvierteCadena” a la que le pasamos una cadena y nos la devuelve invertida(de detrás para delante, vamos).

            string result = "";

            for (int i = s.Length - 1; i > -1 ; i--)
            {
                result += s[i];
            }

            return result;
        }
        static int VecesCaracter (string s, char c)
        {
            //Escribe la función “VecesCaracter” a la que le pasamos una cadena y un carácter y nos dice cuántas veces se repite ese carácter.

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
        static int VecesPalabra (string s, string word, int counter = 0)
        {
            //Escribe la función “VecesPalabra” a la que le pasamos una cadena y una palabra (otra cadena) y nos dice cuántas veces se repite ese palabra en la cadena.

            int result = 0;
            string s2 = "";
            string[] a;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) || char.IsWhiteSpace(s[i]))
                {
                    s2 += s[i];
                }
            }

            s2 = RemoveExtraWhitespaces(s2).Trim();

            a = s2.Split(' ');

            foreach (string item in a)
            {
                if (item.Equals(word))
                {
                    result++;
                }
            }

            return result;
        }
        static string MayusculaPrimera (string s)
        {
            //Escribe la función “MayusculasPrimera” a la que le pasas una cadena y te devuelve la cadena con la primera letra de cada palabra puesta en mayúsculas.
            string result = "", minus = "qwertyuiopasdfghjklñzxcvbnm", mayus = "QWERTYUIOPASDFGHJKLÑZXCVBNM";

            if (char.IsLetter(s[0]))
            {
                result += mayus[minus.IndexOf(s[0])];
            }
            else
            {
                result += s[0];
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) && !char.IsLetter(s[i - 1]) && minus.Contains(s[i]))
                {
                    result += mayus[minus.IndexOf(s[i])];
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }
        static string SustituyePalabra (string s, string word1, string word2)
        {
            //Escribe la función “SustituyePalabra” a la que le pasamos una cadena y dos palabras y nos devuelve otra cadena en la que haya que sustituir la primera por la segunda.

            string result = s;
            string[] words = RemoveExtraWhitespaces(OnlyLettersAndSpaces(s)).Split(' ');
            int position = -1;

            for (int i = 0; i < words.Length; i++)
            {
                position = result.IndexOf(words[i]);

                if (position != -1)
                {
                    result = result.Substring(0, position) + (words[i].Equals(word1) ? word2 : words[i]) + result.Substring(position + words[i].Length);
                }
            }

            return result;
        }
        static string OnlyLettersAndSpaces (string s)
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
        static string InviertePalabras (string s)
        {
            //Escribe una función “InviertePalabras” a la que la pasamos una cadena y nos devuelve otra en la que están invertidas todas las palabras (no la cadena entera, sino cada palabra independientemente).

            string result = s;
            string[] words = RemoveExtraWhitespaces(OnlyLettersAndSpaces(s)).Split();
            int position = -1;
            
            for (int i = 0; i < words.Length; i++)
            {
                position = result.IndexOf(words[i]);

                if (position != -1)
                {
                    result = result.Substring(0, position) + InvierteCadena(words[i]) + result.Substring(position + words[i].Length);
                }

            }

            return result;
        }
        static string MarcaSubCadena (string s1, string s2)
        {
            //Escribe una función “MarcaSubCadena” a la que le pasamos dos cadenas y nos busca la segunda cadena dentro de la primera. Nos devolverá otra cadena igual que la primera, pero en la que se cambiará la primera letra de cada vez que aparece la subcadena por un asterisco.

            if (s1.IndexOf(s2) == -1)
            {
                return s1;
            }

            return MarcaSubCadena(s1.Substring(0, s1.IndexOf(s2)) + '*' + s1.Substring(s1.IndexOf(s2) + 1), s2);
        }
        static string QuitaEspaciosSobrantes (string s)
        {
            //Escribe la función “QuitaEspaciosSobrantes” a la que le pasamos una cadena por parámetro y nos devuelve otra.La cadena que le pasamos podrá tener espacios delante y detrás, además de espacios entre las palabras. Para obtener la cadena resultado, tendremos que quitar los espacios de delante y de detrás y si entre dos palabras hay más de un espacio, deberemos dejar sólo uno. Ej.: “~~~Mi~~mamá~~~~me~mima~~” -> “Mi~mamá~me~mima” (~ = espacio)
            if (s.IndexOf("  ") == -1)
            {
                return s;
            }

            return RemoveExtraWhitespaces(s.Remove(s.IndexOf("  "), 1));
        }
    }
}
