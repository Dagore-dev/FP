using System;
using System.IO;

namespace ExplicacionFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Lo primero siempre será crear o abrir un fichero para trabajar con él. Estas operaciones están mediadas por el sistema operativo, que realiza la operación por nosotros y nos pasa una referencia para que podamos acceder a este.
                Cuando queremos leer o escribir el archivo también se implica el sistema operativo, la diferencia brutal de velocidades entre la CPU y el disco duro hace que realmente cuando pedimos escribir no lo hagamos directamente, sino que se graba en caché y se irá copiando al disco duro "cuando se pueda".
                Después hay que cerrar el fichero, paso muy importante porque el cierre del archivo ordena que se grabe la información en el disco y que otros usuarios o nosotros mismo más adelante en el programa podamos acceder al archivo.
             */
            /*
                Básicamente se diferencia dos tipos de archivos: de texto y binarios. Un PDF o un word NO es texto, para comprobarlo abrelo con blog de notas y verás que contiene todo tipo de extraños caracteres. Los archivos xml, css, html, txt, cs, json, log, init ... son archivos de texto.
             */
            /*
             Técnicamente un fichero se puede modificar pero actualmente lo normal es leerlo y machacarlo.
             */
            /*
            //1 - Abrir fichero para escritura => Creamos "prueba.txt", el archivo se va a crear por defecto dentro del proyecto en la carpeta .\bin\Debub\netcoreapp3
            StreamWriter streamWriter = new StreamWriter("prueba.txt");//admite un segundo parametro booleano append para que el comportamiento sea agregar al final del fichero.

            //2 - Escribir en el fichero:
            streamWriter.WriteLine("Buenos días in the morning.");

            for (int i = 0; i < 10; i++)
            {
                streamWriter.Write(i + " ");
            }

            //3 - Cerrar el fichero:
            streamWriter.Close();
            */

            //Leer un fichero
            StreamReader streamReader = new StreamReader("prueba.txt");

            string line1;

            for (int i = 0; i < 2; i++)//Esto porque sé que tiene 2 líneas, pero si no lo sé pues seguramente haría otra cosa. Las líneas que no existen devuelven null y se pintan en blanco en consola.
            {
                line1 = streamReader.ReadLine();
                Console.WriteLine(line1);
            }

            Console.WriteLine();
            Console.WriteLine("Ahora con un while");
            Console.WriteLine();

            while (!streamReader.EndOfStream)//EndOfStream devuelve true cuando llegue al final del string. Como con el for hemos llegado al final sin comentarlo esto no imprime nada.
            {
                line1 = streamReader.ReadLine();
                Console.WriteLine(line1);
            }

            streamReader.Close();

            //Funciones con ficheros
            EscribeFichero("miFichero.txt");
        }
        static void EscribeFichero (string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename);

            streamWriter.WriteLine("Escrito desde una función.");

            streamWriter.Close();
        }
    }
}
