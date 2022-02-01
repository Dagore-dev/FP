using System;
using System.Collections.Generic;
using System.IO;

namespace EntregaFicherosRegistros
{
    class Program
    {
        public class FichaAlumno
        {
            public string nombre;
            public int edad;
            public double calificacion;
        }
        static void Main(string[] args)
        {
            List<FichaAlumno> alumnos = new List<FichaAlumno>();
            int option;

            ShowMenu();

            option = int.Parse(Console.ReadLine());

            while (option > 0 && option < 9)
            {
                switch (option)
                {
                    case 1:
                        {
                            LeeAlumnoLista(alumnos);
                        }
                        break;
                    case 2:
                        {
                            ImprimeListaAlumnos(alumnos);
                        }
                        break;
                    case 3:
                        {
                            EscribeFicheroAlumnosBinario(alumnos, "registroalumnosbinario.bin");
                        }
                        break;
                    case 4:
                        {
                            LeeFicheroAlumnosBinario(alumnos, "registroalumnosbinario.bin");
                        }
                        break;
                    case 5:
                        {
                            EscribeFicheroAlumnosTexto(alumnos, "registroalumnostexto.txt");
                        }
                        break;
                    case 6:
                        {
                            LeeFicheroAlumnosTexto(alumnos, "registroalumnostexto.txt");
                        }
                        break;
                    case 7:
                        {
                            EscribeFicheroAlumnosCSV(alumnos, "registroalumnos.csv");
                        }
                        break;
                    case 8:
                        {
                            LeeFicheroAlumnosCSV(alumnos, "registroalumnos.csv");
                        }
                        break;
                    default:
                        break;
                }

                Console.Write("Introduzca otra opción o 0 para terminar: ");
                option = int.Parse(Console.ReadLine());
            }
        }
        #region utils
        static void ShowMenu()
        {
            Console.WriteLine("MENU:");

            Console.WriteLine("1 - LeeAlumnoLista");
            Console.WriteLine("2 - ImprimeListaAlumnos");
            Console.WriteLine("3 - EscribeFicheroAlumnosBinario");
            Console.WriteLine("4 - LeeFicheroAlumnosBinario");
            Console.WriteLine("5 - EscribeFicheroAlumnosTexto");
            Console.WriteLine("6 - LeeFicheroAlumnosTexto");
            Console.WriteLine("7 - EscribeFicheroAlumnosCSV");
            Console.WriteLine("8 - LeeFicheroAlumnosCSV");

            Console.Write("Introduce una opción: ");
        }
        static void PrintLine(int tableWidth)
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(int tableWidth, params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        #endregion
        static FichaAlumno CreateFichaAlumno (string nombre, int edad, double calificacion)
        {
            FichaAlumno alumno = new FichaAlumno();

            alumno.nombre = nombre;
            alumno.edad = edad;
            alumno.calificacion = calificacion;

            return alumno;
        }
        static void LeeAlumnoLista (List<FichaAlumno> l)
        {
            string nombre;
            int edad;
            double calificacion;

            Console.WriteLine("Introduce la información del nuevo alumno:");
            
            Console.Write("Nombre del alumno: ");
            nombre = Console.ReadLine();

            Console.Write("Edad del alumno: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Calificación del alumno: ");
            calificacion = double.Parse(Console.ReadLine());

            l.Add(CreateFichaAlumno(nombre, edad, calificacion));
        }
        static void ImprimeListaAlumnos (List<FichaAlumno> l)
        {
            FichaAlumno alumno;
            int tableWidth = 100;

            PrintLine(tableWidth);
            PrintRow(tableWidth, "Nombre", "Edad", "Calificación");

            for (int i = 0; i < l.Count; i++)
            {
                alumno = l[i];

                PrintLine(tableWidth);
                PrintRow(tableWidth, alumno.nombre, alumno.edad.ToString(), String.Format("{0:0.00}", alumno.calificacion));
            }
        }
        static void EscribeFicheroAlumnosBinario (List<FichaAlumno> l, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            FichaAlumno alumno;

            bw.Write(l.Count);

            for (int i = 0; i < l.Count; i++)
            {
                alumno = l[i];

                bw.Write(alumno.nombre);
                bw.Write(alumno.edad);
                bw.Write(alumno.calificacion);
            }

            bw.Close();
            fs.Close();
        }
        static void LeeFicheroAlumnosBinario (List<FichaAlumno> l, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            FichaAlumno alumno;
            int length = br.ReadInt32();
            l.Clear();

            for (int i = 0; i < length; i++)
            {
                alumno = new FichaAlumno();

                alumno.nombre = br.ReadString();
                alumno.edad = br.ReadInt32();
                alumno.calificacion = br.ReadDouble();

                l.Add(alumno);
            }

            br.Close();
            fs.Close();
        }
        static void EscribeFicheroAlumnosTexto (List<FichaAlumno> l, string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            FichaAlumno alumno;

            sw.WriteLine(l.Count);

            for (int i = 0; i < l.Count; i++)
            {
                alumno = l[i];

                sw.WriteLine(alumno.nombre);
                sw.WriteLine(alumno.edad);
                sw.WriteLine(alumno.calificacion);
            }
            
            sw.Close();
        }
        static void LeeFicheroAlumnosTexto (List<FichaAlumno> l, string filename)
        {
            StreamReader sr = new StreamReader(filename);
            FichaAlumno alumno;
            int length = int.Parse(sr.ReadLine());

            for (int i = 0; i < length; i++)
            {
                alumno = new FichaAlumno();

                alumno.nombre = sr.ReadLine();
                alumno.edad = int.Parse(sr.ReadLine());
                alumno.calificacion = double.Parse(sr.ReadLine());

                l.Add(alumno);
            }

            sr.Close();
        }
        static void EscribeFicheroAlumnosCSV (List<FichaAlumno> l, string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            FichaAlumno alumno;

            for (int i = 0; i < l.Count; i++)
            {
                alumno = l[i];

                sw.WriteLine($"{alumno.nombre};{alumno.edad};{alumno.calificacion}");
            }

            sw.Close();
        }
        static void LeeFicheroAlumnosCSV (List<FichaAlumno> l, string filename)
        {
            StreamReader sr = new StreamReader(filename);
            FichaAlumno alumno;
            string[] record;

            while (!sr.EndOfStream)
            {
                alumno = new FichaAlumno();
                record = sr.ReadLine().Split(";");

                alumno.nombre = record[0];
                alumno.edad = int.Parse(record[1]);
                alumno.calificacion = double.Parse(record[2]);

                l.Add(alumno);
            }

            sr.Close();
        }
    }
}
