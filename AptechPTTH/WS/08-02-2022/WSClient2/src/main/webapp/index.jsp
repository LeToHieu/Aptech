<%-- 
    Document   : index
    Created on : Feb 11, 2022, 11:50:19 PM
    Author     : sunli
--%>

<%@page import="java.util.List"%>
<%@page import="ws.Employee"%>
<%@page import="ws.EmployeeWS"%>
<%@page import="ws.EmployeeWS_Service"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Hello World!</h1>
        <%
            EmployeeWS_Service service = new EmployeeWS_Service();
            EmployeeWS port = service.getEmployeeWSPort();
            List<Employee> employees = port.findAll();
            System.err.println("haha");
            
            for(Employee employee: employees) {
                out.println(employee.getEmployeeName());
            }
        %>
    </body>
</html>
