using System;
using System.Text;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "La pelicula del verano es OPERACIÓN CAMARÓN", s2 = " Esto    simplemente  tiene muchos   espacios ";

            Console.WriteLine($"\"{s1}\" => \"{MayusculasAlternas(s1)}\"");
            Console.WriteLine($"\"{s2}\" => \"{MayusculasAlternas(s2)}\"");
        }
        static string MayusculasAlternas (string s)
        {
            string[] splitted = s.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitted.Length; i++)
            {
                splitted[i] = MayusculasAlternasPalabra(splitted[i]);
            }

            return string.Join(' ', splitted);
        }
        static string MayusculasAlternasPalabra (string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(char.ToUpper(s[i]));
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
