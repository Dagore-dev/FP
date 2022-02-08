using System;
using System.Collections.Generic;
using System.IO;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneraServidorDHCP("dhcp.txt", 1000000);
        }
        static void GeneraServidorDHCP (string path, int n)
        {
            HashSet<string> ips = GenerateIps(n);
            StreamWriter sr = new StreamWriter(path);

            sr.WriteLine("subnet 10.0.0.0 netmask 255.0.0.0 {");

            foreach (string ip in ips)
            {
                sr.WriteLine($"\trange {ip};");
            }

            sr.WriteLine("}");

            sr.Close();
        }
        static HashSet<string> GenerateIps (int n)
        {
            Random r = new Random();
            HashSet<string> ips = new HashSet<string>();
            string ip;

            while (ips.Count < n)
            {
                ip = $"10.{r.Next(0, 256)}.{r.Next(0, 256)}.{r.Next(0, 256)}";

                if (!ips.Contains(ip))
                {
                    ips.Add(ip);
                }
            }
            
            return ips;
        }
    }
}
