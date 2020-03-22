package com.microservices.people;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
@EnableAutoConfiguration
public class PeopleApplication {
	public static void main(String[] args) {
		SpringApplication.run(PeopleApplication.class, args);
	}
}
