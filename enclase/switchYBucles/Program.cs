using System;

namespace switchYBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //int weekDay = 1;//1 Lunes, 2 martes, ...

            //switch (weekDay)//Le das un valor y estableces acciones en función de su valor.
            //{
            //    case 1:
            //        Console.WriteLine("Lunes");
            //        break;
            //    case 2:
            //        Console.WriteLine("Martes");
            //        break;
            //    case 3:
            //        Console.WriteLine("Miércoles");
            //        break;
            //    case 4:
            //        Console.WriteLine("Jueves");
            //        break;
            //    case 5:
            //        Console.WriteLine("Viernes");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sábado");
            //        break;
            //    case 7:
            //        Console.WriteLine("Domingo");
            //        break;
            //    default:
            //        Console.WriteLine("ERROR");
            //        break;
            //}

            //BUCLES INDEFINIDOS. BUCLE WHILE.

            //Console.WriteLine("Dime un número.");
            //int num = int.Parse(Console.ReadLine());

            //while (num != 5)
            //{
            //    Console.WriteLine("Ese número no me gusta, dame otro.");
            //    num = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Por el culo te la hinco!");

            //EJERCICIO: Pregunta la nota, si no está entre 0 y 10 pidela de nuevo.
            //double nota;

            //Console.WriteLine("Dame una nota.");

            //nota = Double.Parse(Console.ReadLine());

            //while (nota < 0 || nota > 10)
            //{
            //    Console.WriteLine("La nota no es correcta. Damela bien");
            //    nota = Double.Parse(Console.ReadLine());
            //}

            //if(nota >= 5)
            //{
            //    Console.WriteLine("Aprobado.");
            //}
            //else
            //{
            //    Console.WriteLine("Suspenso.");
            //}

            //EJERCICIO: Si la edad no está entre 0 y 125 no es válida. Si tiene más de 18 años "nos vamos de botellón" y si no nos bebemos un nestea.

            //int edad;

            //Console.WriteLine("dime tu edad");
            //edad = int.Parse(Console.ReadLine());

            //while(edad < 0 || edad > 125)
            //{
            //    Console.WriteLine("Esa edad es inposible, dime otra");
            //    edad = int.Parse(Console.ReadLine());
            //}

            //if(edad >= 18)
            //{
            //    Console.WriteLine("Vamonos a tomar unas birras");
            //}
            //else
            //{
            //    Console.WriteLine("Nos tomamos una coke");
            //}

            //Uso de contadores para repetir instrucciones con while.

            //int contador = 0;//NORMALMENTE EL CONTADOR SE LLAMA i, Y SE CONTINUA CON j, k, ...

            //while (contador < 10)
            //{
            //    Console.WriteLine("Hola");

            //    contador++;
            //}

            //EJERCICIO: Escribe los números pares hasta 20.

            //int i = 0;

            //while (i < 21)
            //{
            //    Console.WriteLine(i);
            //    i = i + 2;
            //}

            //EJERCICIO: Escribe lo números impares hasta 21.

            //int j = 1;

            //while (j < 22)
            //{
            //    Console.WriteLine(j);
            //    j = j + 2;
            //}

            //EJERCICIO: Escribe los múltiplos de 3 hasta 30.

            //int k = 0;

            //while(k < 31)
            //{
            //    Console.WriteLine(k);

            //    k = k + 3;
            //}

            //EJERCICIO: Escribe los números de 10 a 0.

            //int i = 10;

            //while (i >= 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //EJERCICIO: Múltiplos de 3 del 20 al cero.

            //int i = 18;//BUSCA EL NÚMERO MÁS CERCANO PARA EMPEZAR A CONTAR.

            //while (i >= 0)
            //{
            //    Console.WriteLine(i);

            //    i = i - 3;
            //}

            //EJERCICIO: Suma todos los números de 0 al 10.

            //int i = 0;
            //int suma = 0;//ESTE TIPO DE VARIABLES SE LLAMAN ACUMULADOR Y DEBEN TENER UN VALOR INICIAL PARA QUE SE PUEDA OPERAR CON ELLA.

            //while (i < 11)
            //{
            //    suma = suma + i;

            //    Console.WriteLine(suma);

            //    i++;
            //}

            //Console.WriteLine($"El total es {suma}.");

            //EJERCICIO: Dime los pares desde 1 hasta 20 pero usando un condicional en el bucle y dime cuántos hay.

            //int i = 1;
            //int cont = 0;

            //while (i < 21)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        cont++;
            //    }
                
            //    i++;
            //}

            //Console.WriteLine($"Hay {cont} números pares del 1 al 20.");
        }
    }
}
