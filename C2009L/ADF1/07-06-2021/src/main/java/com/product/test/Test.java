package com.product.test;

import java.util.Scanner;

public class Test {
    public static void main(String [] args) {
        int choice = 0;
        do {
            System.out.println("Please select:");
            System.out.println("1.Input information for n Computers.");
            System.out.println("2.Input information for n Books.");
            System.out.println("3.Display information of n Computers by sorting the\n" +
                    "price descending.");
            System.out.println("4. Display information of n Books by sorting the\n" +
                    "publisher ascending.");
            System.out.println("5.Exit.");
            System.out.println("Your choice:");
            Scanner scanner = new Scanner(System.in);
            choice = scanner.nextInt();
            switch (choice) {
                case 1:
                    System.out.println("1");
                    break;
                case 2:
                    System.out.println("2");
                    break;
                case 3:
                    System.out.println("3");
                    break;
                case 4:
                    System.out.println("4");
                    break;
                default:
                    if(choice != 5) {
                        System.out.println("Please select 1,2,3,4");
                    }
            }
        }while (choice != 5);
        System.out.println("Program ended");
    }
}
