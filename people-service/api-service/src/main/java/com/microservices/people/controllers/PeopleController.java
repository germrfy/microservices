package com.microservices.people.controllers;


import org.springframework.web.bind.annotation.*;

@RestController
public class PeopleController {
    @GetMapping("/")
    public String Test() {
        return "People Service";
    }
}