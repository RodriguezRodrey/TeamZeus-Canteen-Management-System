using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.models
{
    public abstract class User
    {
        protected int UserId { get; set; }
        protected string Username { get; set; }        
        protected string Password { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }
        protected UserRole Role { get; set; }
        
        protected User(int userId, string username, string firstName, string lastName,
            string email, string password,string phoneNumber, string address, UserRole role)
        {
            UserId = userId;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            Role = role;
        }
        
        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

        public virtual bool Logout() => true;

        protected void UpdateProfile(string firstName, string lastName,
            string email, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
        
        public string GetFullName()
        {
            return $"{LastName}, {FirstName} ";
        }
    }
}    