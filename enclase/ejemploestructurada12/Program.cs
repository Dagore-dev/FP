using System;

namespace ejemploestructurada12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cont;
            i = 10;
            cont = 0;

            while(cont < 5)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                    cont++;
                }
            }i++;
        }
    }
}
