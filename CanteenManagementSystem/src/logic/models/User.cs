using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.src.logic.models
{
    public abstract class User
    {
        protected int UserId { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Password { get; set; }
        protected string Address { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Username { get; set; }
        protected string Role { get; set; }

        protected User(int userId, string firstName, string lastName, string password, string address,
                       string email, string phoneNumber, string username, string role)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Username = username;
            Role = role;
        }

        protected User(int userId, string firstName, string lastName, string username, string password, string v)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }

        public string GetFullName()
        {
            return $"{LastName?.Trim()}, {FirstName?.Trim()}";
        }

        public void UpdateProfile(string firstName, string lastName, string email, string phoneNumber,
                                  string username, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Username = username;
            Role = role;
        }

        public bool Login(string username, string password)
        {
            if (Username == username && Password == password)
            {
                return true;
            }
            return false;
        }
        public virtual bool Logout()
        {
            return true;
        }
    }
}
