package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
	    //Determinar si un año es bisiesto o no (los años bisiestos son múltiplos de 4; utilícese el operador módulo).

        //Creamos el scanner.
        Scanner terminal = new Scanner(System.in);

        //Declaramos las variables.
        String input;
        boolean isParsable;
        int year;

        //Inicio del programa y lectura de la terminal.
        System.out.println("Introduzca un año para comprobar si es bisiesto.");
        input = terminal.nextLine();

        //Comprobando el input.
        Pattern pattern = Pattern.compile("^[0-9]+$");
        Matcher matcher = pattern.matcher(input);
        isParsable = matcher.matches();

        if (isParsable) {
            year = Integer.parseInt(input);

            if ((year % 4) == 0) {
                System.out.printf("El año %s es bisiesto.",year);
            }
            else{
                System.out.printf("El año %s NO es bisiesto.", year);
            }
        }
        else {
            System.out.println("Por favor, introduzca un input válido.");
        }
    }
}
