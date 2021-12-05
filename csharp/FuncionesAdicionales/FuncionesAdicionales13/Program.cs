using System;

namespace FuncionesAdicionales13
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaNotaFinal(5);
        }
        static bool IsCorrect (double score)
        {
            bool isCorrect = true;

            if (score < 0 || score > 10)
            {
                isCorrect = false;
            }
            
            return isCorrect;
        }
        static void CalculaNotaFinal (int exams = 7)
        {
            /*
            Escribe el programa CalculaNotaFinal. El programa nos ira pidiendo 7 doubles correspondientes a las notas de los 7 exámenes que se hacen en una asignatura durante el curso. La nota final que nos escribirá por pantalla será la media de los 7 doubles, con una excepción: si hemos suspendido dos o más exámenes durante el curso, la nota final no superará el 4 aunque la media salga más alta. Por ejemplo: si las notas son [10, 10, 10, 10, 10, 2, 3], la media saldría 7’86, pero devolveríamos un 4 porque ha suspendido dos exámenes.
               El programa tendrá que controlar que cada nota introducida esté entre 0 y 10. Si no lo está, no la dará por válida y la volverá a pedir. 
            */
            double final = 0, current;
            int fails = 0;

            Console.WriteLine("Dime las notas de tus examenes (Pulsa intro después de introducir una nota):");

            for (int i = 0; i < exams; i++)
            {
                current = double.Parse(Console.ReadLine());

                if (IsCorrect(current))
                {
                    final += current;

                    if (current < 5)
                    {
                        fails++;
                    }
                }
                else
                {
                    Console.WriteLine("La última nota no era correcta, vuelve a introducirla.");
                    i--;
                }
            }

            final /= exams;

            if (fails >= 2)
            {
                final = final > 4 ? 4.0 : final;   
            }

            Console.WriteLine($"La nota final queda {final}");
        }
    }
}
