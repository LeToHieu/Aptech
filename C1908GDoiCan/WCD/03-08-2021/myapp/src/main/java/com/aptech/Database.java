/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.aptech;
/**
 docker run -d --name mysql-c1908GDoiCan --volume mysql-c1908GDoiCan:/var/lib/mysql -p 3309:3306 -e MYSQL_ROOT_PASSWORD=123456 mysql
 mysql -P 3309 --protocol=tcp -u root -p
 create database c1908GDoiCan;
 use c1908GDoiCan;
 CREATE TABLE tblCategory(
   id integer auto_increment primary key,
   name varchar(300) not null,
   description text
 );
insert into tblCategory(name, description)
values('Beverages',	'Soft drinks coffees, teas, beers, and ales'),
('Condiments','Sweet and savory sauces, relishes, spreads, and seasonings'),
('Confections',	'Desserts, candies, and sweet breads'),
('Dairy', 'Products Cheeses'),
('Grains','Cereals, Breads, crackers, pasta, and cereal');
 */
import com.aptech.models.Category;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class Database {
    //singleton object
    private static Database instance;
    private Database() {}
    
    public static Database GetInstance() {
        if(instance == null) {
            instance = new Database();
        }
        return instance;
    }
    private final String connectionString = "jdbc:mysql://localhost:3309/c1908GDoiCan?user=root&password=123456";
    public Connection getConnection() {
        Connection connection = null;
        try 
        {
            Class.forName("com.mysql.jdbc.Driver").newInstance();
            connection = DriverManager.getConnection(connectionString);
        } catch (Exception ex) {
            System.out.println("SQLException: " + ex.getMessage());                
        }
        return connection;
    }
    public List<Category> getCategories() {
        List<Category> categories = new ArrayList<Category>();
        Statement stmt = null;
        ResultSet rs = null;
        try {
            stmt = this.getConnection().createStatement();
            rs = stmt.executeQuery("select * from tblCategory");            
            while(rs.next()) {
                int id = rs.getInt("id");
                String name = rs.getString("name");
                String description = rs.getString("description");
                //create Category object from id, name, desc
                Category category = new Category(id, name, description);
                categories.add(category);
            }
        }
        catch (SQLException ex){            
            System.out.println("SQLException: " + ex.getMessage());            
        }
        
        return categories;
    }
}
