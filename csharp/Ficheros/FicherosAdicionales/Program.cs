using System;
using System.Collections.Generic;
using System.IO;
namespace FicherosAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            ShowMenu();
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        EscribeArrays(CuentaVocalesFichero("lazarillo.txt"));
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("PARA PROBAR ESTE ARCHIVO HAY QUE BORRAR EL ARCHIVO notasProcesadas.csv SI EXISTIERA");
                        EscribeSumasCSV("notas.csv", "notasProcesadas.csv");
                        Console.WriteLine("notas.csv");
                        LeeFicheroTexto("notas.csv");
                        Console.WriteLine();
                        Console.WriteLine("notasProcesadas.csv");
                        LeeFicheroTexto("notasProcesadas.csv");
                    }
                    break;
                case 3:
                    {
                        EscribeArrayBiChar(LeeSopaLetras("sopa1.txt"));
                        Console.WriteLine();
                        EscribeArrayBiChar(LeeSopaLetras("sopa2.txt"));
                        Console.WriteLine();
                        EscribeArrayBiChar(LeeSopaLetras("sopamal.txt"));
                    }
                    break;
                case 4:
                    {

                        //ARREGLA LO DE QUE DEBE CREAR EL FICHERO DESDE EL PRINCIPIO PRIMERO.
                        CuatroVocales("ficheros/texto/Ej04/lazarillo.txt");
                        CuatroVocales("pruebaVocales.txt");
                        LeeFicheroTexto("4vocales.txt");
                        
                    }
                    break;
                default:
                    break;
            }

        }
        #region utils
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
        static void EscribeArrayBiChar(char[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void LeeFicheroTexto(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);

            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();
        }
        static string QuitaAcentos(string s)
        {
            string acentos = "áéíóúàèìòùâêîôûäëïöüÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜ", 
                sinAcentos = "aeiouaeiouaeiouaeiouAEIOUAEIOUAEIOUAEIOU", result = s;
            int position = -1;

            for (int i = 0; i < result.Length; i++)
            {
                position = acentos.IndexOf(result[i]);

                if (position != -1)
                {
                    //result = result.Remove(i, 1).Insert(i, sinAcentos[position].ToString());
                    result = result.Replace(result[i], sinAcentos[position]);
                }
            }

            return result;
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
        #endregion
        static void ShowMenu ()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine(" 1 - CuentaVocalesFichero");
            Console.WriteLine(" 2 - EscribeSumasCSV");
            Console.WriteLine(" 3 - LeeSopaDeletras");

            Console.Write("Introduce la opción: ");
        }
        static int[] CuentaVocalesFichero (string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            int[] vowels = { 0, 0, 0, 0, 0 };
            string line;

            while (!streamReader.EndOfStream)
            {
                line = QuitaAcentos(streamReader.ReadLine()).ToLower();

                for (int i = 0; i < line.Length; i++)
                {
                    switch (line[i])
                    {
                        case 'a': vowels[0]++; break;
                        case 'e': vowels[1]++; break;
                        case 'i': vowels[2]++; break;
                        case 'o': vowels[3]++; break;
                        case 'u': vowels[4]++; break;
                        default:
                            break;
                    }
                }
            }

            streamReader.Close();

            return vowels;
        }
        static string AverageScore (string s1, string s2, string s3)
        {
            double average, d1 = double.Parse(s1), d2 = double.Parse(s2), d3 = double.Parse(s3);

            average = (d1 + d2 + d3) / 3;

            return average.ToString("0.00");
        }
        static string ProcessedLine (string line)
        {
            string s = line.Replace('.', ',');
            string[] columns = s.Split(';'), data = new string[6];

            for (int i = 0; i < columns.Length; i++)
            {
                data[i] = columns[i];
            }

            data[4] = AverageScore(data[1], data[2], data[3]);
            data[5] = double.Parse(data[4]) >= 5 ? "Aprobado" : "Suspenso";

            return String.Join(';', data);
        }
        static void EscribeSumasCSV (string filename1, string filename2)
        {
            /*
            Escribe la función EscribeSumasCSV a la que le pasamos una cadena con el nombre de un fichero CSV que contiene una tabla con notas de alumnos y copia esa tabla en el otro fichero que le pasamos por parámetro completando los datos que faltan. El formato de cada línea del fichero CSV será el siguiente:
                - En la primera columna, el nombre del alumno.
                - En las tres siguientes columnas, las notas del primer, segundo y tercer trimestre.
                - La quinta columna no debe existir en el primer fichero, y deberá contener la nota media de los tres trimestres en el segundo fichero, redondeada a 2 decimales.
                - La sexta columna también falta del primer fichero y tendrá una cadena que podrá ser “Aprobado” o “Suspenso” dependiendo de si la nota media es mayor o igual que 5 o no.
             
            Se debe comprobar que el primer fichero existe, que el segundo no existe y, opcionalmente, que cada línea del fichero que leemos tiene 4 campos. Si no se cumplen estas condiciones, se deberá dar un error y no crear el fichero nuevo.
             */
            StreamReader streamReader;
            StreamWriter streamWriter;
            string line, processedLine;

            if (File.Exists(filename1) && !File.Exists(filename2))
            {
                streamReader = new StreamReader(filename1);
                streamWriter = new StreamWriter(filename2);

                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();
                    processedLine = ProcessedLine(line);
                    streamWriter.WriteLine(processedLine);
                }

                streamReader.Close();
                streamWriter.Close();
            }
            else
            {
                Console.WriteLine("ERROR: No existe el fichero original o existe el fichero que se quiere crear");
            }

        }
        static char[,] LeeSopaLetras (string filename)
        {
            /*
              Escribe la función LeeSopaLetras, que nos leerá una sopa de letras de un archivo de texto cuyo nombre le pasamos por parámetro y nos devolverá un array bidimensional de caracteres con la sopa de letras.
                En el fichero de texto aparecerá cada línea sin separación entre las letras.
                
            Ej.:
                PATAK
                IKPMO
                CJDME
                OLOTS
                
            En este ejemplo, la función nos devolvería un array de tipo char[4][5].
            La función deberá comprobar si todas las líneas son iguales. En caso contrario, nos devolverá un array vacío (char[0][0]).
            Se recomienda adaptar la función EscribeArrayBidimensional para poder ver si se ha leído correctamente la sopa de letras.
             */
            char[,] soup;
            int rows = 0, cols = 0;

            if (AreLinesEqual(filename))
            {
                SoupSize(filename, ref rows, ref cols);
                soup = new char[rows, cols];
                FillCharArray(filename, soup);
            }
            else
            {
                soup = new char[0, 0];
            }

            return soup;
        }
        static bool AreLinesEqual (string filename)
        {
            StreamReader sr = new StreamReader(filename);
            bool result = true;
            int length = sr.ReadLine().Length;

            while (!sr.EndOfStream)
            {
                if (sr.ReadLine().Length != length)
                {
                    result = false;
                }
            }

            sr.Close();
            return result;
        }
        static void SoupSize (string filename, ref int rows, ref int cols)
        {
            StreamReader sr = new StreamReader(filename);
            int numberOfRows = 1,
                numberOfCols = sr.ReadLine().Trim().Length;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                numberOfRows++;
            }

            rows = numberOfRows;
            cols = numberOfCols;
            sr.Close();
        }
        static void FillCharArray (string filename, char[,] soup)
        {
            StreamReader sr = new StreamReader(filename);
            int row = 0;
            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine().Trim();

                for (int i = 0; i < line.Length; i++)
                {
                    soup[row, i] = line[i];
                }

                row++;
            }

            sr.Close();
        }
        static void CuatroVocales (string filename)
        {
            /*
             Escribe la función CuatroVocales a la que le pasamos un nombre de fichero de texto y nos busca las palabras que haya en ese fichero con al menos cuatro vocales. La función nos creará otro fichero que se llamará “4vocales.txt” donde aparecerán las palabras que cumplan esa condición (una palabra en cada línea). En el fichero original podrán aparecer símbolos de puntuación, así que hay que tener cuidado con ellos. Como ejemplo, os incluyo el primer capítulo de “El Lazarillo de Tormes”.
             */
            StreamReader sr = new StreamReader(filename);

            while (!sr.EndOfStream)
            {
                EscribePalabras4Vocales(sr.ReadLine());
            }

            sr.Close();
        }
        static void EscribePalabras4Vocales (string line)
        {
            StreamWriter sr = new StreamWriter("4vocales.txt", true);//Introduce cada línea al final del documento.
            string[] words = OnlyLettersAndSpaces(line).Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] fourVowels = MoreThan4Vowels(words);

            for (int i = 0; i < fourVowels.Length; i++)
            {
                sr.WriteLine(fourVowels[i]);
            }

            sr.Close();
        }
        static string[] MoreThan4Vowels (string[] a)
        {
            List<string> l = new List<string>();

            for (int i = 0; i < a.Length; i++)
            {
                if (Has4Vowels(a[i]))
                {
                    l.Add(a[i]);
                }
            }

            return l.ToArray();
        }
        static bool Has4Vowels (string word)
        {
            int count = 0;
            word = word.ToLower();

            for (int i = 0; i < word.Length; i++)
            {
                if (IsVowel(word[i]))
                {
                    count++;
                }
            }

            return count > 3;
        }
        static bool IsVowel (char c)
        {
            string vowels = "aeiouyáéíóúýa̋e̋i̋őűàèìòùỳầềồḕṑǜừằȁȅȉȍȕăĕĭŏŭy̆ắằẳẵặḝȃȇȋȏȗǎěǐǒǔy̌a̧ȩə̧ɛ̧i̧ɨ̧o̧u̧âêîôûŷḙṷẩểổấếốẫễỗậệộäëïöüÿṳḯǘǚṏǟȫǖṻȧėıȯẏǡạẹịọụỵậȩ̇ǡȱảẻỉỏủỷơướứờừởửỡữợựāǣēīōūȳḗṓȭǭąęįǫųy̨åi̊ůḁǻą̊ãẽĩõũỹаэыуояеёюийⱥɇɨøɵꝋʉᵿɏөӫұɨαεηιοωυάέήίόώύὰὲὴὶὸὼὺἀἐἠἰὀὠὐἁἑἡἱὁὡὑᾶῆῖῶῦἆἦἶὦὖἇἧἷὧὗᾳῃῳᾷῇῷᾴῄῴᾲῂῲᾀᾐᾠᾁᾑᾡᾆᾖᾦᾇᾗᾧϊϋΐΰῒῢῗῧἅἕἥἵὅὥὕἄἔἤἴὄὤὔἂἒἢἲὂὢὒἃἓἣἳὃὣὓᾅᾕᾥᾄᾔᾤᾂᾒᾢᾃᾓᾣæɯɪʏʊøɘɤəɛœɜɞʌɔɐɶɑɒιυ";

            return vowels.Contains(c);
        }
    }
}
