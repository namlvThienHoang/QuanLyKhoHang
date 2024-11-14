using AutoMapper;
using QuanLyKhoHang.DAL;
using QuanLyKhoHang.DAL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.BLL.Auth
{
    public class AuthService
    {
        private readonly IRepository<User> _userRepository;

        public AuthService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        // Register method
        public bool Register(string username, string password)
        {
            // Check if the username already exists
            var existingUser = _userRepository.Find(u => u.Username == username);
            if (existingUser != null)
            {
                throw new Exception("Username already exists.");
            }

            // Create a new user object and save to the repository
            var newUser = new User
            {
                Username = username,
                PasswordHash = HashPassword(password),
                Role = "User", 
                CreatedDate = DateTime.Now
            };

            _userRepository.Add(newUser);
            return true;
        }

        // Login method
        public User Login(string username, string password)
        {
            // Retrieve the user by username
            var user = _userRepository.Find(u => u.Username == username);
            if (user == null || !VerifyPassword(password, user.PasswordHash))
            {
                throw new Exception("Invalid username or password.");
            }

            return user; // Return the user if login is successful
        }

        // Password hashing for registration (use a secure hashing method in a real app)
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private bool VerifyPassword(string inputPassword, string storedHashedPassword)
        {
            var inputHash = HashPassword(inputPassword);
            return inputHash == storedHashedPassword;
        }
    }
}
