package com.microservices.people.repositories;

import com.microservices.people.models.Person;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface PeopleRepository extends CrudRepository<Person, Long> {

}
