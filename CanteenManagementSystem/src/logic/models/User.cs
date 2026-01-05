using System;
using System.Collections.Generic;
using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.models
{
    public abstract class User
    {
        public int UserId { get; protected set; }
        public string Username { get; protected set; }        
        public string Password { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string Address { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public UserRole Role { get; protected set; }
        public int CreatedByUserId { get; protected set; }
        public bool IsActive  { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<PurchaseOrder> CreatedPurchaseOrders { get; set; }
        public ICollection<PurchaseOrder> ReceivedPurchaseOrders { get; set; }
        public ICollection<StockMovement> StockMovements { get; set; }
        
        protected User() 
        {
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
        
        protected User(int userId, string username, string firstName, string lastName,
            string email, string password, string address, string phoneNumber, UserRole role)
        {
            UserId = userId;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Address = address;
            PhoneNumber = phoneNumber;
            Role = role;
            IsActive = true;
            CreatedAt = DateTime.Now;
            
        }
    }
}    