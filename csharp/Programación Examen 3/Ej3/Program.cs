using System;
using System.IO;
using System.Text;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            InvierteMayusculas("ficheros/laregenta.txt", "ficheros/laregentainv2.txt");
        }
        static void InvierteMayusculas (string path1, string path2)
        {
            StreamReader sr = new StreamReader(path1);
            StreamWriter sw = new StreamWriter(path2);
            string line;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                sw.WriteLine(InvierteMayusculasLinea(line));
            }

            sw.Close();
            sr.Close();
        }
        static string InvierteMayusculasLinea (string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                if (IsUpper(line[i]))
                {
                    sb.Append(char.ToLower(line[i]));
                }
                else
                {
                    sb.Append(char.ToUpper(line[i]));
                }
            }

            return sb.ToString();
        }
        static bool IsUpper (char c)
        {
            return c == char.ToUpper(c);
        }
    }
}
