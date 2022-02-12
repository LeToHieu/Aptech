<%-- 
    Document   : addnew.jsp
    Created on : Feb 12, 2022, 10:10:19 AM
    Author     : sunli
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Insert new Employee</h1>
        <table>
          <tr>
              <td>Employee No</td>
              <td><input type="text" required name="employeeNo"/></td>
          </tr>
          <tr>
              <td>Name</td>
              <td><input type="text" required name="employeeName"/></td>
          </tr>
          <tr>
              <td>Place Of Work</td>
              <td><input type="text" required name="placeOfWork"/></td>
          </tr>
          <tr>
              <td>Phone No</td>
              <td><input type="text" required name="phoneNo"/></td>
          </tr>
          <tr>
              <td><button>Submit Query</button></td>
              <td><input type="reset" value="Reset"></td>
          </tr>
      </table>  
    </body>
</html>