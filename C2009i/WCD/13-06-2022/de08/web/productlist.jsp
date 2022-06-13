<%-- 
    Document   : category
    Created on : Jun 13, 2022, 11:43:24 AM
    Author     : w11
--%>

<%@page import="com.models.Product"%>
<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        
    <center>
        <h1>Product List</h1>        
        <hr style="width:50%" />
        <table style="width:50%">
            
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Price</th>
                <th>Description</th>
                <th>Actions</th>
            </tr>
            <%            
                ArrayList<Product> products = (ArrayList<Product>)request
                                            .getAttribute("products");            
                for(Product product: products) {
                    out.print("<tr>");        
                    out.print("<td>"+product.getId()+"</td>");
                    out.print("<td>"+product.getName()+"</td>");
                    out.print("<td>"+product.getPrice()+"</td>");
                    out.print("<td>"+product.getDescription()+"</td>");
                    out.print("<td><a href='/ProductServlet?productId="+
                            product.getId()
                            +"'>Assign this product to other category</a></td>");
                    out.print("</tr>");                    
                }
            %>            
        </table>        
        <hr style="width:50%" />
    </center>        
    </body>
</html>
