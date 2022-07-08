package com.example.de01.models;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


@Entity
@Data
@Table(name = "tblBook")
@NoArgsConstructor
@AllArgsConstructor
public class Book {
    @Id
    @GeneratedValue(strategy= GenerationType.AUTO)
    private int bookId;
    private float price;
    private String title;

    @ManyToOne
    @JoinColumn(name="category_id", nullable=false)
    private Category category;
}

