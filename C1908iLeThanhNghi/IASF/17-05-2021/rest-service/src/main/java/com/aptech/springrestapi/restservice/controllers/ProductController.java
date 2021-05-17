package com.aptech.springrestapi.restservice.controllers;

import com.aptech.springrestapi.restservice.models.Product;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.ArrayList;
import java.util.Hashtable;

@RestController //phuc vu cho nhan request
public class ProductController {
    //routing
    @GetMapping("/getAllProducts")
    public Hashtable<String, Object> getAllProducts(
            @RequestParam(value = "page", defaultValue = "0") Integer page,
            @RequestParam(value = "limit", defaultValue = "10") Integer limit,
            @RequestParam(value = "query", defaultValue = "") String query
    ) {
        Hashtable<String, Object> dictResponse = new Hashtable<>();
        dictResponse.put("code", 200);
        dictResponse.put("message", "Query successful");
        ArrayList<Product> fakedProducts = new ArrayList<>();
        fakedProducts.add(new Product(1, "iphone 5", "This is an iphone, 5"));
        fakedProducts.add(new Product(2, "iphone 6", "This is an iphone, 6"));
        fakedProducts.add(new Product(3, "iphone 7", "This is an iphone, 7"));
        dictResponse.put("data", fakedProducts);
        return  dictResponse;
    }

}
