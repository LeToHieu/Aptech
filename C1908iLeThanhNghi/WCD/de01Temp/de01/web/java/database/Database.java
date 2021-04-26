/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java.database;
import Models.Product;
import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.DriverManager;
import java.sql.SQLException;
import com.microsoft.sqlserver.jdbc.SQLServerDriver;
import java.util.ArrayList;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Database {
    private static final String CONNECTION_STRING = "jdbc:sqlserver://localhost\\SQLEXPRESS;DatabaseName=ExamSERVJSP";
    private static final String USERNAME = "sa";
    private static final String PASSWORD = "123456";
    private Connection connection = null;
    public String sayHello(){
        return "hahahaa";
    }
    public Connection getConnection(){
        try {             
            //ExamSERVJSP
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            this.connection = DriverManager.getConnection(CONNECTION_STRING, USERNAME, PASSWORD);
            if (connection != null) {
                DatabaseMetaData dm = (DatabaseMetaData) this.connection.getMetaData();
                System.out.println("Driver name: " + dm.getDriverName());
                System.out.println("Driver version: " + dm.getDriverVersion());
                System.out.println("Product name: " + dm.getDatabaseProductName());
                System.out.println("Product version: " + dm.getDatabaseProductVersion());
            }
            return this.connection; 
        } catch (Exception ex) {
            ex.printStackTrace();
            return null;
        } 
    }
    public ArrayList<Product> getAllProducts() {
        ArrayList<Product> products = new ArrayList<Product>();
        try {            
            Statement statement = (Statement) this.connection.createStatement();
            String sql = "SELECT * FROM tblProduct";
            ResultSet resultSet = statement.executeQuery(sql);
            while (resultSet.next()) {
                Integer id = resultSet.getInt("id");
                String productName = resultSet.getString("productName");
                Float price = resultSet.getFloat("price");
                Integer quantity = resultSet.getInt("quantity");
                Product product = new Product(id, productName, price, quantity);
                products.add(product);
            }
            
        } catch(SQLException ex) {
        } finally {
            return products;
        }                
    }
    
}
