/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package beans;

import java.util.ArrayList;
import javax.ejb.Local;
import models.Book;

/**
 *
 * @author w11
 */
@Local
public interface BookSessionBeanLocal {
    public ArrayList<Book> findAll();
    public ArrayList<Book> searchBookByName(String bookName);
    public void removeBookById(int id);
}
