package com.company;

public class Main {

    public static void main(String[] args) {
        //Enteros
        //Definir la variable
        int entero;
        //Inicializar la variable
        entero = 2;
        //Usar la variable
        System.out.println(entero);
        //Modificar la variable
        entero = entero + 1;
        // también valdría con el operador +=: entero += 1;
        System.out.println(entero);

        //Reales
        //Definir variables
        double real = 1.23;
        System.out.println(real);
        //También puede modificarlos
        real = real * 2;
        System.out.println(real);

        //Caracteres
        char unaLetra = 'A';//almacena un único caracter metiendolo en comillas simples.
        System.out.println(unaLetra);
        System.out.println((char)(unaLetra + 1));//Imprime el siguiente caracter en la tabla.

        //Cadenas
        String texto = "Hola Xavi!";//Esto no es un tipo simple, es decir no ocupa un solo bit.
        System.out.println(texto);
        //Concatenación de cadenas
        String pregunta = " Qué tal?";
        System.out.println(texto + pregunta);
        //Boolean (true / false; 1 / 0; ...)
        boolean valor = true;
        System.out.println(!valor);//Imprime lo contrario al valor con el operador !
    }
}
