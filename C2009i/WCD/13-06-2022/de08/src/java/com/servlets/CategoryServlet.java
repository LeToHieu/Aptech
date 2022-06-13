/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.servlets;

import com.models.*;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class CategoryServlet extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        //response.setContentType("text/html;charset=UTF-8");
        ArrayList<Category> categories = new ArrayList<Category>();
        categories.add(new Category(1, "sea food", "this is sea food"));
        categories.add(new Category(1, "djshfdf", "thisd,sfkdolk is sea food"));
        request.setAttribute("categories",categories);
        request.getRequestDispatcher("category.jsp").forward(request, response);                        
    }
    
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
            PrintWriter out = response.getWriter();
            out.println("<h1>GET Category Servlet<h1>");                
    }
}
