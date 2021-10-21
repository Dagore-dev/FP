using System;

namespace Funciones01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

        }

        /// <summary>
        /// Return true if number is even, false otherwise.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Return true if number is even, false otherwise.</returns>
        static bool IsEven (int number)
        {
            bool result;

            if (number % 2 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            
            return result;
        }

        /// <summary>
        /// Returns true is the fiven year is a leap-year. Otherwise return false.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Returns true is the fiven year is a leap-year. Otherwise return false.</returns>
        static bool IsLeapYear (int year)
        {
            bool isLeapYear;

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    isLeapYear = false;
                }
                else
                {
                    isLeapYear = true;
                }
            }
            else
            {
                isLeapYear = false;
            }

            return isLeapYear;
        }
        /// <summary>
        /// Write the multiplication table of a given number.
        /// </summary>
        /// <param name="number"></param>
        static void MultiplicationTable (int number)
        {
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        /// <summary>
        /// Given two integers write the numbers between.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        static void PrintSeries (int num1, int num2)
        {
            if (num1 > num2)
            {
                for (int i = num1; i >= num2; i--)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                for (int j = num1; j <= num2; j++)
                {
                    Console.Write($"{j} ");
                }
            }
        }
        /// <summary>
        /// Given a integer, return 1 when is possitive, 0 when is zero and -1 when is negative.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Return 1 when is possitive, 0 when is zero and -1 when is negative.</returns>
        static int Sign (int number)
        {
            int result;

            if (number > 0)
            {
                result = 1;
            }
            else
            {
                if (number == 0)
                {
                    result = 0;
                }
                else
                {
                    result = -1;
                }
            }

            return result;
        }
        /// <summary>
        /// Given two integers, returns the max value.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Returns the max integer.</returns>
        static int MaxInt (int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        /// <summary>
        /// Given two doubles, returns the max value.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Returns the max double.</returns>
        static double MaxDouble(double num1, double num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        /// <summary>
        /// Given two integers, returns the min value.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Returns the min integer.</returns>
        static int MinInt(int num1, int num2)
        {
            return num1 < num2 ? num1 : num2;
        }
        /// <summary>
        /// Given two doubles, returns the min value.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Returns the min double.</returns>
        static double MinDouble (double num1, double num2)
        {
            return num1 < num2 ? num1 : num2;
        }
        /// <summary>
        /// Given two integers, returns the mcm.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Returns the mcm.</returns>
        static int Mcm (int num1, int num2)
        {
            int i = MaxInt(num1, num2);

            while (i % num1 != 0 || i % num2 != 0)//El mcm cumple que i % a == 0 && i % b == 0.
            {
                i++;
            }

            return i;
        }
        /// <summary>
        /// Given two integers, returns the MCD.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Returns the MCD.</returns>
        static int MCD (int num1, int num2)
        {
            return (num1 * num2) / Mcm(num1, num2);
        }
        static bool isPrime (int number)
        {
            bool result;
            int counter = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
