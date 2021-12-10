using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hola Don Pepito", s2 = "Oro parece, plátano es", s3 = "a", s4 = "ll", s5 = "LL";
            
            Console.WriteLine($"\"{s1}\" => {ConsonantesSeguidas(s1)}");
            Console.WriteLine($"\"{s2}\" => {ConsonantesSeguidas(s2)}");
            Console.WriteLine($"\"{s3}\" => {ConsonantesSeguidas(s3)}");
            Console.WriteLine($"\"{s4}\" => {ConsonantesSeguidas(s4)}");
            Console.WriteLine($"\"{s5}\" => {ConsonantesSeguidas(s5)}");
        }
        static bool ConsonantesSeguidas (string s)
        {
            string sample = s.ToLower();
            string consonantes = "bcdfghjklmnñpqrstvwxyz";
            bool result = false;

            if (sample.Length > 1)
            {
                for (int i = 0; i < sample.Length - 1; i++)
                { 
                    if (consonantes.Contains(sample[i]) && consonantes.Contains(sample[i + 1]))
                    {
                        result = true;
                        i = sample.Length;
                    }
                }
            }

            return result;
        }
    }
}
