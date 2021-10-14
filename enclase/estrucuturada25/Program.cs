using System;

namespace estrucuturada25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cont = 0;
            for ( i = 0; cont< 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    cont++;
                }
            }//for raro, mejor usar while
        }
    }
}
