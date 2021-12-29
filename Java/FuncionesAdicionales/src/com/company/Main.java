package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int option;

        ShowMenu();

        option = Integer.parseInt(sc.nextLine());

        switch (option) {
            case 1 -> {
                int n1 = 6, n2 = 19, n3 = 27, n4 = 4, n5 = 25;

                System.out.printf("%s y %s = %s\n", n1, n2, PrimosRelativos(n1, n2));//true expected
                System.out.printf("%s y %s = %s\n", n1, n3, PrimosRelativos(n1, n3));//false expected
                System.out.printf("%s y %s = %s\n", n4, n5, PrimosRelativos(n4, n5));//true expected
            }
            case 2 -> {
                double temp1 = 0.0;

                System.out.printf("%s ºC en Fahrenheit = %s \n", temp1, CentigradosAFahrenheit(temp1));
                System.out.printf("%s Fahrenheit en ºC = %s \n", temp1, FahrenheitACentigrados(temp1));
            }
            case 3 -> {
                double change1 = 4.99, change2 = 3.95, change3 = 0, change4 = 2.5, change5 = 3.01;

                System.out.printf("TOTAL %s => \n", change1);
                Calderilla(change1);
                System.out.println("-------------------------");
                System.out.printf("TOTAL %s => \n", change2);
                Calderilla(change2);
                System.out.println("-------------------------");
                System.out.printf("TOTAL %s => \n", change3);
                Calderilla(change3);
                System.out.println("-------------------------");
                System.out.printf("TOTAL %s => \n", change4);
                Calderilla(change4);
                System.out.println("-------------------------");
                System.out.printf("TOTAL %s => \n", change5);
                Calderilla(change5);
            }
            case 4 -> {
                int num1 = 0, num2 = 1, num3 = 5, num4 = -7;

                System.out.printf("%s => %s = %s\n", num1, Math.pow(num1, 2), Potencia2(num1));
                System.out.printf("%s => %s = %s\n", num2, Math.pow(num2, 2), Potencia2(num2));
                System.out.printf("%s => %s = %s\n", num3, Math.pow(num3, 2), Potencia2(num3));
                System.out.printf("%s => %s = %s\n", num4, Math.pow(num4, 2), Potencia2(num4));
            }
            case 5 -> {
                TrianguloEstrellitas(3);
                TrianguloEstrellitas(11);
                TrianguloEstrellitas(20);
                TrianguloEstrellitas(2);
                TrianguloEstrellitas(21);
            }
            case 6 -> {
                Rombo(4);
                Rombo(10);
            }
            case 7 -> System.out.println("Aún no implementado.");
            case 8 -> {
                CuadraditoEstrellitas(0);
                CuadraditoEstrellitas(4);
                CuadraditoEstrellitas(20);
                CuadraditoEstrellitas(21);
            }
            case 9 -> BisiestosXXI();
            case 10 -> EscribeSerieNumeros3();
            case 11 -> {
                int n1 = 5, n2 = 10, n3 = 500;

                System.out.printf("%s %s %s\n", n1, n2, n3);
                System.out.printf("Máximo = %s\n", Maximo(n1, n2, n3));
                System.out.printf("Mínimo = %s\n", Minimo(n1, n2, n3));
                System.out.printf("Medio = %s\n", Medio(n1, n2, n3));
            }
            case 12 -> {
                Romboide(5,7);
                Romboide(3,10);
            }
        }
    }
    static void ShowMenu () {
        System.out.println(" 1 - Primos Relativos.");
        System.out.println(" 2 - CentigradosAFahrenheit y FahrenheitACentigrados.");
        System.out.println(" 3 - Calderilla.");
        System.out.println(" 4 - Potencia2.");
        System.out.println(" 5 - TrianguloEstrellitas.");
        System.out.println(" 6 - Rombo.");
        System.out.println(" 7 - CalendarioGrafico (NOT YET).");
        System.out.println(" 8 - CuadradoEstrellitas.");
        System.out.println(" 9 - BisiestosXXI.");
        System.out.println("10 - EscribeSerieNumeros3.");
        System.out.println("11 - Maximo, Minimo y Medio.");
        System.out.println("12 - Romboide.");
        System.out.print("Introduce una opción: ");
    }
    static boolean PrimosRelativos (int n1, int n2) {
        //Escribe una función PrimosRelativos a la que le pasas dos números enteros y te dice si son primos relativos, es decir, si no tienen ningún divisor común además del 1
        boolean result = true;
        int max = Math.max(n1, n2), min = Math.min(n1, n2);

        for (int i = 2; i < min; i++) {
            if (max % i == 0 && min % i == 0) {
                result = false;
                i = min;
            }
        }

        return  result;
    }
    static double CentigradosAFahrenheit (double temp) {
        //La función tendrá un parámetro, que será un número real, y devolverá otro número real. La fórmula es: Temp.(F)=1,8*Temp.(C°)+32.
        return 1.8 * temp + 32;
    }
    static double FahrenheitACentigrados (double temp) {
        //La función tendrá un parámetro, que será un número real, y devolverá otro número real. La fórmula es: Temp.(C)=(Temp.(F)-32)/1,8.
        return (temp - 32)/1.8;
    }
    static void Calderilla (double money) {
        //Escribe la función Calderilla a la que le pasamos una cantidad de dinero (menor de 5 €, puede tener decimales) y nos muestra por pantalla qué monedas debemos usar para dar el cambio (con el menor número posible de monedas).
        double moneyInCents = money * 100;
        int twoE = 0, oneE = 0, fifty = 0, twenty = 0, ten = 0, five = 0, two = 0, one = 0;

        while (moneyInCents > 0) {
            if (moneyInCents >= 200) {
                moneyInCents -= 200;
                twoE++;
            }
            else if (moneyInCents >= 100) {
                moneyInCents -= 100;
                oneE++;
            }
            else if (moneyInCents >= 50) {
                moneyInCents -= 50;
                fifty++;
            }
            else if (moneyInCents >= 20) {
                moneyInCents -= 20;
                twenty++;
            }
            else if (moneyInCents >= 10) {
                moneyInCents -= 10;
                ten++;
            }
            else if (moneyInCents >= 5) {
                moneyInCents -= 5;
                five++;
            }
            else if (moneyInCents >= 2) {
                moneyInCents -= 2;
                two++;
            }
            else {
                moneyInCents -= 1;
                one++;
            }
        }

        System.out.printf("2 euros = %s\n1 euro = %s\n50 céntimos = %s\n20 céntimos = %s\n10 céntimos = %s\n5 céntimos = %s\n2 céntimos = %s\n1 céntimo = %s\n", twoE, oneE, fifty, twenty, ten, five, two, one);

    }
    static int Potencia2 (int num) {
        //Escribe una función Potencia2 que te devuelva la potencia de 2 del número que le pasas por parámetro (ambos enteros). El valor del parámetro tendrá que ser 0 (un caso especial) o un número positivo. Si se le manda un número negativo, la función devolverá -1. No se podrá utilizar la función Math.Pow()
        int result;

        if (num < 1) {
            result = -1;
        }
        else {
            result = num * num;
        }

        return result;
    }
    static void TrianguloEstrellitas (int rows) {
        if (rows > 20 || rows < 3) {
            System.out.println("ERROR");
        }
        else {
            for (int i = 0; i <= rows; i++) {
                for (int j = 0; j < i; j++) {
                    System.out.print("*");
                }
                System.out.println();
            }
        }
    }
    static String RomboRowContent (int rows, int row) {
        String result;

        if (row > 0) {
            result = " ".repeat(rows - row) + "*".repeat(row * 2);
        }
        else {
            result = "*".repeat(row * 2);
        }

        return result;
    }
    static void Rombo (int rows) {

        for (int i = 0; i <= rows; i++) {
            System.out.println(RomboRowContent(rows, i));
        }

        for (int j = rows - 1; j > 0; j--) {
            System.out.println(RomboRowContent(rows, j));
        }
    }
    static String CuadraditoRowContent (int rows) {
        return "*" + " ".repeat(rows - 2) + "*";
    }
    static void CuadraditoEstrellitas (int rows) {
        if (rows > 0 && rows < 21) {
            System.out.println("*".repeat(rows));
            for (int i = 2; i < rows; i++) {
                System.out.println(CuadraditoRowContent(rows));
            }
            System.out.println("*".repeat(rows));
        }
        else {
            System.out.println("ERROR");
        }
    }
    static boolean IsLeapYear (int year) {
        boolean isLeapYear;

        if (year % 4 == 0)
        {
            isLeapYear = year % 100 != 0 || year % 400 == 0;
        }
        else
        {
            isLeapYear = false;
        }

        return isLeapYear;
    }
    static void BisiestosXXI () {
        for (int i = 2000; i < 3000; i++) {
            if (IsLeapYear((i))) {
                System.out.println(i);
            }
        }
    }
    static int AskForIntInRange (int min, int max) {
        int num;
        Scanner sc = new Scanner(System.in);

        System.out.printf("Introduzca un número entre %s y %s: ", min, max);
        num = Integer.parseInt(sc.nextLine());

        while (num > max || num < min) {
            System.out.print("Introduce un número entre 1 y 100: ");
            num = Integer.parseInt(sc.nextLine());
        }
        return num;
    }
    static void EscribeSerieNumeros3 () {
        /*
        Escribe una función EscribeSerieNumeros3 que nos pide tres números. El primero tendrá que ser un número entre 1 y 100; si el número no es correcto, lo vuelve a pedir. El segundo tendrá que ser un número entre 1 y 100, pero con la condición de que sea mayor que el primero; lo volverá a pedir mientras no sea correcto. El tercero tendrá que ser un número entre 1 y 100 con la condición de que sea mayor que el primero y menor que el segundo; también lo volverá a pedir hasta que sea correcto.
        Una vez que tengamos los tres números, nos escribirá por pantalla los números comprendidos entre el primero y el tercero y en otra línea los números comprendidos entre el tercero y el segundo. Mejor con un ejemplo:
            Los tres números son 5, 12 y 7. Nos tendrá que escribir:
                5 6 7
                7 8 9 10 11 12
        */
        int num1, num2, num3;

        num1 = AskForIntInRange(1, 100);
        num2 = AskForIntInRange(num1, 100);
        num3 = AskForIntInRange(num1, num2);

        for (int i = num1; i <= num3; i++) {
            System.out.print(i + " ");
        }
        System.out.println();
        for (int i = num3; i <= num2; i++) {
            System.out.print(i + " ");
        }
    }
    static int Maximo (int n1, int n2, int n3) {
        int result;

        if (n1 > n2) {
            result = Math.max(n1, n3);
        }
        else {
            result = Math.max(n2, n3);
        }

        return result;
    }
    static int Minimo (int n1, int n2, int n3) {
        int result;

        if (n1 < n2) {
            result = Math.min(n1, n3);
        }
        else {
            result = Math.min(n2, n3);
        }

        return result;
    }
    static int Medio (int n1, int n2, int n3) {
        int result, max = Maximo(n1, n2, n3), min = Minimo(n1, n2, n3);

        if (n1 < max && n1 > min) {
            result = n1;
        }
        else if (n2 < max && n2 > min) {
            result = n2;
        }
        else {
            result = n3;
        }

        return result;
    }
    static String RomboideRowContent (int rows, int stars, int row) {
        int whitespaces = rows - row - 1;
        return " ".repeat(whitespaces) + "*".repeat(stars);
    }
    static void Romboide (int rows, int stars) {
        for (int i = 0; i < rows; i++) {
            System.out.println(RomboideRowContent(rows, stars, i));
        }
    }
}
