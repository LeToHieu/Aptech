/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servlets;

import java.io.IOException;
import java.io.PrintWriter;
import javax.ejb.*;
//import static javax.enterprise.deploy.shared.ModuleType.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import sessions.CalculationSessionBean;

/**
 *
 * @author w11
 */
public class HelloServlet extends HttpServlet {
    @EJB
    private CalculationSessionBean calculationSessionBean;
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            
            throws ServletException, IOException {
        
    }
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        
    }
}
