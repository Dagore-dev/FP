using System;
using System.IO;

namespace ExplicacionBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Los ficheros binarios contienen bytes. Esto hace que tengamos que usar funciones para leer y escribir bytes.
            Los int ocupan 4 bytes (32 bits) con el byte más pequeño a la izquierda y el más grande a la derecha (recibe el nombre de little-endian)
            Los doubles ocupan 8 bytes (64bits) (formato IEEE 754)
            Los char ocupan de 1 - 4 bytes, es extensible según la cantidad de caracteres que necesitemos.
            Los string primero indican su tamaño y luego el tamaño de cada char que contiene
            hexed.it editor de binario
             */

            FileStream fileStream = new FileStream("binario.bin", FileMode.Create);
            //FileStream fileStream2 = new FileStream("binario.bin", FileMode.Open);//Tambien está el OpenAndCreate y el Append
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);

            for (int i = 0; i < 5; i++)
            {
                binaryWriter.Write(i);
            }

            binaryWriter.Write(0.1);
            binaryWriter.Write("un texto");

            binaryWriter.Close();
            fileStream.Close();

            FileStream fileStream2 = new FileStream("binario.bin", FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileStream2);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(binaryReader.ReadInt32());
            }

            Console.WriteLine(binaryReader.ReadDouble());
            Console.WriteLine(binaryReader.ReadString());

            //Con fileStream2.Position se sabe por qué byte vamos y se puede asignar uno concreto, se puede rebobinar igualandolo a cero.

            binaryReader.Close();
            fileStream2.Close();
        }
        static void LeeBinarioEnteros (string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Console.WriteLine(br.ReadInt32());
            }

            br.Close();
            fs.Close();
        }
    }
}
