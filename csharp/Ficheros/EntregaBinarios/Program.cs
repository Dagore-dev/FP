using System;
using System.Collections.Generic;
using System.IO;

namespace EntregaBinarios
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
                        EscribeFichero1_100("datos01.bin");
                        LeeBinarioEnteros("datos01.bin");
                    }
                    break;
                case 2:
                    {
                        EscribeFichero1_100("datos01.bin");
                        LeeFicheroInt100("datos01.bin");
                    }
                    break;
                case 3:
                    {
                        EscribeFicheroIntAleatorio("nAleatorios.bin", 10);
                        LeeBinarioEnteros("nAleatorios.bin");
                    }
                    break;
                case 4:
                    {
                        EscribeFicheroIntAleatorioPro("nAleatoriosPro.bin", 10, -5, 5);
                        LeeBinarioEnteros("nAleatoriosPro.bin");
                    }
                    break;
                case 5:
                    {
                        EscribeFicheroIntAleatorioPro("nAleatoriosPro.bin", 10, -5, 5);
                        LeeFicheroInt("nAleatoriosPro.bin", 10);
                    }
                    break;
                case 6:
                    {
                        EscribeFichero1_100("datos01.bin");
                        Console.WriteLine($"Suma = {SumaFicheroInt("datos01.bin")} = 5050");
                    }
                    break;
                case 7:
                    {
                        EscribeFichero1_100("datos01.bin");
                        Console.WriteLine($"Número de líneas = {LeeFicheroIntLista("datos01.bin").Count}");
                    }
                    break;
                case 8:
                    {
                        List<int> l = new List<int> { 0, 2, 3, 4, 5, 6, 7, 8, 9 };
                        EscribeFicheroIntLista("listaint.bin", l);
                        LeeBinarioEnteros("listaint.bin");
                    }
                    break;
                case 9:
                    {
                        List<int> l = new List<int> { 2, 3, 7, 6, 4, 6, 91, 561564, 3, 4, 5 };
                        EscribeFicheroIntLista("listaint.bin", l);
                        OrdenaFicheroInt("listaint.bin");
                        LeeBinarioEnteros("listaint.bin");
                    }
                    break;
                case 10:
                    {
                        EscribeFicheroIntAleatorioPro("nAleatoriosPro.bin", 20, -100, 100);
                        SeparaFicheroInt("nAleatoriosPro.bin");
                        Console.WriteLine("Números positivos");
                        LeeBinarioEnteros("nAleatoriosPro.binpositivos");
                        Console.WriteLine();
                        Console.WriteLine("Números negativos");
                        LeeBinarioEnteros("nAleatoriosPro.binnegativos");
                    }
                    break;
                case 11:
                    {
                        EscribeFichero1_100("datos01.bin");
                        InvierteFicheroInt("datos01.bin");
                        LeeBinarioEnteros("datos01.bin");
                    }
                    break;
                default:
                    break;
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine(" 1 - EscribeFichero1_100");
            Console.WriteLine(" 2 - LeeFicheroInt100");
            Console.WriteLine(" 3 - EscribeFicheroIntAleatorio");
            Console.WriteLine(" 4 - EscribeFicheroIntAleatorioPro");
            Console.WriteLine(" 5 - LeeFicheroInt");
            Console.WriteLine(" 6 - SumaFicheroInt");
            Console.WriteLine(" 7 - LeeFicheroIntLista");
            Console.WriteLine(" 8 - EscribeFicheroIntLista");
            Console.WriteLine(" 9 - OrdenaFicheroInt");
            Console.WriteLine("10 - SeparaFicheroInt");
            Console.WriteLine("11 - InvierteFicheroInt");

            Console.Write("Escribe la opción escogida: ");
        }
        static void LeeBinarioEnteros(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Console.WriteLine(br.ReadInt32());
            }

            br.Close();
            fs.Close();
        }
        static void EscribeFichero1_100 (string filename)
        {
            //Escribe una función EscribeFichero1_100 que te escriba en un fichero binario cuyo nombre le pasas por parámetro(p.ej.: “datos01.bin”) los valores enteros desde 1 hasta 100.
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 1; i < 101; i++)
            {
                bw.Write(i);
            }

            bw.Close();
            fs.Close();
        }
        static void LeeFicheroInt100 (string filename)
        {
            //Escribe una función LeeFicheroInt100 que te lea del fichero que le pasas por parámetro los 100 primeros valores enteros.
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(br.ReadInt32());
            }

            br.Close();
            fs.Close();
        }
        static void EscribeFicheroIntAleatorio (string filename, int n)
        {
            //Escribe una función EscribeFicheroIntAleatorio a la que le pasas el nombre del fichero y cuántos números aleatorios queremos escribir en el mismo. Los números aleatorios serán entre 1 y 100 y serán de tipo int.
            Random r = new Random();
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < n; i++)
            {
                bw.Write(r.Next(1, 101));
            }
            
            bw.Close();
            fs.Close();
        }
        static void EscribeFicheroIntAleatorioPro (string filename, int n, int min, int max)
        {
            //Escribe una función EscribeFicheroIntAleatorioPro a la que le pasas lo siguiente: el nombre del fichero, número de valores que se van a generar, el valor mínimo y el valor máximo. Así, EscribeFicheroIntAleatorioPro(“datos.bin”, 10, -5, 5) nos escribirá diez valores aleatorios entre -5 y 5 en el fichero datos.bin.
            Random r = new Random();
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < n; i++)
            {
                bw.Write(r.Next(min, max + 1));
            }

            bw.Close();
            fs.Close();
        }
        static void LeeFicheroInt (string filename, int n)
        {
            //Escribe una función LeeFicheroInt que te lea del fichero que le pasas por parámetro todos los valores enteros que haya en él.
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(br.ReadInt32());
            }

            br.Close();
            fs.Close();
        }
        static int SumaFicheroInt (string filename)
        {
            //Escribe una función SumaFicheroInt que te lea de un fichero todos los valores enteros, los sume y te devuelva el resultado.
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            int result = 0;

            while (fs.Position < fs.Length)
            {
                result += br.ReadInt32();
            }

            br.Close();
            fs.Close();

            return result;
        }
        static List<int> LeeFicheroIntLista (string filename)
        {
            //Escribe una función LeeFicheroIntLista que te lea de un fichero todos los valores enteros.Los valores los irá almacenando en una lista de enteros que devolverá. El prototipo de la función será: List<int> LeeFicheroIntLista(string nombre_fichero).
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            List<int> result = new List<int>();

            while (fs.Position < fs.Length)
            {
                result.Add(br.ReadInt32());
            }

            br.Close();
            fs.Close();
            return result;
        }
        static void EscribeFicheroIntLista (string filename, List<int> l)
        {
            //Escribe una función EscribeFicheroIntLista que te escriba en un fichero todos los valores enteros de la lista que le pasamos por parámetro. El prototipo de la función será: void LeeFicheroIntLista(string nombre_fichero, List<int> lista).
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < l.Count; i++)
            {
                bw.Write(l[i]);
            }

            bw.Close();
            fs.Close();

        }
        static void OrdenaFicheroInt (string filename)
        {
            //Escribe una función OrdenaFicheroInt que te lea de un fichero los valores enteros que haya, los ordene y vuelva a escribir en el mismo fichero los valores ya ordenados.
            List<int> l = LeeFicheroIntLista(filename);
            l.Sort();
            EscribeFicheroIntLista(filename, l);

        }
        static void SeparaFicheroInt (string filename)
        {
            //Escribe una función SeparaFicheroInt a la que le pasaremos el nombre del fichero que queremos separar. La función nos creará dos ficheros que tendrán el mismo nombre que el de origen pero añadiéndole “positivos” o “negativos” detrás(ej.: “datos.bin” -> “datos.binpositivos”, “datos.binnegativos”).En un fichero guardaremos todos los números positivos que haya en el primer fichero y en el otro los negativos.
            List<int> l = LeeFicheroIntLista(filename), positive = new List<int>(), negative = new List<int>();
            string positiveName = filename + "positivos", negativeName = filename + "negativos";

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] >= 0)
                {
                    positive.Add(l[i]);
                }
                else
                {
                    negative.Add(l[i]);
                }
            }

            EscribeFicheroIntLista(positiveName, positive);
            EscribeFicheroIntLista(negativeName, negative);
        }
        static void InvierteFicheroInt (string filename)
        {
            List<int> l = LeeFicheroIntLista(filename);
            l.Reverse();
            EscribeFicheroIntLista(filename, l);
        }
    }
}
