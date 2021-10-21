using System;

namespace Funciones02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }
        /// <summary>
        /// Given base and height in double, returns the triangle area.
        /// </summary>
        /// <param name="ground"></param>
        /// <param name="height"></param>
        /// <returns>Returns triangle area.</returns>
        static double TriangleArea(double ground, double height)
        {
            return (ground * height) / 2;
        }
        /// <summary>
        /// Given inches in double, returns it in centimeters.
        /// </summary>
        /// <param name="inches"></param>
        /// <returns>Returns the inches in centimeters.</returns>
        static double InchesToCentimeters (double inches)
        {
            return inches * 2.54;
        }
        /// <summary>
        /// Given centimeters in double, returns it in inches.
        /// </summary>
        /// <param name="centimeters"></param>
        /// <returns>Returns the centimeters in inches.</returns>
        static double CentimetersToInches(double centimeters)
        {
            return centimeters / 2.54;
        }
        /// <summary>
        /// Given a score in double, returns a string with "Suspenso" if is lower than 5, "Suficiente" until 6 (excluding), "Bien" ultil 7, "Notable" until 9 and "Sobresaliente" until 10.
        /// </summary>
        /// <param name="score"></param>
        /// <returns>Returns a string with the range of the score.</returns>
        static string ScoreInText (double score)
        {
            string result;

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

            return result;
        }

    }
}
