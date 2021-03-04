/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package myapp.MyApp.models;

import java.util.Scanner;

public class InformationDisplay {
    private Scanner scanner;
    public void input() {        
        int choice = 0;
        if(scanner == null) {
            scanner = new Scanner(System.in);//lazy init
        }
        while(choice != 4) {
            System.out.println("Enter your choice : ");
            choice = scanner.nextInt();
            switch(choice) {
                case 1:
                    System.out.println("Input a Student");
                    break;
                case 2:
                    System.out.println("Input a Employee");
                    break;
                case 3:
                    System.out.println("Input a Customer");
                    break;
                case 4:
                    System.out.println("Exit");
                    break;
                default:
                    break;
            }
        }
    }
}
