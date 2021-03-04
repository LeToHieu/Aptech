/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package myapp.MyApp.models;

import java.util.Scanner;

public class Person {
    private String name;
    private String address;    

    protected Person(String name, String address) {
        this.name = name;
        this.address = address;
    }    
    protected void input(){        
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter name: ");
        this.name = scanner.next();
        System.out.println("Enter address: ");
        this.address = scanner.next();        
    }

    @Override
    public String toString() {
        return "name = "+this.name+
                "name = "+this.address; 
    }
    
}
