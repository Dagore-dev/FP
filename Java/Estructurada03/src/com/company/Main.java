package com.company;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {
    public static Double convert (Double value, String optionInput) {
        Map<String, Double> table = new HashMap<>();
        table.put("1", 166.3836);
        table.put("2", 1/166.3836);

        return value * table.get(optionInput);
    }
    public static String outputMsg (String optionInput) {
        Map<String, String> table = new HashMap<>();
        table.put("1", "%s euros equivalen a %s pesetas.");
        table.put("2", "%s pesetas equivalen a %s euros.");

        return table.get(optionInput);
    }
    public static void main(String[] args) {
        //Crear Scanner.
        Scanner terminal = new Scanner(System.in);

        //Declarar variables.
        String optionInput, doubleInput, outputString;
        boolean fitOptions, isParsable;
        double value, result;

        //Inicio del programa, selección del modo.
        System.out.println("Elige una de las conversiones de moneda disponibles.");
        System.out.println("Escribe 1 para convertir euros a pesetas");
        System.out.println("Escribe 2 para convertir pesetas a euros");
        System.out.println("Escribe otra cosa para finalizar el programa.");
        optionInput = terminal.nextLine();

        //Patrón de las opciones.
        Pattern optionPattern = Pattern.compile("^[12]$");
        Matcher optionMatcher = optionPattern.matcher(optionInput);
        fitOptions = optionMatcher.matches();

        //Desarrollo de la solución.
        if (fitOptions) {
            //Cantidad a convertir.
            System.out.println("Introduzca la cantidad de la moneda que desea convertir.");
            doubleInput = terminal.nextLine();

            //Patrón de un número real.
            Pattern doublePattern = Pattern.compile("^-?[0-9]+\\.?[0-9]*$");
            Matcher doubleMatcher = doublePattern.matcher(doubleInput);
            isParsable = doubleMatcher.matches();

            //Si se ha introducido un número real continuamos con el desarrollo.
            if (isParsable) {
                //Conversión del input a número real.
                value = Double.parseDouble(doubleInput);

                //Llamada al método convert para obtener el resultado.
                result = convert(value, optionInput);

                //Llamada al método output para generar el mensaje de salida.
                outputString = outputMsg(optionInput);

                //Salida de la aplicación.
                System.out.printf(outputString,value, result);
            }
            else{
                System.out.println("Introduzca como cantidad un número real.");
            }
        }
        else{
            System.out.println("Finalizando el programa");
        }

    }
}
