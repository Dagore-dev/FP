using System;

namespace EntregaCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            ShowMenu();

            Console.Write("Introduce la opción escogida: ");
            option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    {
                        string s = "Hola, me llamo David.";

                        Console.WriteLine($"La cadena \"{s}\" tiene {NumeroEspacios(s)} espacios.");
                    }
                    break;
                case 2:
                    {
                        string s = "Hola, me llamo David.";

                        Console.WriteLine($"La cadena \"{s}\" tiene {NumeroVocales(s)} vocales.");
                    }
                    break;
                case 3:
                    {

                    }
                    break;
                case 4:
                    {

                    }
                    break;
                case 5:
                    {

                    }
                    break;
                case 6:
                    {

                    }
                    break;
                case 7:
                    {

                    }
                    break;
                case 8:
                    {

                    }
                    break;
                case 9:
                    {

                    }
                    break;
                case 10:
                    {

                    }
                    break;
                default:
                    break;
            }

        }
        static void ShowMenu ()
        {
            Console.WriteLine(" 1 - NumeroEspacios");
            Console.WriteLine(" 2 - NumeroVocales");
            Console.WriteLine(" 3 - EsPalindromo");
            Console.WriteLine(" 4 - Contiene");
            Console.WriteLine(" 5 - RepiteCaracter");
            Console.WriteLine(" 6 - QuitaEspacios");
            Console.WriteLine(" 7 - QuitaEspaciosTrim");
            Console.WriteLine(" 8 - SustituyeCaracter");
            Console.WriteLine(" 9 - CuentaPalabras");
            Console.WriteLine("10 - EsNumero");
            Console.WriteLine(" 0 - Salir");
        }
        static int NumeroEspacios (string s)
        {
            //Escribe la función “NumeroEspacios” a la que le pasamos una cadena y nos devuelve el número de espacios que contiene esa cadena(tanto al principio como al final e intercalados).

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    result++;
                }
            }

            return result;
        }
        static int NumeroVocales (string s)
        {
            //Escribe la función “NumeroVocales” a la que le pasamos una cadena y nos devuelve el número de vocales que hay en la cadena.

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    result++;
                }
            }

            return result;
        }

    }
}
