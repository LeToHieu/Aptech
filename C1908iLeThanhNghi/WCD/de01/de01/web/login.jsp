
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>LOGIN FORM</h1>
        <jsp:include page="./header.jsp"/>
        <form action="login.jsp" method="POST">            
            <table border="0">            
            <tbody>
                <tr>
                    <td>Username:</td>
                    <td><input type="text" name="username" placeholder="Enter username"></td>                    
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><input type="password" name="password" placeholder="Enter password"></td>
                </tr>
                <tr>
                    <td><input type="submit" name="submit" value="Login"></td>
                    <td><input type="reset" name="reset" value="Reset"></td>
                </tr>
            </tbody>
        </table>
        </form>
        <%
            if(request.getParameter("submit") != null) {
                String username = request.getParameter("username");
                String password = request.getParameter("password");
                session.setAttribute("username",username); 
                session.setAttribute("id",id); 
                if(username.equals("admin") && password.equals("admin")) {
                    response.sendRedirect("index.jsp");
                }
                else {
                   out.println("Wrong username and password");
                }
            }        
        %>
<!--        <div>
            <%=Controllers.ClassA.funcA()%>
            <%
                for(Integer i = 0; i < 10; i++) {
                    out.println("i = "+String.valueOf(i));
                }
            %>
            Define a function in JSP
            <%! int sum(int x, int y) {
                return x + y;
            }
            %>
            <%=sum(1,2)%>
        </div>-->
        <jsp:include page="./footer.jsp"/>
        
    </body>
</html>
