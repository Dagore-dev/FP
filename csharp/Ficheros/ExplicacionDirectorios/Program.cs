using System;
using System.IO;

namespace ExplicacionDirectorios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Cositas varias: Directory, File, Path
             */

            /*Directory*/

            //Directory.CreateDirectory("./Patata");//Crea el directorio Patata
            ////Directory.Delete("./Patata");
            //Directory.Move("./Patata", "./Tomate");

            //if (Directory.Exists("./Tomate"))
            //{
            //    Console.WriteLine("El tomate está en su sitio");
            //}

            /*File*/
            //File.Create("./Tomate/patata.txt");
            //if (File.Exists("./Tomate/patata.txt"))
            //{
            //    Console.WriteLine("La patata está en el tomate.");
            //}

            //File.Move("./Tomate/patata.txt", "./Tomate/tomate.txt");

            //if (File.Exists("./Tomate/tomate.txt"))
            //{
            //    Console.WriteLine("Fichero renombrado.");
            //}
            //File.Delete("./Tomate/tomate.txt");

            string[] ficheros = Directory.GetFiles("./Tomate");
            //string[] directorios = Directory.GetDirectories("./");

            //Console.WriteLine("Ficheros");
            //Console.WriteLine();
            //for (int i = 0; i < ficheros.Length; i++)
            //{
            //    Console.WriteLine(ficheros[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Directorios");
            //Console.WriteLine();

            //for (int i = 0; i < directorios.Length; i++)
            //{
            //    Console.WriteLine(directorios[i]);
            //}

            /*Path*/
            string currentFolder = Directory.GetCurrentDirectory();
            Console.WriteLine(currentFolder);
            Console.WriteLine(ficheros[0]);
            Console.WriteLine(Path.GetDirectoryName(ficheros[0]));
            Console.WriteLine(Path.GetFileName(ficheros[0]));
            Console.WriteLine(Path.GetFileNameWithoutExtension(ficheros[0]));
            Console.WriteLine(Path.GetExtension(ficheros[0]));

            /*Obtener información de un fichero*/
            FileInfo f = new FileInfo(ficheros[0]);
            Console.WriteLine();
            Console.WriteLine("Información del archivo");
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Length);//En bytes, es lo mismo que el tamaño del archivo
            Console.WriteLine(f.DirectoryName);
            Console.WriteLine(f.CreationTime);
            Console.WriteLine(f.Exists);
            Console.WriteLine(f.Extension);
            Console.WriteLine(f.IsReadOnly);
        }
    }
}
