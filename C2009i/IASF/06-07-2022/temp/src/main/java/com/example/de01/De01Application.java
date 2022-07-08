package com.example.de01;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
@SpringBootApplication
public class De01Application {
	public static void main(String[] args) {
		SpringApplication.run(De01Application.class, args);
	}
}
/*
USE de01;
CREATE TABLE Book(
	BookId int PRIMARY KEY AUTO_INCREMENT,
	title varchar(50),
	Price float,
	categoryId int
);
CREATE TABLE Category(
	categoryId int PRIMARY KEY AUTO_INCREMENT,
	categoryName varchar(50)
);

CREATE TABLE User(
	userId int PRIMARY KEY AUTO_INCREMENT,
	userName varchar(50),
	password varchar(20)
);
*/
