package com.example.de01.models;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.Collection;

@Entity
@Data
@Table(name = "tblCategory")
@NoArgsConstructor
@AllArgsConstructor
public class Category {
    @Id
    @GeneratedValue(strategy= GenerationType.AUTO)
    private int categoryId;
    private String categoryName;
    @OneToMany(fetch = FetchType.EAGER)
    private Collection<Book> books = new ArrayList<>();

}
