package com.example.de01.controllers;
import org.springframework.stereotype.*;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller //forget web.xml
@RequestMapping("/users")
public class UserController {
    @GetMapping("/login")//http://localhost:8081/users/login
    public String login(Model model) {
        model.addAttribute("x", 1);
        return "login"; //login.jsp
    }
}
