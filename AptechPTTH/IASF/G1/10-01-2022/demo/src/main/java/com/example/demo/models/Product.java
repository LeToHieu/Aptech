package com.example.demo.models;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="products")
public class Product {
    @Id
    private String ProductId;
    private String CategoryId;
    private String ProductName;
    private int Price;
    private String Description;

    public Product() {
    }

    public Product(String productId, String categoryId, String productName, int price, String description) {
        this.ProductId = productId;
        this.CategoryId = categoryId;
        this.ProductName = productName;
        this.Price = price;
        this.Description = description;
    }

    public String getProductId() {
        return ProductId;
    }

    public void setProductId(String productId) {
        this.ProductId = productId;
    }

    public String getCategoryId() {
        return CategoryId;
    }

    public void setCategoryId(String categoryId) {
        this.CategoryId = categoryId;
    }

    public String getProductName() {
        return ProductName;
    }

    public void setProductName(String productName) {
        this.ProductName = productName;
    }

    public int getPrice() {
        return Price;
    }

    public void setPrice(int price) {
        this.Price = price;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        this.Description = description;
    }
}
