namespace CanteenManagementSystem.logic.models
{
    public abstract class Person
    {
        public int UserId { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public string Address { get; protected set; }

        protected Person(int userId, string firstName, string lastName,
            string email, string phoneNumber, string address)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
        
        public string GetFullName()
        {
            return $"{FirstName}, {LastName} ";
        }
    }
}