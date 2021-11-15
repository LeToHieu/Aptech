
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>This is index</h1>
        <p>Do abccc...</p>
        <%!Double multiply2Numbers(Double x, Double y) {
            return x * y;
        }            
        %>
        <p>Do abccc...</p>
        <%
            Double z = multiply2Numbers(2.0, 3.0);
            out.println("z = "+z);
            System.out.println("This is in your console");
        %>
        
        <!--This is a comment-->
        <%
            int x = 100;//primitive
            int y = 200;
           
            Integer sum = x + y;
            out.println("max int = "+Integer.MAX_VALUE);
            out.println("haha");
            //out = JSP implicit object
            String name = request.getParameter("name") == null ? "":
                            request.getParameter("name");
            Integer age = Integer.valueOf(request.getParameter("age"));
            out.println(String.format("name = %s, age = %d", name, age));
        %>        
        <p>Do something...</p>
        <%
            Float a = 12.33f;
            Double b = 222.4455;
        %>
        <p>Other...</p>
        <%
            out.println("a = "+a+", b = "+b);            
        %>
        <%for(Integer i = 0; i < 10; i++) {%>
            <p style="color: red; font-weight: bold"><%out.print("i = "+i);%></p>
        <%}%>                 
        
        <%= multiply2Numbers(5.0, 3.0)%>
    </body>
</html>
