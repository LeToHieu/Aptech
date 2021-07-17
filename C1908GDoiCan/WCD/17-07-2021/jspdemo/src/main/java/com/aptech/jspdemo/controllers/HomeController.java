package com.aptech.jspdemo.controllers;

import java.io.IOException;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletOutputStream;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
//import jakarta.servlet.ServletException;
//import jakarta.servlet.http.HttpServlet;
//import jakarta.servlet.http.HttpServletRequest;
//import jakarta.servlet.http.HttpServletResponse;
//trong .net mvc => [Route("homes")] => config trong web.xml
public class HomeController extends HttpServlet {
    public HomeController() {
        super();
        // TODO Auto-generated constructor stub
    }
    //trong .net mvc => [HttpGet]
    //Gui params.VD: http://localhost:80/homes?x=1&y=2
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {		
		ServletOutputStream out = response.getOutputStream();
		out.println("haha");
//		request.getParameter("x");
//		request.getParameter("y");
	}
	//trong .net mvc => [HttpPost]
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
	}

}
