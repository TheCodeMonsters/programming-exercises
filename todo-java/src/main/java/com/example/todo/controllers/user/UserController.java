package com.example.todo.controllers.user;

import com.example.todo.entities.user.User;
import com.example.todo.entities.user.UserRepository;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;


@RestController
@RequestMapping("/users")
public class UserController {

    private final UserRepository userRepository;

    public UserController(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @GetMapping
    public List<User> getUsers() {
        return userRepository.findAll();
    }

    @GetMapping("/{userId}")
    public Optional<User> getUser(@PathVariable("userId") Long userId) {
        var user = userRepository.findById(userId);
        return user;
    }

    @PostMapping
    public User newUser(@RequestBody User user) {
        return this.userRepository.save(user);
    }

    @PutMapping("/{userId}")
    public Optional<User> updateUser(@PathVariable("userId") Long userId, @RequestBody User updatedUser) {
        return this.userRepository.findById(userId)
                .map(oldUser -> this.userRepository.save(updatedUser));
    }

    @DeleteMapping("/{userId}")
    public void deleteUser(@PathVariable("UserId") Long userId) {
        this.userRepository.deleteById(userId);
    }

}
