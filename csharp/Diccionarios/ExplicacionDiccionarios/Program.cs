using System;
using System.Collections.Generic;

namespace ExplicacionDiccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Un diccionario es un array asociativo, es decir, una estructura de datos basada en elementos en formato clave - valor. también se pueden llamar mapas o tablas hash.
             */
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            dict1["patata"] = 5;
            dict1["tomate"] = 10;
            dict1["pimiento"] = 15;

            Console.WriteLine(dict1["tomate"]);

            Dictionary<string, string> capitales = new Dictionary<string, string>();

            capitales["España"] = "Madrid";
            capitales["Malasia"] = "Kuala Lumpur";
            capitales["Filipinas"] = "Manila";
            capitales["Alemania"] = "Berlín";

            Console.WriteLine(capitales["Filipinas"]);

            foreach (KeyValuePair<string, string> capital in capitales)
            {
                Console.WriteLine(capital);
            }
            
        }
    }
}
