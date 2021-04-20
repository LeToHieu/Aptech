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
            database.Database db = new database.Database();            
            //out.println(db.sayHello());
            db.getConnection();
        %>
        
    </body>
</html>
