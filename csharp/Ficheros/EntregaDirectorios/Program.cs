using System;
using System.Collections.Generic;
using System.IO;

namespace EntregaDirectorios
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
                        Console.WriteLine($"Hay {CuantosFicheros(".txt")} ficheros de texto.");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine($"Hay {CuantosFicherosPro(".txt", ".")} ficheros de texto.");
                    }
                    break;
                case 3:
                    {
                        CreaBackup("./file1.txt");
                    }
                    break;
                case 4:
                    {
                        RenombraMasivo("doc", "txt");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine($"{CuentaLineasFicheros("txt")} líneas en ficheros txt");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine($"El fichero más pesado en la carpeta actual es {FicheroMasGrande()}");
                    }
                    break;
                case 7:
                    {
                        ClasificaFicheros();
                    }
                    break;
                default:
                    break;
            }
        }
        static void ShowMenu ()
        {
            Console.WriteLine("MENU");

            Console.WriteLine("1 - CuantosFicheros");
            Console.WriteLine("2 - CuantosFicherosPro");
            Console.WriteLine("3 - CreaBackup");
            Console.WriteLine("4 - RenombraMasivo");
            Console.WriteLine("5 - CuentaLineasFichero");
            Console.WriteLine("6 - FicheroMasGrande");
            Console.WriteLine("7 - ClasificaFicheros");

            Console.Write("Introduce una opción: ");
        }
        static int CuantosFicheros (string fileextension)
        {
            /*
                Escribe la función CuantosFicheros a la que le pasas una extensión de archivo y tedevuelve un entero que nos dice cuántos ficheros con esa extensión hay en el directorio actual.
                Ej.: CuantosFicheros(“txt”) nos dirá cuántos ficheros .txt hay.
             */
            int count = 0;
            string currentFolder = Directory.GetCurrentDirectory(), extension;
            string[] files = Directory.GetFiles(currentFolder);

            for (int i = 0; i < files.Length; i++)
            {
                extension = Path.GetExtension(files[i]);

                if (extension.Equals(fileextension))
                {
                    count++;
                }
            }

            return count;
        }
        static int CuantosFicherosPro (string fileextension, string path)
        {
            /*
                Escribe la función CuantosFicherosPro a la que le pasas una extensión de archivo y una carpeta y te dice cuántos archivos con esa extensión hay en esa carpeta.
                Ej.: CuantosFicherosPro(“txt”, “C:\\Windows”) nos dirá cuántos ficheros .txt hay en la carpeta C:\Windows.
             */
            int count = 0;
            string[] files = Directory.GetFiles(path);
            string extension;

            for (int i = 0; i < files.Length; i++)
            {
                extension = Path.GetExtension(files[i]);

                if (extension.Equals(fileextension))
                {
                    count++;
                }
            }

            return count;
        }
        static void CreaBackup (string path)
        {
            /*
                Escribe la función CreaBackup a la que le pasas un nombre de fichero. La función copiará ese fichero en otro al que le añadiremos la extensión “.bak” (para tener una copia de seguridad). Si el nuevo fichero existe, le añadiremos otra vez “.bak” hasta que encontremos un nombre de fichero disponible.
                Ej.: CreaBackup(“texto.txt”) copiará el fichero texto.txt a texto.txt.bak. Si este nombre existe, lo copiará a texto.txt.bak.bak, etc.
             */
            string fullname, backupName, backupPath;

            if (File.Exists(path))
            {
                fullname = Path.GetFileName(path);
                backupName = NewBackupName(fullname);
                backupPath = $"{Path.GetDirectoryName(path)}\\{backupName}";

                File.Copy(path, backupPath);
            }

        }
        static string NewBackupName (string fullname)
        {
            while (File.Exists(fullname))
            {
                fullname += ".bak";
            }

            return fullname;
        }
        static void RenombraMasivo (string ext, string newExt)
        {
            /*
                Escribe la función RenombraMasivo a la que le pasas dos extensiones de fichero. La función te renombrará todos los ficheros que haya en el directorio actual con la primera extensión y les pondrá la segunda extensión.
                Ej.: RenombraMasivo(“txt”, “texto”) renombrará todos los ficheros *.txt a *.texto.
             */
            string currentFolder = Directory.GetCurrentDirectory(), currentExt;
            string[] paths = Directory.GetFiles(currentFolder);

            for (int i = 0; i < paths.Length; i++)
            {
                currentExt = Path.GetExtension(paths[i]);

                if (currentExt.Equals($".{ext}"))
                {
                    ReplaceExt(paths[i], ext, newExt);
                }
            }

        }
        static void ReplaceExt (string path, string ext, string newExt)
        {
            string directory = Path.GetDirectoryName(path);
            string filename = Path.GetFileNameWithoutExtension(path);
            string newPath = $"{directory}\\{filename}.{newExt}";

            File.Move(path, newPath);
        }
        static int CuentaLineasFicheros (string ext)
        {
            /*
                Escribe la función CuentaLineasFicheros a la que le pasas una extensión y te cuenta el total de líneas que hay entre todos los ficheros con esa extensión que hay en la carpeta actual (esos ficheros deberían ser de texto, que si no va a contar poco). El resultado te lo devolverá en un entero.
                Ej.: CuentaLineasFicheros(“txt”) te suma las líneas que tienen todos los ficheros .txt de la carpeta actual.
             */
            int count = 0;
            string currentFolder = Directory.GetCurrentDirectory(), currentExt;
            string[] paths = Directory.GetFiles(currentFolder);

            for (int i = 0; i < paths.Length; i++)
            {
                currentExt = Path.GetExtension(paths[i]);

                if (currentExt.Equals($".{ext}"))
                {
                    count += File.ReadAllLines(paths[i]).Length;
                }
            }

            return count;
        }
        static string FicheroMasGrande ()
        {
            /*
             Escribe la función FicheroMasGrande que nos devuelve una cadena con el nombre del fichero de mayor tamaño que haya en la carpeta actual
             */
            string currentFolder = Directory.GetCurrentDirectory(), result = "";
            string[] paths = Directory.GetFiles(currentFolder);
            FileInfo f;
            long currentSize, size = 0;

            for (int i = 0; i < paths.Length; i++)
            {
                f = new FileInfo(paths[i]);
                currentSize = f.Length;

                if (currentSize > size)
                {
                    size = currentSize;
                    result = f.FullName;
                }
            }

            return result;
        }
        static void ClasificaFicheros ()
        {
            /*
                Escribe la función ClasificaFicheros que te clasifica todos los ficheros que hay en la carpeta actual de acuerdo a su extensión.
                    Ej.: Si en la carpeta actual están los ficheros: uno.txt, dos.txt, tres.exe, la función nos escribirá: txt => 2, exe => 1.
                La función no devolverá nada, sino que lo escribirá por pantalla con Console.WriteLine directamente.
             */
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string currentFolder = Directory.GetCurrentDirectory(), ext;
            string[] paths = Directory.GetFiles(currentFolder);

            for (int i = 0; i < paths.Length; i++)
            {
                ext = Path.GetExtension(paths[i]);

                if (dict.ContainsKey(ext))
                {
                    dict[ext]++;
                }
                else
                {
                    dict[ext] = 1;
                }
            }

            foreach (KeyValuePair<string, int> pair in dict)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }
    }
}
