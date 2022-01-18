using System;
using System.IO;

namespace FicherosAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeArrays(CuentaVocalesFichero("lazarillo.txt"));
        }
        #region utils
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
    }
}
