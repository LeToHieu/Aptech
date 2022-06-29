/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Persistence;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import models.Employee;

public class EmployeeServlet extends HttpServlet {
    public EntityManager getEntityManager() {
        return Persistence
                .createEntityManagerFactory("de07PU")
                .createEntityManager();
    }
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String type = request.getParameter("type") == null ? "" 
                : (String)request.getParameter("type");
        if(type.equals("insert")) {
            request.getRequestDispatcher("addnew.jsp").forward(request, response);     
        } else {
            if(type.equals("delete")) {
                String employeeNo = (String)request.getParameter("employeeNo");
                EntityManager entityManager = getEntityManager();
                Employee employee = entityManager
                            .createNamedQuery("Employee.findByEmployeeNo", Employee.class)  
                            .setParameter("employeeNo", employeeNo)
                            .getSingleResult();        
                entityManager.getTransaction().begin();
                entityManager.remove(employee);            
                entityManager.getTransaction().commit();                  
            }
            EntityManager entityManager = getEntityManager();
            List<Employee> employees = 
                        (List<Employee>)entityManager
                            .createNamedQuery("Employee.findAll", Employee.class)                            
                            .getResultList();           
            request.setAttribute("employees", employees);
            request.getRequestDispatcher("employees.jsp").forward(request, response);     
        }
        
    }

}
