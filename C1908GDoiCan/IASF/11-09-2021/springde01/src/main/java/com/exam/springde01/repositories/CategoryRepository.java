package com.exam.springde01.repositories;

import com.exam.springde01.models.Book;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CategoryRepository extends JpaRepository<Book, Long> {

}
