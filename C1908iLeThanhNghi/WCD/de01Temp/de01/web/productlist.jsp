<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Product list</h1>
        <%            
//            java.database.Database db = new java.database.Database();            
//            //out.println(db.sayHello());
//            db.getConnection();
            String x = "aaa";
            out.println("haha");
        %>
    <center>
        <span>Search</span>
        <input type="text" name="searchText" >
        <input type="submit" name="Search" value="Search">
    </center>
    <table>
        <tr>
            <th>ID</th>
            <th>Product Name</th>
            <th>Price</th>
            <th>Quantity</th>
            <th>Delete</th>
        </tr>
        <tr>
            <td>aa</td>
            <td>Cell2</td>
             <td>aa</td>
            <td>Cell2</td>
            <td><a href="" value=""">Add New</a></td>            
        </tr>        
    </table>
    </body>
</html>
