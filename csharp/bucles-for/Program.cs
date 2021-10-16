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
            Console.WriteLine("El ejercicio debe ingresarse empleando dos dígitos: por ejemplo 07 para el ejercicio 7. Hay un total de 42 ejercicios.");
            Console.Write("Introduce una opción: ");
            string option = Console.ReadLine();
            Console.WriteLine("");

            switch (option)
            {
                case "01":
                    Estructurada01();
                    return true;
                case "02":
                    Estructurada02();
                    return true;
                case "03":
                    Estructurada03();
                    return true;
                case "04":
                    Estructurada04();
                    return true;
                case "05":
                    Estructurada05();
                    return true;
                case "06":
                    Estructurada06();
                    return true;
                case "07":
                    Estructurada07();
                    return true;
                case "08":
                    Estructurada08();
                    return true;
                case "09":
                    Estructurada09();
                    return true;
                case "10":
                    Estructurada10();
                    return true;
                case "11":
                    Estructurada11();
                    return true;
                case "12":
                    Estructurada12();
                    return true;
                case "13":
                    Estructurada13();
                    return true;
                case "14":
                    Estructurada14();
                    return true;
                case "15":
                    Estructurada15();
                    return true;
                case "16":
                    Estructurada16();
                    return true;
                case "17":
                    Estructurada17();
                    return true;
                case "18":
                    Estructurada18();
                    return true;
                case "19":
                    Estructurada19();
                    return true;
                case "20":
                    Estructurada20();
                    return true;
                case "21":
                    Estructurada21();
                    return true;
                case "22":
                    Estructurada22();
                    return true;
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
                case "40":
                    Estructurada40();
                    return true;
                case "41":
                    Estructurada41();
                    return true;
                case "42":
                    Estructurada42();
                    return true;
                case "exit":
                    return false;
                default:
                    return true;
            }
        }
    }
}
