/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import beans.StudentBeanLocal;
import java.io.IOException;
import java.io.PrintWriter;
import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author w11
 */
public class StudentServlet extends HttpServlet {

    @EJB
    private StudentBeanLocal studentBean;

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String type = request.getParameter("type") == null ? "" 
                : (String)request.getParameter("type");
        if(type.equals("")) {
            request.getRequestDispatcher("list.jsp").forward(request, response);     
        } else {
            if(type.equals("delete")) {
                String rollNumber = (String)request.getParameter("rollnumber");
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

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //Insert code => call Enterprise Beans
        
    }

  
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
