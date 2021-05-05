<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ page import="java.util.*,database.*,models.*" %>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Product list</h1>
        
    <center>
        <span>Search</span>
        <input type="text" name="searchText" >
        <input type="submit" name="Search" value="Search">
    </center>
    <table>
        <tr>            
            <th>Product Name</th>
            <th>Price</th>
            <th>Quantity</th>
            <th>Delete</th>
        </tr>
        <%            
            Database db = new Database();   
            out.println("haha");
            //out.println(db.sayHello());
            ArrayList<Product> products = db.getAllProducts();                        
            for(Product product: products) {
                out.print("<tr>");
                out.print("<td>"+product.getProductName()+"</td>");
                out.print("<td>"+product.getPrice()+"</td>");
                out.print("<td>"+product.getQuantity()+"</td>");
                out.print("</tr>");
                out.print("<td><a>Add New</a></td> ");        
            }
        %>            
    </table>
    </body>
</html>
