package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        String input;
        double centimeters, allInInches, inches;
        int feet;

        //Constantes para el problema.
        double centimetersToInches = 2.54;
        int inchesToFeet = 12;

        //Scanner para ver la terminal.
        Scanner terminal = new Scanner(System.in);

        //Empieza el programa.
        System.out.println("Introduce un número en centímetros");

        input = terminal.nextLine();//Lee la siguiente línea de la terminal.

        //Expresión regular.
        Pattern pattern = Pattern.compile("^([0-9]+\\.?[0-9]*|\\.[0-9]+)$", Pattern.CASE_INSENSITIVE);
        Matcher matcher = pattern.matcher(input);

        boolean isParsable = matcher.find();//True si es un número decimal, false en el contrario.

        if (isParsable) {

            centimeters = Double.parseDouble(input);
            allInInches = centimeters / centimetersToInches;
            feet = (int) Math.floor(allInInches / inchesToFeet);
            inches = allInInches % inchesToFeet;

            System.out.println("El número " + centimeters + " en el sistema americano es igual a " + feet + " pies " + "y " + inches + " pulgadas.");
        }
        else {
            System.out.println("Introduzca un input válido.");
        }

    }
}