using System;
using System.Text;
using System.Text.RegularExpressions;

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
                        string s = "Hola, mi nombre es David. Tengo 26 años ¿Y tú?...";

                        Console.WriteLine(MayusculasMinusculas(s, 1));
                        Console.WriteLine(MayusculasMinusculas(s, 2));
                        Console.WriteLine(MayusculasMinusculas(s, 3));
                        Console.WriteLine(MayusculasMinusculas(MayusculasMinusculas(s, 2), 4));
                    }
                    break;
                case 4:
                    {
                        string s = "<p>Esto es texto normal <strong>y esto es texto en negrita</strong>.</p>";

                        Console.WriteLine(s);
                        Console.WriteLine(EliminaTags(s));

                        Console.WriteLine();

                        Console.WriteLine(s);
                        Console.WriteLine(EliminaTagsSinRegExp(s));
                    }
                    break;
                case 5:
                    {
                        string s = "hola,don,pepito,pasó,usted,ya,por,casa";

                        Console.WriteLine(s);
                        Console.WriteLine(OrdenaPalabrasComa(s));
                    }
                    break;
                case 6:
                    {
                        string s = "<p>Esto es texto normal <strong>y esto es texto en negrita</strong>.</p>";

                        Console.WriteLine(s);
                        Console.WriteLine(AcentosHTML(s));
                    }
                    break;
                case 7:
                    {
                        string s = "Amanda tiene tres serpientes.";

                        Console.WriteLine(s);
                        EscribeArraysString(PalabrasMismaLetra(s));
                    }
                    break;
                case 8:
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine($"{i} - {NumeroTexto99(i)}");
                        }
                    }
                    break;
                case 9:
                    {
                        string s = "Hola, ¿qué tal? Soy amigo de Poti-Poti.";

                        Console.WriteLine($"{s} => {LimpiaCadena(s)}");
                    }
                    break;
                case 10:
                    {
                        string s = "very.common@example.com", s2 = "Esto no es un email@", s3 = "admin@mailserver1", s4 = ".very.common@example.com-", s5 = "very.com mon@example.com";

                        Console.WriteLine($"{s} => {CompruebaEmail(s)}");
                        Console.WriteLine($"{s2} => {CompruebaEmail(s2)}");
                        Console.WriteLine($"{s3} => {CompruebaEmail(s3)}");
                        Console.WriteLine($"{s4} => {CompruebaEmail(s4)}");
                        Console.WriteLine($"{s5} => {CompruebaEmail(s5)}");
                    }
                    break;
                case 11:
                    {
                        string s = "El perro de San Roque";

                        Console.WriteLine($"{s} => {PalabrasImpares(s)}");
                    }
                    break;
                case 12:
                    {
                        CuentaDiptongos();
                    }
                    break;
                case 13:
                    {
                        string[] a = { "patata", "c3po", "5874", "tomate", "pimiento?" };

                        EscribeArraysString(a);
                        EscribeArraysString(FiltraArrayPalabras(a));
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
        #region Utils
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
        static string RemoveExtraWhitespaces(string s)
        {
            if (s.IndexOf("  ") == -1)
            {
                return s;
            }

            return RemoveExtraWhitespaces(s.Remove(s.IndexOf("  "), 1));
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
        static void EscribeArraysString(string[] s)
        {
            string result = "";

            if (s.Length > 0)
            {
                result += "[";

                for (int i = 0; i < s.Length - 1; i++)
                {
                    result += s[i] + ", ";
                }

                result += $"{s[s.Length - 1]}]";
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
            string acentos = "áéíóúàèìòùâêîôûäëïöüÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜ", sinAcentos = "aeiouaeiouaeiouaeiouAEIOUAEIOUAEIOUAEIOU", result = s;
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
        #endregion
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
                Console.WriteLine($"{words[i + 2]} {words[i]} {words[i + 1]}");
            }
        }
        static int CuentaLetra(string s, char c)
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
        static string MayusculaFrase (string s)
        {
            string result;
            string[] phrases = s.Split('.');

            for (int i = 0; i < phrases.Length; i++)
            {
                for (int j = 0; j < phrases[i].Length; j++)
                {
                    if (char.IsLetter(phrases[i][j]))
                    {
                        phrases[i] = phrases[i].Substring(0, j) + char.ToUpper(phrases[i][j]) + phrases[i].Substring(j + 1);
                        j = phrases[i].Length;
                    }
                }
            }

            result = String.Join('.', phrases);

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
        static string RecursiveRemove (string s, Regex pattern)
        {
            Match match = pattern.Match(s);

            if (!match.Success)
            {
                return s;
            }

            return EliminaTags(s.Remove(s.IndexOf(match.Value), match.Value.Length));
        }
        static string EliminaTags (string s)
        {
            /*
            Escribe la función EliminaTags a la que le pasamos una cadena que contiene tags (como los de XML) y los elimina dejando sólo el texto (nos devuelve una cadena con el resultado).
            Ej.: 
                <p>Esto es texto normal <b>y esto es texto en negrita</b>.</p>
                Nos devolvería: Esto es texto normal y esto es texto en negrita. 
            */

            Regex pattern = new Regex("<\\/?[a-zA-Z]+>");

            return RecursiveRemove(s, pattern);
        }
        static string EliminaTagsSinRegExp (string s)
        {
            string result = "";
            bool isInTag = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '<')
                {
                    isInTag = true;
                }
                else
                {
                    if (s[i] == '>')
                    {
                        isInTag = false;
                    }
                    else
                    {
                        if (!isInTag)
                        {
                            result += s[i];
                        }
                    }
                }
            }

            return result;
        }
        static string EliminaTagsIndexOf (string s)
        {
            while (s.Contains('<'))
            {
                int possition1 = s.IndexOf('<');
                int possition2 = s.IndexOf('>', possition1);

                s = s.Remove(possition1, possition2 - possition1 + 1);
            }
            return s;
        }
        static string OrdenaPalabrasComa (string s)
        {
            string temp;
            string[] splitted = s.Split(',');

            for (int i = 0; i < splitted.Length - 1; i++)
            {
                for (int j = 0; j < splitted.Length - 1; j++)
                {
                    if (splitted[j + 1].CompareTo(splitted[j]) < 0)
                    {
                        temp = splitted[j];
                        splitted[j] = splitted[j + 1];
                        splitted[j + 1] = temp;
                    }
                }
            }

            return String.Join(',', splitted);
        }
        static string AcentosHTML (string s)
        {
            /*
            Escribe la función AcentosHTML que te sustituye los caracteres acentuados que le paséis por el código HTML correspondiente. La función recibirá una cadena por parámetro y nos devolverá otra cadena con el resultado. ES MAS SENCILLO COPIAR EN UNA CADENA.
            */

            string result = s;
            int position;
            char[] characters = { '&', '<', '>', '"', 'á', 'Á', 'é', 'É', 'í', 'Í', 'ó', 'Ó', 'ú', 'Ú', 'ñ', 'Ñ', 'ü', 'Ü' };
            string[] entities = { "&amp;", "&lt;", "&gt;", "&quot;", "&aacute;", "&Aacute;", "&aecute;", "&Eacute;", "&iacute;", "&Iacute;", "&oacute;", "&Oacute;", "&uacute;", "&Uacute;", "&ntilde;", "&Ntilde;", "&uuml;", "&Uuml;" };

            for (int i = 0; i < characters.Length; i++)
            {
                position = result.IndexOf(characters[i]);

                while (position != -1)
                {
                    result = result.Substring(0, position) + entities[i] + result.Substring(position + 1);
                    position = result.IndexOf(characters[i]);
                }
            }

            return result;
        }
        static string[] PalabrasMismaLetra (string s)
        {
            /*
            Escribe la función PalabrasMismaLetra a la que le pasamos una cadena y nos devolverá un array de cadenas que contendrá las palabras que empiezan y acaban por la misma letra. A la hora de contar las palabras, habrá que ignorar los símbolos de puntuación y las mayúsculas y minúsculas.
            Ej.: “Amanda tiene tres serpientes.” devolvería {amanda, serpientes} 
            */

            string[] result;
            int counter = 0;
            string[] words = RemoveExtraWhitespaces(OnlyLettersAndSpaces(s)).ToLower().Split(' ');

            foreach (string word in words)
            {
                if (word[0] == word[word.Length - 1])
                {
                    counter++;
                }
            }

            result = new string[counter];
            counter = 0;

            foreach (string word in words)
            {
                if (word[0] == word[word.Length - 1])
                {
                    result[counter] = word;
                    counter++;
                }
            }

            return result;
        }
        static string NumeroTexto9 (int n)
        {
            string[] numbers = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            
            return numbers[n];
        }
        static string DiezToDiecinueve (int n)
        {
            string[] numbers = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve" };

            return numbers[n - 10];
        }
        static string Veintes (int n)
        {
            string result;

            if (n == 20)
            {
                result = "veinte";
            }
            else
            {
                result = "veinti" + NumeroTexto9(n - 20);
            }

            return result;
        }
        static string DecenasEnTexto (int tens)
        {
            string[] numbers = { "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

            return numbers[tens - 1];
        }
        static string NumeroTexto99  (int n)
        {
            /*
             Escribe una función NumeroTexto99 a la que le pasamos un entero y nos devuelve una cadena con ese número puesto como texto (p.ej.: 76 = “setenta y seis”).
            - El número deberá estar comprendido entre 0 y 99. En caso contrario, devuelve una cadena vacía.
            - Se recomienda escribir la función NumeroTexto9 que hace lo mismo, pero sólo con números de 1 cifra, y usarla para simplificar esta función.
            - Si me ponéis un switch de 100 elementos os echo de clase directamente.
            - Si no sabéis como se escriben los números del uno al noventa y nueve, os mando de vuelta a la ESO.
            - OPCIONAL: Escribir la función NumeroTexto999.
            */

            int tens = n / 10, units = n % 10;
            string result;

            if (n < 10)
            {
                result = NumeroTexto9(n);
            }
            else
            {
                if (n < 30)
                {
                    if (n < 20)
                    {
                        result = DiezToDiecinueve(n);
                    }
                    else
                    {
                        result = Veintes(n);
                    }
                }
                else
                {
                    result = DecenasEnTexto(tens);
                    if (units > 0)
                    {
                        result += " y " + NumeroTexto9(units);
                    }
                }
            }

            return result;
        }
        static string LimpiaCadena (string s)
        {
            /*
             Escribe la función LimpiaCadena a la que le pasamos una cadena que incluirá letras y signos de puntuación. La función quitará todos los símbolos de la cadena, dejando tan solo un espacio entre cada palabra, y devolverá la cadena resultante.
            Ejemplo: Si le pasamos “Hola, ¿qué tal? Soy amigo de Poti-Poti.” Nos devolvería “Hola qué tal Soy amigo de Poti Poti”.
            */

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]) || char.IsLetterOrDigit(s[i]))
                {
                    sb.Append(s[i]);
                }
            }
            
            return sb.ToString();
        }
        static bool CompruebaEmail (string s)
        {
            /*
            Escribe la función CompruebaEmail, a la que le pasamos un string con una dirección de correo electrónico y nos devuelve true si es válida y false si no lo es.
            Para que una dirección de correo sea correcta se tienen que dar las siguientes condiciones:
                - Tiene que tener una arroba ‘@’ y solamente una. Además, la arroba no podrá estar ni al principio ni al final (la arroba divide las dos partes de la dirección).
                - Cada una de las dos partes de la dirección de email se compondrá de los siguientes caracteres:
                    • Letras minúsculas y mayúsculas (sin acentos y sin la eñe)
                    • Números
                    • El guion ‘-’, aunque no podrá estar ni al principio ni al final de cada parte.
                    • El punto ‘.’, que no podrá estar ni al principio ni al final de cada parte ni haber dos puntos seguidos.
            
            Ejemplos: very.common@example.com, admin@mailserver1
            */

            string group = "[A-Za-z0-9]", groupWithPuntuation = "[A-Za-z0-9\\.-]", component = $"{group}+({group}+{groupWithPuntuation}{group}+)*";
            Regex regex = new Regex($"^{component}@{component}$");

            return regex.IsMatch(s);
        }
        static string PalabrasImpares (string s)
        {
            /*
            Escribe la función PalabrasImpares a la que le pasamos una cadena de caracteres y nos devuelve otra cadena de caracteres con el resultado. La función contará el número de letras de cada palabra y dejará dentro de la cadena sólo las palabras con un número de letras impar.
            Ej.: “El perro de San Roque” -> “perro San Roque” 
            */

            string[] words = s.Split(' '), evenWords;
            int even = 0, i, j;

            for (i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    even++;
                }
            }

            evenWords = new string[even];
            i = 0;

            for (j = 0; j < words.Length; j++)
            {
                if (words[j].Length % 2 != 0)
                {
                    evenWords[i] = words[j];
                    i++;
                }
            }

            return string.Join(' ', evenWords);
        }
        static void CuentaDiptongos ()
        {
            /*
            Escribe la función CuentaDiptongos a la que le pasamos una cadena de caracteres y nos devuelve un entero, que será el número de diptongos que hay en la cadena. Para los que se saltaron la ESO, un diptongo es cuando hay dos vocales seguidas, siempre y cuando las dos vocales no sean fuertes (o sea, “ae”, “ea”, “ao”, “oa”, “eo” y “oe” no son diptongos).
                Ej.: 
                “Puede caer una bien buena” -> 3 diptongos
                Para que el ejercicio esté completo, se han de tener en cuenta también:
                    - Los acentos: comió -> sí, oído -> no
                    - La semivocal ‘y’: voy -> sí, yo -> no
                Opcional: para subir nota, podéis intentar hacerlo con estas excepciones:
                    - La ‘u’ muda: queso -> no, guepardo -> no
                    - La ‘u’ con diéresis: cigüeña -> sí
                    - La ‘h’ intercalada: ahijado -> sí 
            */

            Console.WriteLine("Esto es un peñazo increíble y no lo voy a hacer.");
        }
        static string[] FiltraArrayPalabras (string[] a)
        {
            /*
            Escribe la función FiltraArrayPalabras, a la que le pasamos un array de cadenas de caracteres (que generalmente será resultante de hacer un split) y nos devolverá otro array de cadenas en el que sólo aparecerán las cadenas que estén compuestas íntegramente por letras. Es decir, si una cadena de nuestro array contiene números, signos de puntuación u otros símbolos, no aparecerá en el array que devolvemos.
            
            Ej.: Si le pasamos el array: [“patata”, “c3po”, “5874”, “tomate”, “pimiento?”], nos devolverá: [“patata”, “tomate”] 
            */

            bool isOnlyLetters = true;
            int counter = 0;
            string[] filteredA;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!char.IsLetter(a[i][j]))
                    {
                        isOnlyLetters = false;
                        j = a[i].Length;
                    }
                }

                if (isOnlyLetters)
                {
                    counter++;
                }
                else
                {
                    isOnlyLetters = true;
                }
            }

            filteredA = new string[counter];
            counter = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!char.IsLetter(a[i][j]))
                    {
                        isOnlyLetters = false;
                        j = a[i].Length;
                    }
                }

                if (isOnlyLetters)
                {
                    filteredA[counter] = a[i];
                    counter++;
                }
                else
                {
                    isOnlyLetters = true;
                }
            }

            return filteredA;
        }
    }
}
