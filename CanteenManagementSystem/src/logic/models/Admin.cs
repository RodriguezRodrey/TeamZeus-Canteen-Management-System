namespace CanteenManagementSystem.logic.models
{
    public class Admin : User
    {
        public Admin(int userId, string firstName, string lastName, string email, string phone,
            string address, string username, string password)
            : base(userId, firstName, lastName, email, phone, address, username, password, "Admin")
        {
        }
        
        public void ManageUsers() { }
        public void ViewAllReports() { }
        public void AdjustPrices() { }
    }
}