using System;
using System.Collections.Generic;

namespace ExplicacionRegistros
{
    class Program
    {
        struct Car
        {
            string carPlate;
            string brand;
            string model;
            bool isElectric;
            int kilometers;
        }
        public class Coche
        {
            public string matricula;
            public string marca;
            public string modelo;
            public bool esElectrico;
            public int numeroKilometros;
        }
        static void Main(string[] args)
        {
            /*
            Cada cosa que se mete en una base de datos es un registro (tambien llamado tupla), una estructura de datos que contiene datos de distintos tipos. Habitualmente no guardan una gran cantidad de datos.
            Ejemplo:

            struct Coche
            {
                string matricula;
                string marca;
                string modelo;
                bool esElectrico;
                int numeroKilimetros;
            }

            Los struct en C# dan problemas porque son bastante arcaicos. Vamos a usar clases como si fueran registros para evitar problemas.
             */
            Coche c1 = new Coche();
            Coche c2 = new Coche();
            List<Coche> l = new List<Coche>();    
            
            c1.matricula = "8745BCD";
            c1.marca = "Fiat";
            c1.modelo = "500";
            c1.esElectrico = false;
            c1.numeroKilometros = 200000;

            c2.matricula = "9879PPK";
            c2.marca = "Rover";
            c2.modelo = "400";
            c2.esElectrico = false;
            c2.numeroKilometros = 256787;

            l.Add(c1);
            l.Add(c2);

            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine($"{l[i].marca} {l[i].modelo}");
            }
        }
    }
}
