
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>    
    <body>
        <h1>This is index</h1>
        <!--code java here-->
        <%
            int x = 10;//primitive value
            Integer y = 20; //object
            Integer sum = x + y;            
            out.println(String.format("sum = %d", sum)); //echo in PHP
        %>
        <h2>Something else</h2>
        <h1><%
            out.print("y = "+y);
        %></h1>
        <div>
            <%for(int i = 1; i < 10; i++) {%>
            <p style="color: red;"><%out.println("i = "+i);%></p>
            <%}%>
        </div>
        <!--Let's define a method/function-->
        <!--declare a funtion-->
        <%!int sum2Number(int a, int b) {
                return a + b;
           }
        %>
        <p>Do abc..</p>
        <%
           Integer mySum = sum2Number(2, 10);
           out.println("mySum = "+mySum);
           //out, request = JSP implicit object
           //request.getParameter("email") //let's try using debug/watch
           String email = request.getParameter("email") == null ? "" :
                            request.getParameter("email");
           String password = request.getParameter("password") == null ? "" :
                            request.getParameter("password");
           out.println(String.format("email = %s, password = %s", email, password));
        %>
           
    </body>
</html>
