package com.example.de01.controllers;
import lombok.NoArgsConstructor;
import lombok.RequiredArgsConstructor;
import lombok.extern.log4j.Log4j2;
import org.springframework.stereotype.*;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpSession;

@Controller //forget web.xml
@RequiredArgsConstructor
@Log4j2
@RequestMapping("/users")
public class UserController {
    private final HttpSession httpSession;
    @GetMapping("/login")//http://localhost:8082/users/login
    public String login(Model model) {
        log.info("login request");
        try {
//            if((Boolean) httpSession.getAttribute("isLoggedIn")){
//                return "redirect:/books";
//            }
            return "login"; //login.jsp
            //return "redirect:/books";
        }catch (Exception e) {
            log.error("error is {}", e.toString());
            return "login"; //login.jsp
        }
    }
    @PostMapping("/login")//http://localhost:8082/users/login
    public String loginToYourAccount(Model model,
                                     @RequestParam String username,
                                     @RequestParam String password) {
        model.addAttribute("x", 1);
        return "redirect:/books";
        //return "login"; //login.jsp //sai pass
    }

}
