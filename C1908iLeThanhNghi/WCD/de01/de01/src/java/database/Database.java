/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package database;
import Models.Product;
import java.sql.Connection;
import java.sql.DatabaseMetaData;
import java.sql.DriverManager;
import java.sql.SQLException;
import com.microsoft.sqlserver.jdbc.SQLServerDriver;
import java.beans.Statement;
import java.util.ArrayList;

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
        Statement statement = (Statement) this.connection.createStatement();
        ResultSet resultSet = 
    }
}
