using System;

namespace bucles_for
{
    partial class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Elige el ejercicio de programación estructurada que quieres comprobar o exit para salir.");
            Console.WriteLine("El ejercicio debe ingresarse empleando dos dígitos: por ejemplo 07 para el ejercicio 7.");
            Console.Write("\nIntroduce una opción: ");
            string option = Console.ReadLine();
            Console.WriteLine("");

            switch (option)
            {
                case "23":
                    Estructurada23();
                    return true;
                case "24":
                    Estructurada24();
                    return true;
                case "25":
                    Estructurada25();
                    return true;
                case "26":
                    Estructurada26();
                    return true;
                case "27":
                    Estructurada27();
                    return true;
                case "28":
                    Estructurada28();
                    return true;
                case "29":
                    Estructurada29();
                    return true;
                case "30":
                    Estructurada30();
                    return true;
                case "31":
                    Estructurada31();
                    return true;
                case "32":
                    Estructurada32();
                    return true;
                case "33":
                    Estructurada33();
                    return true;
                case "34":
                    Estructurada34();
                    return true;
                case "35":
                    Estructurada35();
                    return true;
                case "36":
                    Estructurada36();
                    return true;
                case "37":
                    Estructurada37();
                    return true;
                case "38":
                    Estructurada38();
                    return true;
                case "39":
                    Estructurada39();
                    return true;
                case "exit":
                    return false;
                default:
                    return true;
            }
        }
    }
}
