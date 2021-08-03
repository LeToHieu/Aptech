<%@page import="com.aptech.Database"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
    <center>
        <h1>Category List</h1>
        <hr>
        <%
            Database database = Database.GetInstance();            
            database.getCategories();
        %>
        <table style="width:100%">
            <tr>
              <th>ID</th>
              <th>Name</th> 
              <th>Description</th>
              <th>Actions</th>
            </tr>
            <tr>
              <td>Jill</td>
              <td>Smith</td>
              <td>50</td>
              <td><a>Show Products</a></td>
            </tr>            
          </table>
          <hr>          
    </center>        
    </body>
</html>