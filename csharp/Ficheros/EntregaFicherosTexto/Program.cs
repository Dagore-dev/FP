using System;
using System.Collections.Generic;
using System.IO;

namespace EntregaFicherosTexto
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
                        EscribeFicheroNumRandom10("NumRandom10.txt");
                    }
                    break;
                case 2:
                    {
                        EscribeFicheroNumRandom10("NumRandom10.txt");
                        LeeFichero("NumRandom10.txt");
                        Console.WriteLine($"Total = {SumaFicheroInt10("NumRandom10.txt")}");
                    }
                    break;
                case 3:
                    {
                        EscribeFicheroNumRandom("NumRandom.txt", 5);
                        LeeFichero("NumRandom.txt");
                    }
                    break;
                case 4:
                    {
                        EscribeFicheroNumRandom("NumRandom.txt", 5);
                        LeeFichero("NumRandom.txt");
                        Console.WriteLine($"Total = {SumaFicheroInt("NumRandom.txt")}");
                    }
                    break;
                case 5:
                    {
                        EscribeFicheroTexto("Texto.txt");
                        LeeFichero("Texto.txt");
                    }
                    break;
                case 6:
                    {
                        EscribeFicheroNumRandom("NumRandom.txt", 5);
                        LeeFicheroTexto("NumRandom.txt");
                    }
                    break;
                case 7:
                    {
                        EscribeFicheroNumRandom("NumRandom.txt", 5);
                        CopiaFicheroTexto("NumRandom.txt", "Copia.txt");
                        Console.WriteLine("NunRandom.txt");
                        LeeFicheroTexto("NumRandom.txt");
                        Console.WriteLine();
                        Console.WriteLine("Copia.txt");
                        LeeFicheroTexto("Copia.txt");
                    }
                    break;
                case 8:
                    {
                        EscribeFicheroTexto("Texto.txt");
                        InvierteLineasFichero("Texto.txt", "CopiaLineasInvertidas.txt");

                        Console.WriteLine();
                        LeeFicheroTexto("CopiaLineasInvertidas.txt");
                    }
                    break;
                case 9:
                    {
                        EscribeFicheroNumRandom("NumRandom.txt", 5);
                        Console.WriteLine("Antes");
                        LeeFicheroTexto("NumRandom.txt");
                        Console.WriteLine();
                        InvierteFicheroTexto("NumRandom.txt");
                        LeeFicheroTexto("NumRandom.txt");
                    }
                    break;
                case 10:
                    {
                        EscribeFicheroTexto("Texto.txt");
                        Console.WriteLine("Texto.txt");
                        LeeFicheroTexto("Texto.txt");
                        Console.WriteLine();

                        SeparaPalabrasFichero("Texto.txt", "PalabrasPorLinea.txt");
                        Console.WriteLine("PalabrasPorLinea.txt");
                        LeeFicheroTexto("PalabrasPorLinea.txt");
                    }
                    break;
                default:
                    break;
            }
        }
        static void ShowMenu ()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine(" 1 - EscribeFicheroNumRandom10");
            Console.WriteLine(" 2 - SumaFicheroInt10");
            Console.WriteLine(" 3 - EscribeFicheroNumRandom");
            Console.WriteLine(" 4 - SumaFicheroInt");
            Console.WriteLine(" 5 - EscribeFicheroTexto");
            Console.WriteLine(" 6 - LeeFicheroTexto");
            Console.WriteLine(" 7 - CopiaFicheroTexto");
            Console.WriteLine(" 8 - InvierteLineasFichero");
            Console.WriteLine(" 9 - InvierteFicheroTexto");
            Console.WriteLine("10 - SeparaPalabrasFichero");
            Console.Write("Introduce una opción: ");
        }
        static string InvierteCadena(string s)
        {
            string result = "";

            for (int i = s.Length - 1; i > -1; i--)
            {
                result += s[i];
            }

            return result;
        }
        static void LeeFichero (string filename)
        {
            StreamReader streamReader = new StreamReader(filename);

            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();
        }
        static void EscribeFicheroNumRandom10 (string filename)
        {
            //Escribe una función EscribeFicheroNumRandom10 a la que le pasas un nombre de fichero y te crea un fichero con ese nombre que contiene 10 números aleatorios en diferentes líneas.
            Random r = new Random();
            StreamWriter streamWriter = new StreamWriter(filename);

            for (int i = 0; i < 10; i++)
            {
                streamWriter.WriteLine(r.Next(0, 10));
            }

            streamWriter.Close();
        }
        static int SumaFicheroInt10 (string filename)
        {
            //Escribe una función SumaFicheroInt10 a la que le pasas un fichero con 10 líneas (que debe contener enteros en diferentes líneas, como el del ejercicio anterior) y te devuelve la suma de todos los números contenidos en el fichero.
            StreamReader streamReader = new StreamReader(filename);
            int result = 0;

            for (int i = 0; i < 10; i++)
            {
                result += int.Parse(streamReader.ReadLine());
            }

            streamReader.Close();

            return result;
        }
        static void EscribeFicheroNumRandom (string filename, int numberOfLines)
        {
            //Escribe una función EscribeFicheroNumRandom a la que le pasas un nombre de fichero y un entero y te escribe tantos números aleatorios como le hayas dicho en un fichero de texto.
            Random r = new Random();
            StreamWriter streamWriter = new StreamWriter(filename);

            for (int i = 0; i < numberOfLines; i++)
            {
                streamWriter.WriteLine(r.Next(0, 10));
            }

            streamWriter.Close();
        }
        static int SumaFicheroInt (string filename)
        {
            int result = 0;
            StreamReader streamReader = new StreamReader(filename);

            while (!streamReader.EndOfStream)
            {
                result += int.Parse(streamReader.ReadLine());
            }

            return result;
        }
        static void EscribeFicheroTexto (string filename)
        {
            //Escribe una función EscribeFicheroTexto a la que le pasas un nombre de fichero. La función ira pidiendo al usuario que escriba líneas de texto, que se irán guardando en el fichero, hasta que introduzca una línea en blanco(“”).
            StreamWriter streamWriter = new StreamWriter(filename);
            int line = 0;
            string lineContent;

            Console.WriteLine("Escriba línea a línea el contenido del texto, si introduce una línea en blanco se termina la escritura.");
            Console.Write($"{line}: ");
            lineContent = Console.ReadLine();
            line++;

            while (lineContent != "")
            {
                streamWriter.WriteLine(lineContent);
                Console.Write($"{line}: ");
                lineContent = Console.ReadLine();

                line++;
            }

            streamWriter.Close();
        }
        static void LeeFicheroTexto (string filename)
        {
            //Escribe la función LeeFicheroTexto a la que le pasas un nombre de fichero y te pone el contenido del fichero por pantalla.
            StreamReader streamReader = new StreamReader(filename);

            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();
        }
        static void CopiaFicheroTexto (string filename1, string filename2)
        {
            StreamReader streamReader = new StreamReader(filename1);
            StreamWriter streamWriter = new StreamWriter(filename2);

            while (!streamReader.EndOfStream)
            {
                streamWriter.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();
            streamWriter.Close();
        }
        static void InvierteLineasFichero (string filename1, string filename2)
        {
            //Escribe la función InvierteLineasFichero a las que la pasas dos nombres de fichero y te copia las líneas del primer fichero al segundo fichero, pero invertidas(con el primer carácter al final y el último al principio, etc.). Podéis usar la función de invertir cadenas que ya tenéis hecha.

            StreamReader streamReader = new StreamReader(filename1);
            StreamWriter streamWriter = new StreamWriter(filename2);

            while (!streamReader.EndOfStream)
            {
                streamWriter.WriteLine(InvierteCadena(streamReader.ReadLine()));
            }

            streamReader.Close();
            streamWriter.Close();
        }
        static List<string> LinesListFromFile (string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            List<string> ls = new List<string>();

            while (!streamReader.EndOfStream)
            {
                ls.Add(streamReader.ReadLine());
            }

            streamReader.Close();

            return ls;
        }
        static void InvierteFicheroTexto (string filename)
        {
            List<string> contentList = LinesListFromFile(filename);
            StreamWriter streamWriter = new StreamWriter(filename);

            contentList.Reverse();

            for (int i = 0; i < contentList.Count; i++)
            {
                streamWriter.WriteLine(contentList[i]);
            }

            streamWriter.Close();
        }
        static void SeparaPalabrasFichero (string filename1, string filename2)
        {
            //Escribe la función SeparaPalabrasFichero a la que le pasas dos nombres de fichero. Te cogerá el primer fichero(que contendrá frases) y te separará las palabras, que escribirá en el segundo fichero(que tendrá una palabra en cada línea)
            StreamReader streamReader = new StreamReader(filename1);
            StreamWriter streamWriter = new StreamWriter(filename2);
            string[] lineContent;

            while (!streamReader.EndOfStream)
            {
                lineContent = streamReader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lineContent.Length; i++)
                {
                    streamWriter.WriteLine(lineContent[i]);
                }
            }

            streamWriter.Close();
            streamReader.Close();
        }
    }
}
