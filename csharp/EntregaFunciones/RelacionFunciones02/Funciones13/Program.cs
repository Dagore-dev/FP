using System;

namespace Funciones13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función “NotaEnTexto” a la que le pasamos la nota de un alumno como un double y nos devolverá la calificación en formato texto(“aprobado”, “suficiente”, etc.).
        }
        static string NotaEnTexto (double score)
        {
            string result;

            if (score >= 0 && score <= 10)
            {
                if (score < 5)
                {
                    result = "Suspenso";
                }
                else if (score < 6)
                {
                    result = "Suficiente";
                }
                else if (score < 7)
                {
                    result = "Bien";
                }
                else if (score < 9)
                {
                    result = "Notable";
                }
                else result = "Sobresaliente";
            }
            else
            {
                result = "ERROR";
            }

            return result;
        }
    }
}
