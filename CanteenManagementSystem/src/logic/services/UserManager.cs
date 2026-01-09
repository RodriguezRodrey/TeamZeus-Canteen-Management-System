using System;
using System.Collections.Generic;
using System.Linq;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.interfaces;

namespace CanteenManagementSystem.logic.services
{
    public class UserManager
    {
        private IUserRepository _userRepository;
        
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User AuthenticateUser(string username, string password)
        {
            return _userRepository.AuthenticateUser(username, password);
        }

        public void CreateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
                throw new ArgumentException("Username is required");
            
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new ArgumentException("Password is required");
            
            User existingUser = _userRepository.GetByUsername(user.Username);
            
            if (existingUser != null)
                throw new InvalidOperationException("Username already exists");
            
            _userRepository.Save(user);
        }

        public void UpdateUser(User user)
        {
            User existingUser = _userRepository.GetById(user.UserId);
            if (existingUser == null)
                throw new ArgumentException("User not found");
            
            _userRepository.Update(user);
        }

        public void DeactivateUser(int userId)
        {
            User user = _userRepository.GetById(userId);
            if (user == null)
                throw new ArgumentException("User not found");
            
            _userRepository.Delete(userId);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetById(userId);
        }
    }
}