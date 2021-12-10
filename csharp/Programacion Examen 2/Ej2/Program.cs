using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeArrays(ArrayCuadrados(10));
            EscribeArrays(ArrayCuadrados(5));
            EscribeArrays(ArrayCuadrados(0));
            EscribeArrays(ArrayCuadrados(-5));
        }
        static void EscribeArrays(int[] a)
        {
            string result = "";

            if (a.Length > 0)
            {
                result += "[";

                for (int i = 0; i < a.Length - 1; i++)
                {
                    result += a[i] + ", ";
                }

                result += $"{a[a.Length - 1]}]";
            }
            else
            {
                result += "[]";
            }

            Console.WriteLine(result);
        }
        static int[] ArrayCuadrados (int n)
        {
            int[] result;

            if (n > 0)
            {
                result = new int[n];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = (i + 1) * (i + 1);
                }
            }
            else
            {
                Console.WriteLine("ERROR");
                result = new int[0];
            }

            return result;
        }
    }
}
