using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            SerieNumerosPro(1, 9, 4);
            Console.WriteLine();
            SerieNumerosPro(4, 1, 9);
        }
        static void SerieNumerosPro (int a, int b, int c)
        {
            string stepOne, stepTwo, stepThree, stepFour;
            int nextOne, nextTwo;

            nextOne = b < c ? b + 1 : b - 1; 
            stepOne = Step(a, b);
            stepTwo = Step(nextOne, c);

            nextTwo = b < a ? b + 1 : b - 1;
            stepThree = Step(c, b);
            stepFour = Step(nextTwo, a);

            Console.WriteLine(stepOne + stepTwo);
            Console.WriteLine(stepThree + stepFour);

        }
        static string Step (int a, int b)
        {
            string result;

            if (a < b)
            {
                result = SerieNumerosAscendente(a, b);
            }
            else
            {
                result = SerieNumerosDescendente(a, b);
            }

            return result;
        }
        static string SerieNumerosAscendente (int a, int b)
        {
            string result = "";

            for (int i = a; i <= b; i++)
            {
                result += i + " ";
            }

            return result;
        }
        static string SerieNumerosDescendente (int a, int b)
        {
            string result = "";

            for (int j = a; j >= b; j--)
            {
                result += j + " ";
            }

            return result;
        }
    }
}
