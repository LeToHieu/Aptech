package com.product.books;

import com.product.Product;

public class Book extends Product {
    private String type;
    private String publisher;
    public Book() {

    }

    public Book(
            String proId, String proName, int year, int price,
            String type, String publisher
    ) {
        super(proId, proName, year, price);
        this.type = type;
        this.publisher = publisher;
    }

    @Override
    public void input() {
        System.out.println("Enter book's ID: ");
        this.proId = getScanner().nextLine();
        System.out.println("Enter book's name:");
        this.proName = getScanner().nextLine();
        System.out.println("Enter year : ");
        this.year = getScanner().nextInt();

        System.out.println("Enter price : ");
        this.price = getScanner().nextFloat();

        System.out.println("Enter book's type: ");
        this.type = getScanner().nextLine();

        System.out.println("Enter book's publisher: ");
        this.publisher = getScanner().nextLine();

    }

    @Override
    public void display() {

    }
}
