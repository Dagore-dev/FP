package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
	    //Leídos dos enteros por teclado, A y B, calcular la resta del mayor menos el menor. Por ejemplo, si A = 8 y B = 3, el resultado debe ser A – B, es decir, 5. Pero si A = 4 y B = 7, el resultado debe ser B – A, es decir, 3.

        //Creamos el scanner.
        Scanner terminal = new Scanner(System.in);

        //Declaración de las variables.
        String inputA, inputB;
        boolean isAparsable, isBparsable;
        int a,b, result;

        //Inicio del programa y entrada de valores.
        System.out.println("Introduce el número A.");
        inputA = terminal.nextLine();
        System.out.println("Introduce el número B.");
        inputB = terminal.nextLine();

        //Comprobando los inputs.
        Pattern pattern = Pattern.compile("^[0-9]+$");
        //Comprobación para el inputA.
        Matcher inputAMatcher = pattern.matcher(inputA);
        isAparsable = inputAMatcher.matches();
        //Comprobación para el inputB.
        Matcher inputBMatcher = pattern.matcher(inputB);
        isBparsable = inputBMatcher.matches();
        
        if(isAparsable && isBparsable) {
            //String to int.
            a = Integer.parseInt(inputA);
            b = Integer.parseInt(inputB);
            
            //Resolución del problema.
            result = Math.abs(a - b);
            System.out.printf("Para A igual a %s y b igual a %s, su resta en valor absoluto es %S",a,b,result);
        }
        else{
            System.out.println("Por favor, introduzca un input válido.");
        }

    }
}
