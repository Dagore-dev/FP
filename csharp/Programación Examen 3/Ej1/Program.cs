using System;
using System.IO;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneraServidorDHCP("dhcp.txt", 1000);
        }
        static void GeneraServidorDHCP (string path, int n)
        {
            string[] ips = GenerateIps(n);
            StreamWriter sr = new StreamWriter(path);

            sr.WriteLine("subnet 10.0.0.0 netmask 255.0.0.0 {");

            for (int i = 0; i < n; i++)
            {
                sr.WriteLine($"\trange {ips[i]};");
            }

            sr.WriteLine("}");

            sr.Close();
        }
        static string[] GenerateIps (int n)
        {
            Random r = new Random();
            string[] ips = new string[n];
            string ip;

            for (int i = 0; i < ips.Length; i++)
            {
                ip = $"10.{r.Next(0,256)}.{r.Next(0, 256)}.{r.Next(0, 256)}";

                if (!Contiene(ips, ip))
                {
                    ips[i] = ip;
                }
                else
                {
                    i--;
                }
            }

            return ips;
        }
        static bool Contiene(string[] a, string s)
        {
            int i = 0;
            bool result = false;

            while (i < a.Length && result == false)
            {
                if (a[i] == s)
                {
                    result = true;
                }
                i++;
            }

            return result;
        }
    }
}
