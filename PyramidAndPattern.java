//package project.pyramidandpattern;

import java.util.Scanner;

public class PyramidAndPattern {

    public static void clear(){ System.out.println("\033[H\033[2J"); }
    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);
        int chose, num, n = 5, quit = 0;

        clear();
        while (quit != 1) {
            System.out.println("""
                               ---Piramides---
                               [1]Meia piramede
                               [2]Meia piramide 180\u00b0
                               [3]Piramide
                               [4]Piramide n\u00famerica inversa
                               [5]Piramide espelho
                               [6]Meia piramide n\u00famerica
                               [7]Piramide pad\u00e3o n\u00famerico
                               [0]Exit""");

            chose = in.nextInt();
            switch (chose) {

                case 1 -> {
                    clear();
                    for (int i = 0; i < n; i++) {
                        for (int a = 0; a <= i; a++) {
                            System.out.print("* ");
                        }
                        System.out.println();
                    }
                }
                case 2 -> {
                    clear();
                    for (int i = 0; i < n; i++) {
                        for (int a = 2 * (n - i); a >= 0; a--) {
                            System.out.print(" ");
                        }
                        for (int a = 0; a <= i; a++) {
                            System.out.print("* ");
                        }
                        System.out.println();
                    }
                }
                case 3 -> {
                    clear();
                    for (int i = 0; i < n; i++) {
                        for (int a = n - i; a > 1; a--) {
                            System.out.print(" ");
                        }
                        for (int a = 0; a <= i; a++) {
                            System.out.print("* ");
                        }
                        System.out.println();
                    }
                }
                case 4 -> {
                    n = 6;
                    clear();
                    for (int i = 1; i <= n; i++) {
                        for (int a = 1; a < i; a++) {
                            System.out.print(" ");
                        }
                        for (int a = i; a <= n; a++) {
                            System.out.print(a + " ");
                        }
                        System.out.println();
                    }
                }
                case 5 -> {
                    n = 7;
                    clear();
                    for (int i = 1; i <= n; i++) {
                        for (int a = 1; a < i; a++) {
                            System.out.print(" ");
                        }
                        for (int a = i; a <= n; a++) {
                            System.out.print(a + " ");
                        }
                        System.out.println();
                    }
                    for (int i = n - 1; i >= 1; i--) {
                        for (int a = 1; a < i; a++) {
                            System.out.print(" ");
                        }
                        for (int j = i; j <= n; j++) {
                            System.out.print(j + " ");
                        }
                        System.out.println();
                    }
                }
                case 6 -> {
                    clear();
                    for (int i = 0; i < n; i++) {
                        num = 1;
                        for (int a = 0; a <= i; a++) {
                            System.out.print(num + " ");
                            num++;
                        }
                        System.out.println();
                    }
                }
                case 7 -> {
                    num = 1;
                    clear();
                    for (int i = 0; i < n; i++) {
                        for (int a = 0; a <= i; a++) {
                            System.out.print(num + " ");
                            num = num + 1;
                        }
                        System.out.println();
                    }
                }
                case 0 -> {
                    quit = 1;
                }
                default -> {
                    clear();
                    System.out.print("Valor invalido\n");
                }
            }
        }
        in.close();
    }
}
