namespace CanteenManagementSystem.logic.models
{
    public abstract class User : Person
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string Role { get; protected set; }
        
        protected User(int userId, string firstName, string lastName,
            string email, string phoneNumber, string address,
            string username, string password, string role)
            : base(userId, firstName, lastName, email, phoneNumber, address)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        
        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }

        public virtual bool Logout() => true;

        public void UpdateProfile(string firstName, string lastName,
            string email, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}