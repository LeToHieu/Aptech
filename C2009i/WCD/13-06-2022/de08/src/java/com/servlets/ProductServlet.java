/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlets;

import com.models.Category;
import com.models.Product;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


public class ProductServlet extends HttpServlet {
    
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String actionName = request.getParameter("actionName");
        if(actionName.equals("showProducts")) {
            this.showProducts(request, response);
        } else if (actionName.equals("assignCategory")) {
            assignCategory(request, response);
        }                    
    }
    //like action result
    private void showProducts(HttpServletRequest request, HttpServletResponse response) {
        int categoryId = Integer.valueOf(request.getParameter("categoryId"));            
        ArrayList<Product> products = new ArrayList<Product>();
        products.add(new Product(1, "DSDSDSD", 123.5, "djhsuhdsh"));
        request.setAttribute("products",products);
        request.getRequestDispatcher("productlist.jsp").forward(request, response);           
    }
    private void assignCategory(HttpServletRequest request, 
            HttpServletResponse response) {
        int productId = Integer.valueOf(request.getParameter("productId"));
    }
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        
    }
}
